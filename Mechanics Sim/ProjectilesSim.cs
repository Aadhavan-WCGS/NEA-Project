using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mechanics_Sim
{
    public partial class LearnCheckBox : Form
    {
        //Declaring variables with scope of the simulation form.
        PictureBox proj; //Initialise all pictureboxes to be used.
        bool test;
        double ans, speed, angle;
        bool start = false;
        particle p; //Particle instantiation.
        double timeNum = 0; //Variable to store time elapsed, set to zero initially.
        int startX, startY; //Starting coordinates of projectile.
        public LearnCheckBox()
        {
            InitializeComponent();  
            simForms.initiate(statsPanel, controlPanel, this); //Initialise ui elements.
            assumptions.Anchor = (AnchorStyles.Top | AnchorStyles.Left); //Keeps Assumptions label at top right of screen.
            startX = 60;
            startY = this.Height - 40;
            //Appropriate pictureboxe defined below.
            proj = new PictureBox
            {
                Name = "Ball",
                Size = new Size(60, 60),
                Location = new Point(startX, startY),
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = Properties.Resources.Ball,
            };
            Controls.Add(proj);
            reset();
        }

        public void projQuestion()
        {
            Random rnd = new Random(); //Initialise random variable.
            int choice = rnd.Next(1, 4); //Used to decide what question to give.
            angle = rnd.Next(1, 5) * 15; //Generate a suitables angle.
            speed = rnd.Next(1, 5) * 5; //Generate a suitables speed.
            projectiles sim = new projectiles();
            p = sim.projectilesSetup(Convert.ToDouble(speed), Convert.ToDouble(angle));
            string info = "A projectile is fired with an initial speed of " + speed + "ms\u207b\xB9 at an angle of " + angle + "° to the horizontal.";  //String containing question and relevant background information.
            switch (choice)  //Adds a different question to the string depending on the number generated.
            {
                case 1:
                    info += " What is the range (Total horizontal distance travelled)?";
                    ans = sim.getRange();
                    ansUnitsLabel.Text = "m";
                    break;
                case 2:
                    info += " What is the maximum height reached?";
                    ans = sim.getMaxH();
                    ansUnitsLabel.Text = "m";
                    break;
                case 3:
                    info += " What is the time of flight (Time taken to return to same height at which it was fired)?";
                    ans = sim.getTof();
                    ansUnitsLabel.Text = "s";
                    break;
            }
            info += " (g = 9.8, give answer to 2 decimal places)";
            questionLabel.Text=info;

        }

        public void reset() //Resets displayed stats, picturebox locations, time and also stops timer.
        {
            correctLabel.Text = "";
            proj.Location = new Point(startX, startY); //Sets particle picturebox location back to initial.
            timeNum = 0; //Set time elapsed back to zero.
            timeTxt.Text = "Time elapsed: "; //Following code resets text in all labels.
            rangeTxt.Text = "Range: ";
            tofTxt.Text = "Time of flight: ";
            maxhTxt.Text = "Max height: ";
            accTxt.Text = "Acceleration: ";
            speedTxt.Text = "Speed: ";
            start = false; //Sets start to false to indicate simulation is not running.
            projTimer.Stop();

        }
        private void Switch_Click(object sender, EventArgs e)
        {
            if (!start)
            {
                //Following lines instantiate simulation and appropriately configure the particle.
                projectiles sim = new projectiles();
                p = sim.projectilesSetup(Convert.ToDouble(uBox.Text), Convert.ToDouble(angleBox.Text)); //Calls routine to setup simulation, returning a configured particle.
                start = true;
                // Following lines display relevant stats by calling the getters for the simulation.
                accTxt.Text = "Acceleration: " + 9.81 + " ms\u207b\xB2";
                rangeTxt.Text = "Range: " + sim.getRange() + " m";
                tofTxt.Text = "Time of flight: " + sim.getTof() + " s";
                maxhTxt.Text = "Max height: " + sim.getMaxH() + " m";
                projTimer.Start(); //Starts timer to begin simulation animation.
            }
            else
            {
                if (projTimer.Enabled) { projTimer.Stop(); } else { projTimer.Start(); } //Allows button to behave as a toggle, to start or stop simulation.
            }
            
            
        }

        private void projTimer_Tick(object sender, EventArgs e) //Timer function, responible for animation.
        {
            simForms.time(ref timeNum, ref start, (proj.Top > startY), projTimer); //Projectile  should stop when it reaches its initial height.
            //Call move method for pictureboxes, update stats.
            p.move(proj);
            speedTxt.Text = "Speed: " + p.getSpeed() + " ms\u207b\xB9";
            timeTxt.Text = "Time elapsed: " + timeNum / 1000 + " s";
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

        private void testMode_Click(object sender, EventArgs e)
        {
            reset();
            simForms.testSetup(statsPanel, controlPanel, questionLabel, learnBox);
            if (test) { testMode.Text = "Test yourself"; } else { testMode.Text = "Return to simulation"; projQuestion(); } //Change text displayed on button to reflect mode change. Generates a question if switched to test mode.
            test = !test;

        }

        private void generateQuestion_Click(object sender, EventArgs e)
        {
            reset();
            projQuestion(); //Generates new question.
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            if (ans.ToString() == ansBox.Text){
                correctLabel.Text = "Correct. Well done!";
                uBox.Value = Convert.ToDecimal(speed);
                angleBox.Value = Convert.ToDecimal(angle);
                switchBtn.Show();
                switchBtn.PerformClick();
                switchBtn.Hide();

            }
            else
            {
                correctLabel.Text = "Incorrect. Try again.";
            }
        }
    }
}
