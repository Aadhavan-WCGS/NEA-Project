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
        double forceX;
        double forceY;
        double mass;
        double timeNum = 0;
        public ForcesSim()
        {
            InitializeComponent();
            reset();
        }

        public void reset()
        {
            ball.Left = this.Width / 2;
            ball.Top = this.Height / 2;
        }
    


        private void Switch_Click(object sender, EventArgs e)
        {
            if (!start)
            {
                sim x = new sim();
                mass = Convert.ToDouble(massBox.Text);
                forceX = Convert.ToDouble(xfBox.Text);
                forceY = Convert.ToDouble(yfBox.Text);
                p = x.forces(mass, forceX, forceY);
                start = true;
                double resForce = Math.Sqrt(forceX * forceX + forceY * forceY);
                rfBox.Text = "Resultant Force: " + resForce + "N";
                accBox.Text = "Acceleration: " + resForce / mass;
                forceTimer.Start();
            }
            else
            {
                if (forceTimer.Enabled) { forceTimer.Stop(); } else { forceTimer.Start(); }
            }
            
            
        }

        private void forceTimer_Tick(object sender, EventArgs e)
        {
            p.move(ball);
            speedBox.Text = "Speed: " + p.getSpeed().ToString() + "m/s";
            
            time.Text = "Time Elapsed: " + timeNum/1000 + " seconds";
        }

        private void mass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
