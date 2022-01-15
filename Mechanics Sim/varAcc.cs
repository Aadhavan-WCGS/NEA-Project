using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mechanics_Sim
{
    public partial class varAccSim : Form
    {
        PictureBox ball;
        bool oneD = true;
        bool start = false;
        particle p; //Particle instantiation.
        double timeNum = 0;
        int startX, startY;
        double[] disEqn, disEqnY, accEqn, velEqn, accEqnY, velEqnY;  //Global variables to store equations.
        varAcc sim = new varAcc();
        public varAccSim()
        {
            InitializeComponent();
            simForms.initiate(statsPanel, controlPanel, this); //Initialise ui elements.
            startX = this.Width/2;
            startY = this.Height/2;
            //Appropriate pictureboxes are defined below.
            ball = new PictureBox
            {
                Name = "Ball",
                Size = new Size(60, 60),
                Location = new Point(startX, startY),
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = Properties.Resources.Ball,
            };
            Controls.Add(ball);
            reset();
        }

        public void reset() //Resets displayed stats, picturebox locations, time and also stops timer.
        {
            ball.Location = new Point(startX, startY);
            timeNum = 0;
            timeTxt.Text = "Time elapsed: ";
            accTxt.Text = "Acceleration: ";
            speedTxt.Text = "Speed: ";
            dispTxt.Text = "Displacement: ";
            accEqnTxt.Text = "Acceleration equation X: ";
            velEqnTxt.Text = "Velocity equation X: ";
            accEqnYTxt.Text = "Acceleration equation Y: ";
            velEqnYTxt.Text = "Velocity equation Y: ";
            start = false;
            varAccTimer.Stop();

        }



        private void learnBox_CheckedChanged(object sender, EventArgs e)
        {
            assumptions.Visible = !assumptions.Visible; //Toggle assumptions label visibility.
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void switchBtn_Click(object sender, EventArgs e)
        {
            if (!start)
            {
                //Following lines instantiate simulation and appropriately configure the particle.
                double[] coefficients = {Convert.ToDouble(x0Box.Text), Convert.ToDouble(x1Box.Text), Convert.ToDouble(x2Box.Text), Convert.ToDouble(x3Box.Text)};
                disEqn = coefficients;
                p = sim.varAccSetup(disEqn);
                if (!oneD)
                {
                    double[] coefficientsY = { Convert.ToDouble(y0Box.Text), Convert.ToDouble(y1Box.Text), Convert.ToDouble(y2Box.Text), Convert.ToDouble(y3Box.Text) };
                    sim.varAccSetupY(coefficientsY);
                    disEqnY = coefficientsY;
                    velEqnY = sim.getVelY();
                    accEqnY = sim.getAccY();
                    velEqnYTxt.Text = "Velocity equation Y:      " + velEqnY[0].ToString() + " + " + velEqnY[1].ToString() + "t +" + velEqnY[2].ToString() + "t\xB2 +" + velEqnY[3].ToString() + "t\xB3";
                    accEqnYTxt.Text = "Acceleration equation Y:      " + accEqnY[0].ToString() + " + " + accEqnY[1].ToString() + "t +" + accEqnY[2].ToString() + "t\xB2 +" + accEqnY[3].ToString() + "t\xB3";
                }
                start = true;
                // Following lines display relevant stats by calling the getters for the simulation.      
                velEqn = sim.getVel();
                accEqn = sim.getAcc();
                velEqnTxt.Text = "Velocity equation X:      " + velEqn[0].ToString() + " + " + velEqn[1].ToString() + "t +" + velEqn[2].ToString() + "t\xB2 +" + velEqn[3].ToString() + "t\xB3";
                timeTxt.Text = "Time elapsed: ";
                accTxt.Text = "Acceleration : ";
                speedTxt.Text = "Speed: ";
                dispTxt.Text = "Displacement: ";
                accEqnTxt.Text = "Acceleration equation X:      " + accEqn[0].ToString() + " + " + accEqn[1].ToString() + "t +" + accEqn[2].ToString() + "t\xB2 +" + accEqn[3].ToString() + "t\xB3";        
                varAccTimer.Start(); //Starts timer to begin simulation animation.
                if (oneD) { p.setVel(velEqn[0], 0); } else { p.setVel(velEqn[0], velEqnY[0]);} //Sets initial velocity.      
            }
            else
            {
                if (varAccTimer.Enabled) { varAccTimer.Stop(); } else { varAccTimer.Start(); } //Allows button to behave as a toggle, to start or stop simulation.
            }
        }

        private void varAccTimer_Tick(object sender, EventArgs e)
        {
            simForms.time(ref timeNum, ref start, false, varAccTimer);
            //Finds current value of acceleration, velocity, displacement.
            double acc = sim.sub(accEqn, timeNum / 1000);
            double vel = sim.sub(velEqn, (timeNum / 1000));
            double dis = sim.sub(disEqn, (timeNum / 1000));
            if (!oneD) //Initialises y component of motion if the 2D case is enabled.
            {
                double accY = sim.sub(accEqnY, timeNum / 1000);
                double velY = sim.sub(velEqnY, (timeNum / 1000));
                double disY = sim.sub(disEqnY, (timeNum / 1000));
                p.setForce(acc, accY);
                speedTxt.Text = "Speed: " + Math.Round(Math.Sqrt(vel * vel + velY * velY), 2) + " ms\u207b\xB9"; // Finds magnitude of speed
                accTxt.Text = "Acceleration: " + Math.Round(Math.Sqrt(acc * acc + accY * accY), 2) + "ms\u207b\xB2";// Finds magnitude of acceleration
                dispTxt.Text = "Displacement: " + Math.Round(Math.Sqrt(dis * dis + disY * disY), 2) + "m";// Finds magnitude of acceleration

            }
            else
            {
                p.setForce(acc, 0); //Sets force as acceleration, as mass = 1kg.
                //Updates statistics.
                speedTxt.Text = "Speed: " + Math.Round(vel, 2) + " ms\u207b\xB9";
                accTxt.Text = "Acceleration: " + Math.Round(acc, 2) + "ms\u207b\xB2";
                dispTxt.Text = "Displacement: " + Math.Round(dis, 2) + "m";
            }
            p.move(ball);
            timeTxt.Text = "Time elapsed: " + timeNum / 1000 + "s";
        }

        private void varAccSim_Load(object sender, EventArgs e)
        {

        }

        private void dimensionSwitch_Click(object sender, EventArgs e)
        {
            oneD = !oneD; //Flips boolean used to check if 1D is used.
            velEqnYTxt.Visible = !velEqnYTxt.Visible;
            accEqnYTxt.Visible = !accEqnYTxt.Visible;
            string ybox = "y0Box"; //Creates string used to identify NumericUpDown controls.
            string ylabels = "t0LabelY"; //Creates string used to identify label controls.
            for (int i = 0; i < 4; i++){
                Control boxy = controlPanel.Controls[ybox];
                Control labely = controlPanel.Controls[ylabels];
                boxy.Visible = !boxy.Visible; //Makes invisible controls visible and vice versa.
                labely.Visible = !labely.Visible;
                ybox = "y" + (i + 1) + "Box";
                ylabels = "t" + (i + 1) + "LabelY";
            }
            bracketL.Visible = !bracketL.Visible; bracketR.Visible = !bracketR.Visible;
            if (dimensionSwitch.Text == "1D"){dimensionSwitch.Text = "2D";}else{dimensionSwitch.Text = "1D";}   //Changes text in dimension switch button to show what mode program is in.
            reset();
        }

      
    }
}
