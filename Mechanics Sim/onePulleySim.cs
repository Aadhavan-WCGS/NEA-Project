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
        PictureBox pulley, p1, p2, table;
        bool useTable = false;
        bool start = false;
        particle p;
        double timeNum = 0;
        int startX; //Starting coordinates of pulley
        int startY;
        int gap = 300; //Initial length between pulley and mass.
        particle[] masses; //Array to store 2 particles.
        public onePulleySim()
        {
            InitializeComponent();
            fricCoeffLabel.Hide();
            coeffBox.Hide();
            simForms.initiate(statsPanel, controlPanel, this); //Initialise ui elements.
            startX = this.Width / 2; ;
            startY = this.Height/2 ;
            //Appropriate pictureboxes are defined below.
            pulley = new PictureBox
            {
                Name = "pulley",
                Size = new Size(60, 60),
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = Properties.Resources.Ball,
            };

            p1 = new PictureBox
            {
                Name = "p1",
                Size = new Size(60, 60),
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = Properties.Resources.Square,
            };

            p2 = new PictureBox
            {
                Name = "p2",
                Size = new Size(60, 60),
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = Properties.Resources.Square,
            };

            table = new PictureBox
            {
                Name = "table",
                Size = new Size(200, 200),
                SizeMode = PictureBoxSizeMode.CenterImage,
                Image = Properties.Resources.Square,
                Location = new Point(startX - 180, startY + pulley.Width/2 + 20),

            };
            Controls.Add(pulley); //Adds pictureboxes to forms.
            Controls.Add(p1);
            Controls.Add(p2);
            table.Hide();
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
                table.BringToFront();
                p1.Location = new Point(table.Left, startY);
                p2.Location = new Point(table.Left + table.Width - 10, startY + 60);
            }
            else
            {
                //Makes table hidden if check box is unticked.
                table.Hide();
                p1.Location = new Point(startX - pulley.Width / 2 - 20, startY + gap);
                p2.Location = new Point(startX + pulley.Width / 2 + 20, startY + gap);
            }
            //Reset statistics.
            timeNum = 0;
            timeTxt.Text = "Time elapsed: ";
            tnTxt.Text = "Tension: ";
            accTxt.Text = "Acceleration: ";
            speedTxt.Text = "Speed: ";
            start = false;
            pullTimer.Stop();

        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
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
            //Toggles between one pulley and table or one pulley without table
            if(checkBoxTable.Checked == true)
            {
                useTable = true;
                fricCoeffLabel.Show();
                coeffBox.Show();
            }
            else
            {
                fricCoeffLabel.Hide();
                coeffBox.Hide();
                useTable = false;
            }
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
                    masses = sim.pulleyTblSetup(Convert.ToDouble(mass1Box.Text), Convert.ToDouble(mass2Box.Text), Convert.ToDouble(coeffBox.Text));
                }
                else
                {
                    masses = sim.pulleySetup(Convert.ToDouble(mass1Box.Text), Convert.ToDouble(mass2Box.Text));
                }
                start = true;
                // Following lines display relevant stats by calling the getters for the simulation.
                tnTxt.Text = "Tension: " + sim.getT() + " N";
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
                condition = (p1.Left >= pulley.Left || p2.Top >= table.Top + table.Width);
            }
            else
            {
                condition = (p1.Top <= pulley.Top + pulley.Height || p2.Top <= pulley.Top + pulley.Height || p2.Top >= this.Height || p1.Top >= this.Height);
            }
            simForms.time(ref timeNum, ref start, condition, pullTimer);
            //Call move method for pictureboxes, update stats.
            masses[0].move(p1); 
            masses[1].move(p2);
            speedTxt.Text = "Speed: " + masses[0].getSpeed().ToString() + " ms\u207b\xB9";
            timeTxt.Text = "Time Elapsed: " + timeNum / 1000 + " s";
        }
    }
}
