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
        bool test = false;
        bool start = false;
        double ans, mass, forceX, forceY;
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

        public void forceQuestion()
        {
            Random rnd = new Random(); //Initialise random variable.
            int choice = rnd.Next(1, 3); //Used to decide what question to give.
            mass = rnd.Next(1, 5) * 5; //Generate a suitable mass.
            forceX = rnd.Next(1, 5) * 5; //Generate a suitable horizontal force.
            forceY = rnd.Next(1, 5) * 5; //Generate a suitable vertical force.
            forces sim = new forces();
            sim.forcesSetup(mass, forceX, forceY);
            string info = "A particle of mass " + mass + "kg is given a horizontal component force of " + forceX + "N and a vertical component force of " + forceY + "N.";  //String containing question and relevant background information.

            switch (choice)  //Adds a different question to the string depending on the number generated.
            {
                case 1:
                    info += " What is the magnitude of the acceleration of the particle?";
                    ans = sim.getAcc();
                    ansUnitsLabel.Text = "ms\u207b\xB2";
                    break;
                case 2:
                    info += " What is the magnitude of the resultant force on the particle?";
                    ans = sim.getRf();
                    ansUnitsLabel.Text = "N";
                    break;
            }
            info += " (give answer to 2 decimal places)";
            questionLabel.Text = info; 
        }
        public void reset() //Resets displayed stats, picturebox locations, time and also stops timer.
        {
            correctLabel.Text = "";  //Initialise question feedback label to blank.
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

        private void checkBtn_Click(object sender, EventArgs e)
        {
            NumericUpDown[] boxes = { massBox, xfBox, yfBox };
            double[] data = { mass, forceX, forceY};
            simForms.check(boxes, data, ans, ansBox.Text, switchBtn, correctLabel); //Calles routine to check answer and run animation if correct.
        }

        private void generateQuestion_Click(object sender, EventArgs e)
        {
            reset();
            forceQuestion(); //Generates new question.
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close(); //Close window when exit button clicked.
        }

        private void learnBox_CheckedChanged(object sender, EventArgs e)
        {
            assumptions.Visible = !assumptions.Visible; //Toggle assumptions label visibility.
        }

        private void testMode_Click(object sender, EventArgs e)
        {
            reset();
            simForms.testSetup(statsPanel, controlPanel, questionLabel, learnBox);
            if (test) { testMode.Text = "Test yourself"; } else { testMode.Text = "Return to simulation"; forceQuestion(); } //Change text displayed on button to reflect mode change. Generates a question if switched to test mode.
            test = !test;
        }
    }
}
