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

        private void prButton_Click(object sender, EventArgs e)
        {
            ProjectilesSim f = new ProjectilesSim();
            f.Show();
        }
    }

    public class particle
    {
        private double maxSpeed = 100000;
        private double c = 1;
        private double d = 50;
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

        public void move(PictureBox pic) // Applies motion to a picturebox passed into the procedure.
        {
    
            velX += ((forceX / mass) / d);
            velY += ((forceY / mass) / d);
            speed = Math.Sqrt(velY * velY + velX * velX);
            pic.Left += Convert.ToInt32(velX * c);
            pic.Top -= Convert.ToInt32(velY * c);
            displacementY += velY / d;
            displacementX += velX / d;
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
            return Math.Round(speed, 2);
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

    public class forces // Class for the forces simulation.
    {
        private double acceleration;
        private double rF;

        //This method instantiates a particle, setting appropriate forces and mass and then returning the configured particle for this simulation.
        public particle forcesSetup(double m, double fx, double fy) 
        {
            particle p = new particle(m);
            p.setForce(fx, fy);
            rF = Math.Sqrt(fx * fx + fy * fy);
            acceleration = rF / m;
            return p;
        }

        public double getrF() //Returns resultant force of particle.
        {
            return rF;
        }

        public double getAcc() // Returns acceleration of particle.
        {
            return acceleration;
        }
    }

    public class projectiles
    {
        public double range;
        public double maxH;
        public double tof;

        //This method instantiates a particle, setting appropriate forces and mass and then returning the configured particle for this simulation.
        public particle projectilesSetup(double u, double theta)
        {
            double rad = theta * Math.PI / 180; //Convert input angle from degrees to radians. Mechanics uses degrees only but c sharp works in radians.
            double g = 9.81;
            particle p = new particle(1);
            p.setForce(0, -g);
            p.setVel(u * Math.Cos(rad), u * Math.Sin(rad));
            range = (u * u * Math.Sin(2 * rad)) / g;
            maxH = (u * u * Math.Sin(rad) * Math.Sin(rad)) / (g * 2);
            tof = (2 * u * Math.Sin(rad)) / g;
            return p;
        }


        //Getters to return approprate stats for the projectile.
        public double getRange()
        {
            return Math.Round(range, 2);
        }

        public double getMaxH()
        {
            return Math.Round(maxH, 2);
        }

        public double getTof()
        {
            return Math.Round(tof, 2);
        }

    }

}
