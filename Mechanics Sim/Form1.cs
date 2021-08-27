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
        private double maxSpeed = 20;
        private double c = 1;
        private double mass;
        private double forceX = 0;
        private double forceY = 0;
        private double velX = 0;
        private double velY = 0;
        private double displacementX = 0;
        private double displacementY = 0;
        private double speed = 0;
        public particle(double givenMass)
        {
            mass = givenMass;
        }

        public void move(PictureBox pic)
        {
    
            velX += ((forceX / mass) / 50);
            velY += ((forceY / mass) / 50);
            speed = Math.Sqrt(velY * velY + velX * velX);
            pic.Left += Convert.ToInt32(velX * c);
            pic.Top -= Convert.ToInt32(velY * c);
            displacementY += velY / c;
            displacementX += velX / c;
            if(speed >= maxSpeed)
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
