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
        bool start = false;
        particle p;
        double timeNum = 0;
        public ForcesSim()
        {
            InitializeComponent();
            statsPanel.Anchor = (AnchorStyles.Top | AnchorStyles.Right); //Keeps Stats panel at top right of screen.
            controlPanel.Anchor = (AnchorStyles.Bottom); //Keeps controls at bottom of screen.
            reset();
        }

        public void reset()
        {
            ball.Left = this.Width / 2;
            ball.Top = this.Height / 2;
            timeNum = 0;
            timeTxt.Text = "Time elapsed: ";
            rfTxt.Text = "Resultant Force: ";
            accTxt.Text = "Acceleration: ";
            speedTxt.Text = "Speed: ";
            start = false;
            forceTimer.Stop();

        }
    
        private void Switch_Click(object sender, EventArgs e)
        {
            if (!start)
            {
                forces sim = new forces();
                p = sim.forcesSetup(Convert.ToDouble(massBox.Text), Convert.ToDouble(xfBox.Text), Convert.ToDouble(yfBox.Text));
                start = true;
                rfTxt.Text = "Resultant Force: " + sim.getrF() + " N";
                accTxt.Text = "Acceleration: " + sim.getAcc() + " ms\u207b\xB2";
                forceTimer.Start();
            }
            else
            {
                if (forceTimer.Enabled) { forceTimer.Stop(); } else { forceTimer.Start(); }
            }
            
            
        }

        private void forceTimer_Tick(object sender, EventArgs e)
        {
            timeNum += forceTimer.Interval;
            p.move(ball);
            speedTxt.Text = "Speed: " + p.getSpeed().ToString() + " ms\u207b\xB9"; 
            timeTxt.Text = "Time Elapsed: " + timeNum/1000 + " s";
        }


        private void resetBtn_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
