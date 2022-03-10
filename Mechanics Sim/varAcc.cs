using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mechanics_Sim
{
    public partial class varAccSim : Form
    {
        //Declaring variables with scope of the simulation form.
        PictureBox ball; //Initialise all pictureboxes to be used.
        bool oneD = true;
        bool saved = false;
        bool start = false;
        bool test = false;
        double ans;
        particle p; //Particle instantiation.
        double timeNum = 0; //Variable to store time elapsed, set to zero initially.
        int startX, startY; //Starting coordinates of particle.
        double[] disEqn, disEqnY, accEqn, velEqn, accEqnY, velEqnY;  //Global variables to store equations.
        varAcc sim = new varAcc();
        public varAccSim()
        {
            InitializeComponent();
            simForms.initiate(statsPanel, controlPanel, this); //Initialise ui elements.
            startX = this.Width/2;
            startY = this.Height/2;
            //Appropriate pictureboxes are defined below.
            ball = new PictureBox
            {
                Name = "Ball",
                Size = new Size(60, 60),
                Location = new Point(startX, startY),
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = Properties.Resources.Ball,
            };
            Controls.Add(ball);
            reset();
        }

        public static string format(string eqn){
            String newstr = ""; //String to hold formatted equation.
            string[] result = eqn.Split(' '); //Splits sections of string into list.
            foreach (string x in result){ //Loops through each list item.
                if (!(x.Contains("+0"))){ //Any terms with a zero can be omitted from the equation. ALSO FIX THIS AND EXPLAIN ERROR- EG IF COEFFICIENT IS 30 THEN ERROR FOUND.
                    if (x.Contains("+-")){ //Changes +- to just - (slightly different if coefficient is -1)
                        if (x.Contains("+-1t")){ //Checks for unnecessary 1s with a +-.
                            newstr += "-" + x.Substring(3, x.Length - 3); //Adds minus sign followed by t and its power.
                        }else{
                            newstr += "-" + x.Substring(2, x.Length - 2); //Adds minus sign followed by coefficient, t and its power.
                        }
                    }else{
                        if (x.Contains("+1t")){ //Checks for unnecessary 1s with a +.{ //Check if coefficient is 1 and not constant term.
                            newstr += "+" + x.Substring(2, x.Length - 2); //Omits 1 in string.
                        }else{
                            newstr += x; //Adds term without modification as already in right format.
                        }
                    }
                }
            }
            if (newstr[0] == '0'){ //Removes unnecessary '0' at start.
                newstr = newstr.Substring(1, newstr.Length - 1);
            }
            if (newstr[0] == '+'){ //Removes unnecessary '+' at start.
                newstr = newstr.Substring(1, newstr.Length - 1);
            }
            return newstr;
        }

        public void varAccQuestion() //Question generation procedure.
        {
            Random rnd = new Random(); //Initialise random variable.
            int choice = rnd.Next(1, 3); //Used to decide what question to give.
            double[] generatedCoeffsX = { rnd.Next(-5, 5), rnd.Next(-5, 5), rnd.Next(-5, 5), rnd.Next(-5, 5) };  //Randomly generates expression for displacement equation.
            disEqn = generatedCoeffsX;
            int time = rnd.Next(2, 10); //Random value for time.
            varAcc sim = new varAcc(); //Instantiate simulation to compute answers.
            sim.varAccSetup(disEqn); 
            velEqn = sim.getVel(); accEqn = sim.getAcc(); //Retrieving equations to find the answer.
            string info = "A particle's displacement from the origin is given by: \n x = " + format(disEqn[0].ToString() + " +" + disEqn[1].ToString() + "t +" + disEqn[2].ToString() + "t\xB2 +" + disEqn[3].ToString() + "t\xB3"); ;  //String containing question and relevant background information, along with formatted equation.
            if (!oneD){
                double[] generatedCoeffsY = { rnd.Next(-5, 5), rnd.Next(-5, 5), rnd.Next(-5, 5), rnd.Next(-5, 5) }; //Randomly generates expression for vertical displacement equation.
                disEqn = generatedCoeffsX; disEqnY = generatedCoeffsY;
                sim.varAccSetupY(disEqnY); //Passes y component displacement into setup method.
                velEqnY = sim.getVelY(); accEqnY = sim.getAccY(); //Retrieving equations to find the answer.
                info += "\n y = " + format(disEqnY[0].ToString() + " +" + disEqnY[1].ToString() + "t +" + disEqnY[2].ToString() + "t\xB2 +" + disEqnY[3].ToString() + "t\xB3");  //String containing question and relevant background information.; //Start of question 
            }
            switch (choice){ //Adds a different question to the string depending on the number generated.
                case 1:   
                    info += "\n What is the speed at " + time.ToString() + " seconds?";
                    if (oneD){ //1D case
                        ans = Math.Abs(sim.sub(velEqn, time));  //Substitute time into equation to find answer.
                    }else{ //2D case
                        double compX = sim.sub(velEqn, time); double compY = sim.sub(velEqnY, time);
                        ans = Math.Sqrt(compX * compX + compY * compY);
                    }
                    ansUnitsLabel.Text = "ms\u207b\xB9";  //Output units next to answer box.
                    break;
                case 2:
                    info += "\n What is the magnitude of acceleration at " + time.ToString() + " seconds?";
                    if (oneD){ //1D case
                        ans = Math.Abs(sim.sub(accEqn, time)); //Substitute time into equation to find answer.
                    }else{ //2D case
                        double compX = sim.sub(accEqn, time); double compY = sim.sub(accEqnY, time);
                        ans = Math.Sqrt(compX * compX + compY * compY);
                    }
                    ansUnitsLabel.Text = "ms\u207b\xB2"; //Output units next to answer box.
                    break;
            }
            info += " (give answer to 2 decimal places)";
            questionLabel.Text = info;
        }

        public void reset() //Resets displayed stats, picturebox locations, time and also stops timer.
        {
            saved = false;
            foreach (Control x in controlPanel.Controls){
                if (x is NumericUpDown){ //Checks if control is NumericUpDown
                    NumericUpDown y = x as NumericUpDown;
                    y.Text = y.Value.ToString();  //Sets value to defaut/value before change.
                }
            }
            correctLabel.Text = "";  //Initialise question feedback label to blank.
            ball.Location = new Point(startX, startY); //Set particle picturebox to initial position.
            timeNum = 0; //Reset time elapsed to zero,
            //Below code resets text in relevant labels for simulation.
            timeTxt.Text = "Time elapsed: ";
            accTxt.Text = "Acceleration: ";
            speedTxt.Text = "Speed: ";
            dispTxt.Text = "Displacement: ";
            accEqnTxt.Text = "Acceleration equation X: ";
            velEqnTxt.Text = "Velocity equation X: ";
            accEqnYTxt.Text = "Acceleration equation Y: ";
            velEqnYTxt.Text = "Velocity equation Y: ";
            start = false;
            varAccTimer.Stop();

        }



        private void learnBox_CheckedChanged(object sender, EventArgs e) //Learn more checkbox procedure.
        {
            assumptions.Visible = !assumptions.Visible; //Toggle assumptions label visibility.
        }

        private void testMode_Click(object sender, EventArgs e) //Test Yourself button procedure.
        {
            reset();
            simForms.testSetup(statsPanel, controlPanel, coverPanel, learnBox, questionLabel);
            if (test) { testMode.Text = "Test yourself"; } else { testMode.Text = "Return to simulation"; varAccQuestion(); } //Change text displayed on button to reflect mode change. Generates a question if switched to test mode.
            test = !test;
            dimensionSwitch.Enabled = !dimensionSwitch.Enabled; //Locks dimension switch in test mode.
        }

        private void checkBtn_Click(object sender, EventArgs e){ //Check Answer button procedure.
            reset();
            if (oneD){
                NumericUpDown[] boxes = { x0Box, x1Box, x2Box, x3Box };
                simForms.check(boxes, disEqn, ans, ansBox.Text, switchBtn, correctLabel); //Calls routine to check answer and run animation if correct.
            }
            else{
                NumericUpDown[] boxes = {x0Box, x1Box, x2Box, x3Box, y0Box, y1Box, y2Box, y3Box}; //Array of input boxes.
                double[] combinedEqn = new double[8];
                Array.Copy(disEqn, combinedEqn, 4); // Copies X component coefficients into first 4 indexed of new array.
                Array.Copy(disEqnY, 0, combinedEqn, 4, 4); //Copies Y component coefficients into new array starting from 4th index.
                simForms.check(boxes, combinedEqn, ans, ansBox.Text, switchBtn, correctLabel); //Calls routine to check answer and run animation if correct.
            }
        }

        private void generateQuestion_Click(object sender, EventArgs e) //Next question button procedure.
        {
            reset();
            varAccQuestion(); //Generates new question.
        }

        private void resetBtn_Click(object sender, EventArgs e) //Reset button procedure.
        { 
            reset(); //Call reset routine on button click.
        }

        private void saveBtn_Click(object sender, EventArgs e) //Save question button procedure.
        {
            simForms.questionSave(questionLabel.Text, ans, ansUnitsLabel.Text, ref saved); //Calls questionSave method to save question locally.
        }

        private void exitBtn_Click(object sender, EventArgs e) //Exit button procedure.
        {
            this.Close(); //Close window when exit button clicked.
        }

        private void switchBtn_Click(object sender, EventArgs e) //Switch button procedure.
        {
            if (!start)
            {
                reset();
                //Following lines instantiate simulation and appropriately configure the particle.
                double[] coefficients = {Convert.ToDouble(x0Box.Text), Convert.ToDouble(x1Box.Text), Convert.ToDouble(x2Box.Text), Convert.ToDouble(x3Box.Text)};
                disEqn = coefficients;
                p = sim.varAccSetup(disEqn); //Calls routine to setup simulation, returning a configured particle.
                if (!oneD) //If simulation is in 2D mode.
                {
                    double[] coefficientsY = { Convert.ToDouble(y0Box.Text), Convert.ToDouble(y1Box.Text), Convert.ToDouble(y2Box.Text), Convert.ToDouble(y3Box.Text) }; //Retieves coefficients of y component displacement and stores in an array.
                    sim.varAccSetupY(coefficientsY); //Calls method to setup y component motion, by passing in the above array.
                    //Retrieves equations needed for y component motion.
                    disEqnY = coefficientsY;
                    velEqnY = sim.getVelY();
                    accEqnY = sim.getAccY();
                    velEqnYTxt.Text = "Velocity equation Y: " + format(velEqnY[0].ToString() + " +" + velEqnY[1].ToString() + "t +" + velEqnY[2].ToString() + "t\xB2 +" + velEqnY[3].ToString() + "t\xB3");
                    accEqnYTxt.Text = "Acceleration equation Y: " + format(accEqnY[0].ToString() + " +" + accEqnY[1].ToString() + "t +" + accEqnY[2].ToString() + "t\xB2 +" + accEqnY[3].ToString() + "t\xB3");
                }
                start = true;
                //Retrieves equations needed for x component motion.
                velEqn = sim.getVel();
                accEqn = sim.getAcc();
                // Following lines display relevant stats.
                velEqnTxt.Text = "Velocity equation X: " + format(velEqn[0].ToString() + " +" + velEqn[1].ToString() + "t +" + velEqn[2].ToString() + "t\xB2 +" + velEqn[3].ToString() + "t\xB3");
                timeTxt.Text = "Time elapsed: ";
                accTxt.Text = "Acceleration : ";
                speedTxt.Text = "Speed: ";
                dispTxt.Text = "Displacement: ";
                accEqnTxt.Text = "Acceleration equation X: " + format(accEqn[0].ToString() + " +" + accEqn[1].ToString() + "t +" + accEqn[2].ToString() + "t\xB2 +" + accEqn[3].ToString() + "t\xB3");        
                varAccTimer.Start(); //Starts timer to begin simulation animation.
                if (oneD) { p.setVel(velEqn[0], 0); } else { p.setVel(velEqn[0], velEqnY[0]);} //Sets initial velocity.      
            }
            else
            {
                if (varAccTimer.Enabled) { varAccTimer.Stop(); } else { varAccTimer.Start(); } //Allows button to behave as a toggle, to start or stop simulation.
            }
        }

        private void varAccTimer_Tick(object sender, EventArgs e) //Timer function, responible for animation.
        {
            simForms.time(ref timeNum, ref start, false, varAccTimer);
            //Finds current value of acceleration, velocity, displacement.
            double acc = sim.sub(accEqn, timeNum / 1000);
            double vel = sim.sub(velEqn, (timeNum / 1000));
            double dis = sim.sub(disEqn, (timeNum / 1000));
            if (!oneD) //Initialises y component of motion if the 2D case is enabled.
            {
                double accY = sim.sub(accEqnY, timeNum / 1000);
                double velY = sim.sub(velEqnY, (timeNum / 1000));
                double disY = sim.sub(disEqnY, (timeNum / 1000));
                p.setForce(acc, accY);
                speedTxt.Text = "Speed: " + Math.Round(Math.Sqrt(vel * vel + velY * velY), 2) + " ms\u207b\xB9"; // Finds magnitude of speed
                accTxt.Text = "Acceleration: " + Math.Round(Math.Sqrt(acc * acc + accY * accY), 2) + "ms\u207b\xB2";// Finds magnitude of acceleration
                dispTxt.Text = "Displacement: " + Math.Round(Math.Sqrt(dis * dis + disY * disY), 2) + "m";// Finds magnitude of acceleration

            }
            else
            {
                p.setForce(acc, 0); //Sets force as acceleration, as mass = 1kg.
                //Updates statistics.
                speedTxt.Text = "Speed: " + Math.Round(vel, 2) + " ms\u207b\xB9";
                accTxt.Text = "Acceleration: " + Math.Round(acc, 2) + "ms\u207b\xB2";
                dispTxt.Text = "Displacement: " + Math.Round(dis, 2) + "m";
            }
            p.move(ball); //Calls move method to animate picturebox.
            timeTxt.Text = "Time elapsed: " + timeNum / 1000 + "s"; //Update  displayed time.
        }

        private void varAccSim_Load(object sender, EventArgs e)
        {

        }

        private void dimensionSwitch_Click(object sender, EventArgs e) //Button to toggle between 1D and 2D.
        {
            oneD = !oneD; //Flips boolean used to check if 1D is used.
            velEqnYTxt.Visible = !velEqnYTxt.Visible;
            accEqnYTxt.Visible = !accEqnYTxt.Visible;
            toggle();
            if (dimensionSwitch.Text == "1D"){dimensionSwitch.Text = "2D";}else{dimensionSwitch.Text = "1D";}   //Changes text in dimension switch button to show what mode program is in.
            reset();
        }


        private void toggle() //Routine to toggle elements for 2D motion.
        {
            string ybox = "y0Box"; //Creates string used to identify NumericUpDown controls.
            string ylabels = "t0LabelY"; //Creates string used to identify label controls.
            //Below loop is used to toggle visibility all the required labels using their name.
            for (int i = 0; i < 4; i++)
            {
                Control boxy = controlPanel.Controls[ybox];
                Control labely = controlPanel.Controls[ylabels];
                boxy.Visible = !boxy.Visible; //Makes invisible controls visible and vice versa.
                labely.Visible = !labely.Visible;
                ybox = "y" + (i + 1) + "Box";
                ylabels = "t" + (i + 1) + "LabelY";
            }
            bracketL.Visible = !bracketL.Visible; bracketR.Visible = !bracketR.Visible;  //Toggles visibility of the large pair of brackets (used in 2D only).
        }
    }
}
