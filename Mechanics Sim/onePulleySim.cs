using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mechanics_Sim
{
    public partial class onePulleySim : Form
    {
        PictureBox pulley, pulleyOne, p1, p2, p3, table; //Initialise all pictureboxes to be used.
        bool useTable = false; //Used to check if simulation will use a pulley with a table, or just a standalone pulley.
        bool use2Pulley = false; //Used to check if simulation will use 2 pulleys with a table, or just a standalone pulley/ pulley with table.
        int tblH = 500; //Height of the table.
        int tblW = 1000; //Width of the table.
        bool start = false;
        double timeNum = 0;
        int startX; //Starting coordinates of pulley
        int startY;
        int gap = 300; //Initial length between pulley and mass.
        particle[] masses; //Array to store particles.
        public onePulleySim()
        {
            InitializeComponent();
            fricCoeffLabel.Hide();
            coeffBox.Hide();
            
            simForms.initiate(statsPanel, controlPanel, this); //Initialise UI elements.
            startX = this.Width * 7/8; ;
            startY = this.Height/2 ;
            //Appropriate pictureboxes are defined below.
            pulley = new PictureBox
            {
                Name = "pulley",
                Size = new Size(60, 60),
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = Properties.Resources.Ball,
            };

            pulleyOne = new PictureBox
            {
                Name = "pulley1",
                Size = new Size(60, 60),
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = Properties.Resources.Ball,
            };

            p1 = new PictureBox //3rd particle only used in configuration with 2 pulleys and 3 masses
            {
                Name = "p1",
                Size = new Size(40, 40),
                SizeMode = PictureBoxSizeMode.CenterImage,
                Image = Properties.Resources.Square,
            };

            p2 = new PictureBox
            {
                Name = "p2",
                Size = new Size(40, 40),
                SizeMode = PictureBoxSizeMode.CenterImage,
                Image = Properties.Resources.Square,
            };

            p3 = new PictureBox   
            {
                Name = "p3",
                Size = new Size(40, 40),
                SizeMode = PictureBoxSizeMode.CenterImage,
                Image = Properties.Resources.Square,
            };

            table = new PictureBox
            {
                Name = "table",
                Size = new Size(tblW, tblH),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = Properties.Resources.Square,
                Location = new Point(startX - tblW, startY + pulley.Height - 7),

            };
            Controls.Add(pulley); //Adds pictureboxes to forms.
            Controls.Add(pulleyOne);
            Controls.Add(p1);
            Controls.Add(p2);
            Controls.Add(p3);
            p1.Hide();
            table.Hide();
            pulleyOne.Hide();
            Controls.Add(table);
            reset();
        }

        public void reset()  //Resets displayed stats, picturebox locations, time and also stops timer.
        {
            pulley.Location = new Point(startX, startY);
            if (useTable)
            {
                //Makes table appear if user ticked the table check box.
                table.Show();
                table.SendToBack();
                fricCoeffLabel.Show();
                coeffBox.Show();
                //Adjustments to stop pictureboxes overlapping. More fine tuning needed.
                p2.BringToFront();
                p3.BringToFront();
                pulley.SendToBack();
                p2.Location = new Point(table.Left + tblW/2, startY + 14);
                p3.Location = new Point(table.Left + tblW + p2.Width, startY + gap);
                checkBoxPulley.Show();
                if (use2Pulley)
                {
                    pulleyOne.Location = new Point(startX - table.Width, startY);
                    pulleyOne.Show();
                    mass3Box.Show();
                    mass3Label.Show();
                    p1.Show();
                    p1.Location = new Point(table.Left - p1.Width, startY + gap);
                    tn2Txt.Show();
                }
                else
                {
                    pulleyOne.Hide();
                    mass3Box.Hide();
                    mass3Label.Hide();
                    p1.Hide();
                    tn2Txt.Hide();
                }
            }
            else
            {
                //Makes table, 2nd pulley and 2nd pulley checkbox hidden if check box is unticked.
                table.Hide();
                fricCoeffLabel.Hide();
                coeffBox.Hide();
                checkBoxPulley.Hide();
                p1.Hide();
                mass3Box.Hide();
                mass3Label.Hide();
                tn2Txt.Hide();
                p2.Location = new Point(startX - pulley.Width / 2 - 20, startY + gap);
                p3.Location = new Point(startX + pulley.Width / 2 + 20, startY + gap);
            }
            //Reset statistics.
            timeNum = 0;
            timeTxt.Text = "Time elapsed: ";
            tnTxt.Text = "Tension: ";
            tn2Txt.Text = "Tension 2: ";
            accTxt.Text = "Acceleration: ";
            speedTxt.Text = "Speed: ";
            start = false;
            pullTimer.Stop();

        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void checkBoxPulley_CheckedChanged(object sender, EventArgs e)
        {
            use2Pulley = checkBoxPulley.Checked; //Makes option to enter mass 3 (dis)appear, for 2 pulleys with table. 
            reset();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void onePulleySim_Paint(object sender, PaintEventArgs e)
        {
            //Adding string for pulley code goes here.
        }

        private void checkBoxTable_CheckedChanged(object sender, EventArgs e)
        {
            //Toggles between one pulley and table or one pulley without table.   
            useTable = checkBoxTable.Checked; //Makes option to enter friction coefficient (dis)appear, for pulley with table. 
            reset();
        }

        private void switchBtn_Click(object sender, EventArgs e)
        {
            if (!start)
            {
                //Following lines instantiate simulation and appropriately configure the particle.
                onePulley sim = new onePulley();
                //Passes mass inputs into pulleySetup function, returns array of 2 particles configured for table or without table.
                if (useTable)
                {
                    if (use2Pulley){masses = sim.pulleyTbl2Setup(Convert.ToDouble(mass1Box.Text), Convert.ToDouble(mass2Box.Text), Convert.ToDouble(mass3Box.Text), Convert.ToDouble(coeffBox.Text));}
                    else {masses = sim.pulleyTblSetup(Convert.ToDouble(mass1Box.Text), Convert.ToDouble(mass2Box.Text), Convert.ToDouble(coeffBox.Text));}
                }
                else
                {
                    masses = sim.pulleySetup(Convert.ToDouble(mass1Box.Text), Convert.ToDouble(mass2Box.Text));
                }
                start = true;
                // Following lines display relevant stats by calling the getters for the simulation.
                tnTxt.Text = "Tension: " + sim.getT1() + " N";
                tn2Txt.Text = "Tension 2: " + sim.getT2() + " N";
                accTxt.Text = "Acceleration: " + sim.getAcc() + " ms\u207b\xB2";
                pullTimer.Start();
            }
            else
            {
                if (pullTimer.Enabled) { pullTimer.Stop(); } else { pullTimer.Start(); } //Toggles the timer between starting and stopping to pause and play simulation.
            }
        }

        private void pullTimer_Tick(object sender, EventArgs e)
        {
            //Creates condition for which simulation must stop.
            bool condition;
            if (useTable)
            {
                if (use2Pulley)
                {
                    condition = p2.Left >= pulley.Left || p2.Left <= pulleyOne.Left || p1.Top < pulleyOne.Top + pulleyOne.Height || p3.Top < pulley.Top + pulley.Height;
                }
                else
                {
                    condition = (p2.Left >= pulley.Left || p3.Top >= table.Top + table.Height);
                }
            }
            else
            {
                condition = (p2.Top <= pulley.Top + pulley.Height || p3.Top <= pulley.Top + pulley.Height || p3.Top >= this.Height || p2.Top >= this.Height);
            }
            simForms.time(ref timeNum, ref start, condition, pullTimer);
            //Call move method for pictureboxes, update stats.
            
            if (use2Pulley) { masses[0].move(p1); masses[1].move(p2); masses[2].move(p3); }
            else
            {
                masses[0].move(p2);
                masses[1].move(p3);
            }
            speedTxt.Text = "Speed: " + masses[0].getSpeed().ToString() + " ms\u207b\xB9";
            timeTxt.Text = "Time Elapsed: " + timeNum / 1000 + " s";
        }
    }
}
