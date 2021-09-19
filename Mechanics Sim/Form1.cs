﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//SUPERSCRIPT CODES = \u207b\xB9 = ^-1, \u207b\xB2 = ^-2
namespace Mechanics_Sim
{
    public partial class Form1 : Form
    {
        //Basic form to open all simulations from.
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

        private void pullBtn_Click(object sender, EventArgs e)
        {
            onePulleySim f = new onePulleySim();
            f.Show();
        }

        private void pullTblBtn_Click(object sender, EventArgs e)
        {
            onePulleyTableSim f = new onePulleyTableSim();
            f.Show();
        }
    }
    public static class simForms
    {
        public static void initiate(Panel stats, Panel control, Form inp) //Simulation forms call this method to be in the correct window format.
        {
            stats.Anchor = (AnchorStyles.Top | AnchorStyles.Right); //Keeps Stats panel at top right of screen.
            control.Anchor = (AnchorStyles.Bottom); //Keeps controls at bottom of screen.
            inp.FormBorderStyle = FormBorderStyle.None; //Removes borders.
            inp.WindowState = FormWindowState.Maximized; //Puts window in fullscreen.
        }

        public static void time(ref double time, ref bool start, bool condition, Timer t) //Procedure to increment time, and stop timer if a condition is met. Used by all simulations.
        {
            time += t.Interval;
            if (condition)
            {
                t.Stop();
                start = false;
            }
        }
    }
    

    public class particle
    {
        private double maxSpeed = 100000; //Is this needed? OR can validation be used elsewhere to check max speed isn't reached.
        private double c = 1; //Used to scale values if needed.
        private double d = 50; // This value is equal to 1000/(Timer interval).
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
        private double acc;
        private double rf;

        //This method instantiates a particle, setting appropriate forces and mass and then returning the configured particle for this simulation.
        public particle forcesSetup(double m, double fx, double fy) 
        {
            particle p = new particle(m);
            p.setForce(fx, fy);
            rf = Math.Sqrt(fx * fx + fy * fy);
            acc = rf / m;
            return p;
        }

        public double getRf() //Returns resultant force of particle.
        {
            return rf;
        }

        public double getAcc() // Returns acc of particle.
        {
            return acc;
        }
    }


    public class onePulley // Class for the pulley simulation.
    {
        private double acc; //Acceleration
        private double t; //Tension
        private double g = 9.81; 

        //This method instantiates a particle, setting appropriate forces and mass and then returning the configured particle for this simulation.
        public particle[] pulleySetup(double m1, double m2)
        {
            t = (2 * m1 * m2 * g) / (m1 + m2);
            particle p1 = new particle(m1);
            particle p2 = new particle(m2);
            p1.setForce(0, t - g * m1);
            p2.setForce(0, t - g * m2);
            acc = (g * (m2 - m1)) / (m1 + m2);
            particle[] px = {p1, p2}; //Creates array for 2 particles then returns it.
            return px;
        }

        public particle[] pulleyTblSetup(double m1, double m2, double mu)
        {
            t = ((m1 * m2 * 9.81) * (1 + mu)) / (m1 + m2);
            particle p1 = new particle(m1);
            particle p2 = new particle(m2);
            p1.setForce(t - mu * m1 * g, 0);
            p2.setForce(0, t - g * m2);
            acc = (g * (m2 - mu * m1)) / (m1 + m2);
            particle[] px = { p1, p2 }; //Creates array for 2 particles then returns it.
            return px;
        }
        public double getT() //Returns resultant force of particle.
        {
            return t;
        }

        public double getAcc() // Returns acc of particle.
        {
            return acc;
        }
    }

    public class projectiles
    {
        private double range;
        private double maxH;
        private double tof;
        private double g = 9.81;
        //This method instantiates a particle, setting appropriate forces and mass and then returning the configured particle for this simulation.
        public particle projectilesSetup(double u, double theta)
        {
            double rad = theta * Math.PI / 180; //Convert input angle from degrees to radians. Mechanics uses degrees only but c sharp works in radians.
            particle p = new particle(1);
            p.setForce(0, -g);
            p.setVel(u * Math.Cos(rad), u * Math.Sin(rad));
            range = (u * u * Math.Sin(2 * rad)) / g;
            maxH = (u * u * Math.Sin(rad) * Math.Sin(rad)) / (g * 2);
            tof = (2 * u * Math.Sin(rad)) / g;
            return p;
        }

        public double getRange() // Returns range of projectile.
        {
            return Math.Round(range, 2);
        }

        public double getMaxH() // Returns max height of projectile.
        {
            return Math.Round(maxH, 2);
        }

        public double getTof() //Returns time of flight of projectile.
        {
            return Math.Round(tof, 2);
        }

    }

}
