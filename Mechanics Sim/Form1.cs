using System;
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
            LearnCheckBox f = new LearnCheckBox();
            f.Show();
        }

        private void pullBtn_Click(object sender, EventArgs e)
        {
            onePulleySim f = new onePulleySim();
            f.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            varAccSim f = new varAccSim();
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

        public static void testSetup(Panel stats, Panel control, Label question, CheckBox learn)
        {
            learn.Checked = false; //Ensures learning text does not display.
            foreach (Control x in control.Controls)
            {
                if (x.Name != "testMode" & x.Name != "exitBtn" & x.Name != "Ball") //Toggles visibility of elements.
                {
                    x.Visible = !x.Visible;
                }
            }
            stats.Visible = !stats.Visible; //Toggles visibility of stats panel, as this is not needed in test mode. Is visible by default.
            question.Visible = !question.Visible; //Toggles visibility of label containing questions, for test mode. Is invisible by default.  
        }

        public static void check(NumericUpDown[] boxes, double[] data, double correctAns, string userAns, Button switchBtn, Label feedback)
        {
            if (correctAns.ToString() == userAns)
            {
                feedback.Text = "Correct. Well done!"; //Outputs appropriate message if user is correct.
                for (int i = 0; i < boxes.Length; i++)
                {
                    boxes[i].Value = Convert.ToDecimal(data[i]); //Loops through each NumericUpDownBox, setting it to the required input before starting the animation.
                }
                switchBtn.Show(); 
                switchBtn.PerformClick(); //Starts the simulatino by clicking the button.
                switchBtn.Hide();
            }
            else
            {
                feedback.Text = "Incorrect. Try again."; //Outputs appropriate message if user is incorrect.
            }
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
        //Attributes
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
            speed = Math.Sqrt(velY * velY + velX * velX); //Gets speed by using pythagoras theorem on velocity components.
            pic.Left += Convert.ToInt32(velX * c);
            pic.Top -= Convert.ToInt32(velY * c);
            displacementY += velY / d;
            displacementX += velX / d;
        }

        //Setters
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

        //Getters
        public double getVelX()
        {
            return Math.Round(velX, 2);
        }

        public double getFx()
        {
            return Math.Round(forceX, 2);
        }

        public double getFy()
        {
            return Math.Round(forceY, 2);

        }
        public double getVelY()
        {
            return Math.Round(velY, 2);
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

        public double getDisX()
        {
            return Math.Round(displacementX, 2);
        }

        public double getDisY()
        {
            return Math.Round(displacementY, 2);
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
            return Math.Round(rf, 2);
        }

        public double getAcc() // Returns acc of particle.
        {
            return Math.Round(acc, 2);
        }
    }


    public class onePulley // Class for the pulley simulation.
    {
        private double acc; //Acceleration
        private double t1, t2; //Tension
        private double g = 9.8; 

        //This method instantiates a particle, setting appropriate forces and mass and then returning the configured particle for this simulation.
        public particle[] pulleySetup(double m1, double m2)
        {
            t1 = (2 * m1 * m2 * g) / (m1 + m2); //Finds tension.
            particle p1 = new particle(m1);
            particle p2 = new particle(m2);
            p1.setForce(0, t1 - g * m1);
            p2.setForce(0, t1 - g * m2);
            acc = (g * (m2 - m1)) / (m1 + m2);
            particle[] px = {p1, p2}; //Creates array for 2 particles then returns it.
            return px;
        }

        public particle[] pulleyTblSetup(double m1, double m2, double mu)
        {
            t1 = ((m1 * m2 * g) * (1 + mu)) / (m1 + m2); //Finds tension.
            particle p1 = new particle(m1);
            particle p2 = new particle(m2);
            p1.setForce(t1 - mu * m1 * g, 0);
            p2.setForce(0, t1 - g * m2);
            acc = (g * (m2 - mu * m1)) / (m1 + m2);
            if (mu * m1 >= m2) { acc = 0;p1.setForce(0, 0);p2.setForce(0, 0); t1 = m2 * g; } //Check for friction exceeding weight of second mass.
            particle[] px = { p1, p2 }; //Creates array for 2 particles then returns it.
            return px;
        }

        public particle[] pulleyTbl2Setup(double m1, double m2, double m3, double mu)
        {
            t1 = ((m1 *g) * (2 * m3 + m2 - mu * m2)) / (m1 + m2 + m3); //Finds tension 1 (in first string on left).
            t2 = ((m3 * g) * (2 * m1 + m2 + mu * m2)) / (m1 + m2 + m3);//Finds tension 2 (in second string on right).
            particle p1 = new particle(m1);
            particle p2 = new particle(m2);
            particle p3 = new particle(m3);
            p1.setForce(0, t1 - m1 * g);
            p2.setForce(t2 - t1 - mu * m2 * g,0);
            p3.setForce(0, t2 - g * m3);
            acc = (g * (m3 - m1 - mu * m2)) / (m1 + m2 + m3);       
            particle[] px = {p1, p2, p3}; //Creates array for 3 particles then returns it.
            return px;
        }
        public double getT1() //Returns resultant force of particle.
        {
            return Math.Round(t1, 2); 
        }

        public double getT2() //Returns resultant force of particle.
        {
            return Math.Round(t2, 2);
        }

        public double getAcc() // Returns acc of particle.
        {
            return Math.Round(Math.Abs(acc), 2);
        }
    }

    public class projectiles
    {
        private double range;
        private double maxH;
        private double tof;
        private double g = 9.8;
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

    public class varAcc
    {
        private double[] dis, disY, vel, velY, acc, accY;
        public particle varAccSetup(double[] disp)
        {
            acc = derivative(derivative((double[])disp.Clone()));
            vel = derivative((double[])disp.Clone());
            dis = (double[])disp.Clone();
            particle p = new particle(1);
            return p;
        }

        public void varAccSetupY(double[] dispY)
        {
            accY = derivative(derivative((double[])dispY.Clone()));
            velY = derivative((double[])dispY.Clone());
            disY = (double[])dispY.Clone();
        }

        public double[] derivative(double[] coeff) // Computes derivative of a polynomial within the form of an array.
        {
            for(int x = 0; x < coeff.Length - 1; x++)
            {
                coeff[x] = coeff[x + 1] * (x+1);
            }
            coeff[coeff.Length - 1] = 0;
            return coeff;
        }

        public double sub(double[] eqn, double x) // Returns output of a value inputted into polynomial.
        {
            double y = 0;
            for (int i = 0; i < eqn.Length; i++){
                y += eqn[i] * (Math.Pow(x, i));
            }
            return y;
        }

        public double[] getVel()
        {
            return vel;
        }

        public double[] getAcc()
        {
            return acc;
        }

        public double[] getDis()
        {
            return dis;
        }

        public double[] getVelY()
        {
            return velY;
        }

        public double[] getAccY()
        {
            return accY;
        }

        public double[] getDisY()
        {
            return disY;
        }

    }
}
