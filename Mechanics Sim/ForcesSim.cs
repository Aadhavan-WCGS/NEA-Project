using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mechanics_Sim
{
    public partial class ForcesSim : Form
    {
        //Declaring variables with scope of the simulation form.
        PictureBox ball; //Initialise all pictureboxes to be used.
        bool start = false;
        particle p; //Particle instantiation.
        double timeNum = 0; //Variable to store time elapsed, set to zero initially.
        int startX; //Starting coordinates of particle.
        int startY;
        public ForcesSim()
        {
            InitializeComponent();
            simForms.initiate(statsPanel, controlPanel, this); //Initialise ui elements.
            startX = this.Width / 2; ;
            startY = this.Height / 2;
            //Appropriate pictureboxes are defined below.
            ball = new PictureBox
            {
                Name = "Ball",
                Size = new Size(60, 60),
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = Properties.Resources.Ball,
            };
            Controls.Add(ball);
            reset();
        }

        public void reset() //Resets displayed stats, picturebox locations, time and also stops timer.
        {
            ball.Location = new Point(startX, startY); //Sets particle picturebox location back to initial.
            timeNum = 0; //Set time elapsed back to zero.
            timeTxt.Text = "Time elapsed: "; //Following code resets text in all labels.
            rfTxt.Text = "Resultant Force: ";
            accTxt.Text = "Acceleration: ";
            speedTxt.Text = "Speed: ";
            start = false; //Sets start to false to indicate simulation is not running.
            forceTimer.Stop();
        }
    
        private void Switch_Click(object sender, EventArgs e)
        {
            if (!start)
            {
                //Following lines instantiate simulation and appropriately configure the particle.
                forces sim = new forces();
                p = sim.forcesSetup(Convert.ToDouble(massBox.Text), Convert.ToDouble(xfBox.Text), Convert.ToDouble(yfBox.Text)); //Calls routine to setup simulation, returning a configured particle.
                start = true;
                rfTxt.Text = "Resultant Force: " + sim.getRf() + " N";
                accTxt.Text = "Acceleration: " + sim.getAcc() + " ms\u207b\xB2";
                forceTimer.Start();
            }
            else
            {
                if (forceTimer.Enabled) { forceTimer.Stop(); } else { forceTimer.Start(); }
            }
            
            
        }

        private void forceTimer_Tick(object sender, EventArgs e)  //Timer function, responible for animation.
        {
            simForms.time(ref timeNum, ref start, (false), forceTimer);  //Condition is simply false here as simulation continues indefinitely until user responds appropriately.
            //Call move method for pictureboxes, update stats.
            p.move(ball);
            speedTxt.Text = "Speed: " + p.getSpeed().ToString() + " ms\u207b\xB9"; 
            timeTxt.Text = "Time Elapsed: " + timeNum/1000 + " s";
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            reset(); //Call reset routine on button click.
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close(); //Close window when exit button clicked.
        }

        private void learnBox_CheckedChanged(object sender, EventArgs e)
        {
            assumptions.Visible = !assumptions.Visible; //Toggle assumptions label visibility.
        }
    }
}
