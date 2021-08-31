using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mechanics_Sim
{
    public partial class ProjectilesSim : Form
    {
        PictureBox proj;
        bool start = false;
        particle p; //Particle instantiation.
        double timeNum = 0;
        int startX;
        int startY;
        public ProjectilesSim()
        {
            InitializeComponent();
            controlPanel.Anchor = (AnchorStyles.Bottom); //Keeps controls at bottom of screen.
            statsPanel.Anchor = (AnchorStyles.Top| AnchorStyles.Right); //Keeps Stats panel at top right of screen.
            startX = 60;
            startY = this.Height - 40;
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

        public void reset()
        {
            proj.Location = new Point(startX, startY);
            timeNum = 0;
            timeTxt.Text = "Time elapsed: ";
            rangeTxt.Text = "Range: ";
            tofTxt.Text = "Time of flight: ";
            maxhTxt.Text = "Max height: ";
            accTxt.Text = "Acceleration: ";
            speedTxt.Text = "Speed: ";
            start = false;
            projTimer.Stop();

        }
        private void Switch_Click(object sender, EventArgs e)
        {
            if (!start)
            {
                proj.Anchor = (AnchorStyles.None); //Unlocks particle's position allowing it to be moved.
                //Following lines instantiate simulation and appropriately configure the particle.
                projectiles sim = new projectiles();
                p = sim.projectilesSetup(Convert.ToDouble(uBox.Text), Convert.ToDouble(angleBox.Text));
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

        private void projTimer_Tick(object sender, EventArgs e)
        {
            timeNum += projTimer.Interval;
            p.move(proj);
            speedTxt.Text = "Speed: " + p.getSpeed() + " ms\u207b\xB9";
            timeTxt.Text = "Time elapsed: " + timeNum / 1000 + " s";
            if(proj.Top > startY) //Projectile  should stop when it reaches its initial height.
            {
                projTimer.Stop();

            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
