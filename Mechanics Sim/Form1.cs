using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mechanics_Sim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ForcesSim f = new ForcesSim();
            f.Show();
        }
    }

    public class particle
    {
        private double maxSpeed = 100;
        private double c = 1;
        private double mass;
        private double forceX;
        private double forceY;
        private double velX;
        private double velY;
        private double displacementX;
        private double displacementY;
        private double speed;
        public particle(double givenMass)
        {
            mass = givenMass;
            displacementX = 0;
            displacementY = 0;
        }

        public void move(PictureBox pic)
        {
    
            velX += (forceX / mass) / 1000;
            velY += (forceY / mass) / 1000;
            speed = Math.Sqrt(velY * velY + velX * velX);
            pic.Left += Convert.ToInt32(velX * c);
            pic.Top -= Convert.ToInt32(velY * c);
            displacementY += velY / c;
            displacementX += velX / c;
            if(speed == maxSpeed)
            {
                forceX = 0;
                forceY = 0;
            }
        }

        public void setForce(double newX, double newY)
        {
            forceX = newX;
            forceY = newY;
        }
        public void setVel(double newSX, double newSY)
        {
            velX = newSX;
            velY = newSY;
        }

        public double getVelX()
        {
            return velX;
        }

        public double getVelY()
        {
            return velY;
        }

        public double getSpeed()
        {
            return speed;
        }
        public void setPos(double x, double y)
        {
            displacementX = x;
            displacementY = y;
        }

        public double disX()
        {
            return displacementX;
        }

        public double disY()
        {
            return displacementY;
        }
    }

    public class sim
    {
        public particle forces(double m, double fx, double fy)
        {
            particle p = new particle(m);
            p.setForce(fx, fy);
            return p;
        }
    }

    
}
