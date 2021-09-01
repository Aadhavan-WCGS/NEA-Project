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
        PictureBox pulley, p1, p2;
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
            simForms.initiate(statsPanel, controlPanel, this);
            startX = this.Width / 2; ;
            startY = 100;

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
            Controls.Add(pulley);
            Controls.Add(p1);
            Controls.Add(p2);
            reset();
        }

        public void reset()
        {
            pulley.Location = new Point(startX, startY);
            p1.Location = new Point(startX - pulley.Width / 2 - 20, startY + gap);
            p2.Location = new Point(startX + pulley.Width / 2 + 20, startY + gap);
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

        }

        private void switchBtn_Click(object sender, EventArgs e)
        {
            if (!start)
            {
                onePulley sim = new onePulley();
                masses = sim.pulleySetup(Convert.ToDouble(mass1Box.Text), Convert.ToDouble(mass2Box.Text));
                start = true;
                tnTxt.Text = "Tension: " + sim.getT() + " N";
                accTxt.Text = "Acceleration: " + sim.getAcc() + " ms\u207b\xB2";
                pullTimer.Start();
            }
            else
            {
                if (pullTimer.Enabled) { pullTimer.Stop(); } else { pullTimer.Start(); }
            }
        }

        private void pullTimer_Tick(object sender, EventArgs e)
        {
            timeNum += pullTimer.Interval;
            masses[0].move(p1);
            masses[1].move(p2);
            speedTxt.Text = "Speed: " + masses[0].getSpeed().ToString() + " ms\u207b\xB9";
            timeTxt.Text = "Time Elapsed: " + timeNum / 1000 + " s";
            if(p1.Top <= pulley.Top + pulley.Height || p2.Top <= pulley.Top + pulley.Height || p2.Top >= this.Height || p1.Top >= this.Height)
            {
                pullTimer.Stop();
                start = false;
            }
        }
    }
}
