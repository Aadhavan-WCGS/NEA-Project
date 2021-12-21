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
        bool start = false;
        particle p; //Particle instantiation.
        double timeNum = 0;
        int startX;
        int startY;
        double[] accEqn;
        double[] velEqn;
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
            accEqnTxt.Text = "Acceleration Equation: ";
            velEqnTxt.Text = "Velocity Equation: ";
            start = false;
            varAccTimer.Stop();

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
                p = sim.varAccSetup(coefficients);
                start = true;
                // Following lines display relevant stats by calling the getters for the simulation.      
                velEqn = sim.getVel();
                velEqnTxt.Text = "Velocity Equation: " + velEqn[0].ToString() + " + " + velEqn[1].ToString() + "t +" + velEqn[2].ToString() + "t\xB2 +" + velEqn[3].ToString() + "t\xB3";
                accEqn = sim.getAcc();
                timeTxt.Text = "Time elapsed: ";
                accTxt.Text = "Acceleration: ";
                speedTxt.Text = "Speed: ";
                dispTxt.Text = "Displacement: ";
                accEqnTxt.Text = "Acceleration Equation: " + accEqn[0].ToString() + " + " + accEqn[1].ToString() + "t +" + accEqn[2].ToString() + "t\xB2 +" + accEqn[3].ToString() + "t\xB3"; ;
                
                varAccTimer.Start(); //Starts timer to begin simulation animation.
                p.setVel(velEqn[0], 0); //Sets initial velocity.
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
            double vel = sim.sub(sim.getVel(), (timeNum / 1000));
            double dis = sim.sub(sim.getDis(), (timeNum / 1000));
            //Sets force as acceleration, as mass = 1kg.
            p.setForce(acc, 0);
            p.move(ball);
            timeTxt.Text = "Time elapsed: " + timeNum / 1000 + "s";
            speedTxt.Text = "Speed: " + Math.Round(vel, 2) + " ms\u207b\xB9";
            accTxt.Text = "Acceleration: " + Math.Round(acc, 2) + "ms\u207b\xB2"; 
            dispTxt.Text = "Displacement: " + Math.Round(dis, 2) + "m";

        }

        private void varAccSim_Load(object sender, EventArgs e)
        {

        }
    }
}
