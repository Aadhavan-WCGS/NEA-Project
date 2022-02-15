using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Mechanics_Sim
{
    public partial class onePulleySim : Form
    {
        //Declaring variables with scope of the simulation form.
        PictureBox pulley, pulleyOne, p1, p2, p3, table; //Initialise all pictureboxes to be used.
        bool useTable = false; //Used to check if simulation will use a pulley with a table, or just a standalone pulley.
        bool use2Pulley = false; //Used to check if simulation will use 2 pulleys with a table, or just a standalone pulley/ pulley with table.
        int tblH = 500; int tblW = 1000; //Height and width of the table.
        bool test = false;
        bool start = false;
        bool saved = false;
        double m1, m2, m3, mu; //Variables for test mode.
        double ans = 0;
        double timeNum = 0; //Variable to store time elapsed, set to zero initially.
        int startX; int startY; //Starting coordinates of pulley
        int gap = 300; //Initial length between pulley and mass.
        particle[] masses; //Array to store particles.
        public onePulleySim(){
            InitializeComponent();
            fricCoeffLabel.Hide();coeffBox.Hide(); //Initially hidden.
            simForms.initiate(statsPanel, controlPanel, this); //Initialise UI elements.
            startX = this.Width * 7/8; ; startY = this.Height/2 ;
            //Appropriate pictureboxes are defined below.
            pulley = new PictureBox{Name = "pulley",Size = new Size(80, 80),SizeMode = PictureBoxSizeMode.Zoom,Image = Properties.Resources.Ball,};
            pulleyOne = new PictureBox{Name = "pulley1",Size = new Size(80, 80),SizeMode = PictureBoxSizeMode.Zoom,Image = Properties.Resources.Ball,};
            p1 = new PictureBox{ Name = "p1", Size = new Size(40, 40), SizeMode = PictureBoxSizeMode.CenterImage, Image = Properties.Resources.Square, }; //3rd particle only used in configuration with 2 pulleys and 3 masses
            p2 = new PictureBox{Name = "p2",Size = new Size(40, 40),SizeMode = PictureBoxSizeMode.CenterImage,Image = Properties.Resources.Square,};
            p3 = new PictureBox   {Name = "p3",Size = new Size(40, 40),SizeMode = PictureBoxSizeMode.CenterImage,Image = Properties.Resources.Square,};
            table = new PictureBox{Name = "table",Size = new Size(tblW, tblH),SizeMode = PictureBoxSizeMode.StretchImage,Image = Properties.Resources.Square,Location = new Point(startX - tblW, startY + pulley.Height - 7),};
            Controls.Add(pulley);Controls.Add(pulleyOne);Controls.Add(p1);Controls.Add(p2);Controls.Add(p3);//Adds pictureboxes to forms.
            p1.Hide();table.Hide();pulleyOne.Hide();
            Controls.Add(table);
            reset();
        }

        public void pulleyQuestion(){
            Random rnd = new Random(); //Initialise random variable.
            int choice = rnd.Next(1, 3); //Used to decide what question to give.
            m1 = rnd.Next(1, 5);m2 = rnd.Next(6, 10);m3 = rnd.Next(11, 15); //Generate a suitable masses for particles.
            onePulley sim = new onePulley();  //Instantiate simulation to compute answers.
            string info = " particles are connected by an inextensible string passing over a smooth pulley.";
            if(!useTable){ //One pulley with 2 masses.
                sim.pulleySetup(m1,m2); 
                info = "2" + info //String containing question and relevant background information.
                        +"\n Mass of the first particle: " + m1 + "Kg"
                        +"\n Mass on the second particle: " + m2 + "Kg";
            }else{
                mu = Convert.ToDouble(rnd.Next(0, 10)) / 10; //Generates friction coefficient.
                if (use2Pulley){ //2 pulleys with a table and 2 masses.
                    sim.pulleyTbl2Setup(m1, m2, m3, mu);
                    info = "3" + info //String containing question and relevant background information.
                              + "\n Mass of the leftmost particle: " + m1 + "Kg"
                              + "\n Mass of the particle on the table: " + m2 + "Kg"
                              + "\n Mass of the rightmost particle: " + m3 + "Kg"
                              + "\n Friction coefficient:  " + mu;
                }else{  //2 pulleys with a table and 3 masses.
                    sim.pulleyTblSetup(m1,m2,mu);
                    info = "2" + info //String containing question and relevant background information.
                              + "\n Mass of the particle on the table: " + m1 + "Kg"
                              + "\n Mass of the rightmost particle: " + m2 + "Kg"
                              + "\n Friction coefficient: " + mu;
                }
            } 
            switch (choice){  //Adds a different question to the string depending on the number generated.
                case 1:
                    info += "\n Find the acceleration of the system.";
                    ans = sim.getAcc();
                    ansUnitsLabel.Text = "ms\u207b\xB2";
                    break;
                case 2:
                    int tensionChoice = rnd.Next(1, 3);
                    info += "\n Find the tension in the ";
                    if (use2Pulley){ //This case has 2 strings so 2 tensions.
                        switch (tensionChoice){ //Randomly asks user to find tension in first or second string.
                            case 1:
                                info += "leftmost string.";
                                ans = sim.getT1();
                                break;
                            case 2:
                                info += "rightmost string.";
                                ans = sim.getT2();
                                break;
                        }
                    }else{
                        info += "string.";
                        ans = sim.getT1();
                    }
                    ansUnitsLabel.Text = "N"; //Output units next to answer box.
                    break;
            }
            info += "\n (g = 9.8, give answer to 2 decimal places)"; //Adds extra info to question.
            questionLabel.Text = info;  //Outputs question into a label.
        }
        public void reset(){  //Resets displayed stats, picturebox locations, time and also stops timer
            saved = false;
            foreach (Control x in controlPanel.Controls){
                if(x is NumericUpDown) //Checks if control is NumericUpDown
                {
                    NumericUpDown y = x as NumericUpDown;
                    y.Text = y.Value.ToString();  //Sets value to defaut/value before change.
                }
            }
            correctLabel.Text = "";
            pulley.Location = new Point(startX, startY);  //Set pulley picturebox location to initial position.
            if (useTable){
                //Makes table appear if user ticked the table check box.
                table.Show(); table.SendToBack(); fricCoeffLabel.Show(); coeffBox.Show();
                //Adjustments to stop pictureboxes overlapping. More fine tuning needed.
                p2.BringToFront(); p3.BringToFront(); pulley.SendToBack();
                p2.Location = new Point(table.Left + tblW/2, startY + 14); p3.Location = new Point(table.Left + tblW + p2.Width, startY + gap);
                checkBoxPulley.Show();
                if (use2Pulley){
                    pulleyOne.Location = new Point(startX - table.Width, startY); pulleyOne.Show();
                    mass3Box.Show(); massUnitLabel3.Show(); mass3Label.Show();
                    p1.Show(); p1.Location = new Point(table.Left - p1.Width + 10, startY + gap);
                    tn2Txt.Show();
                }else{
                    pulleyOne.Hide();
                    mass3Box.Hide(); massUnitLabel3.Hide(); mass3Label.Hide();
                    p1.Hide();
                    tn2Txt.Hide();
                }
            }else{
                //Makes table, 2nd pulley and 2nd pulley checkbox hidden if check box is unticked.
                table.Hide(); fricCoeffLabel.Hide(); coeffBox.Hide(); pulleyOne.Hide();checkBoxPulley.Hide();
                p1.Hide(); mass3Box.Hide(); massUnitLabel3.Hide(); mass3Label.Hide(); tn2Txt.Hide();
                p2.Location = new Point(startX - pulley.Width / 2 + 30, startY + gap); p3.Location = new Point(startX + pulley.Width / 2 + 10, startY + gap);
                pulley.SendToBack(); p2.BringToFront(); p3.BringToFront();
            }
            //Below code resets text in relevant labels for simulation.
            timeNum = 0;
            timeTxt.Text = "Time elapsed: ";
            tnTxt.Text = "Tension: ";
            tn2Txt.Text = "Tension 2: ";
            accTxt.Text = "Acceleration: ";
            speedTxt.Text = "Speed: ";
            start = false;
            pullTimer.Stop();
            this.Refresh();
        }

        private void resetBtn_Click(object sender, EventArgs e){
            reset(); //Call reset routine on button click.
        }

        private void checkBoxPulley_CheckedChanged(object sender, EventArgs e){
            use2Pulley = checkBoxPulley.Checked; //Makes option to enter mass 3 (dis)appear, for 2 pulleys with table. 
            reset();
        }

        private void learnBox_CheckedChanged(object sender, EventArgs e){
            assumptions.Visible = !assumptions.Visible; //Toggle assumptions label visibility.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            simForms.questionSave(questionLabel.Text, ans, ansUnitsLabel.Text, ref saved); 
        }

        private void assumptions_Click(object sender, EventArgs e)
        {

        }

        private void onePulleySim_Load(object sender, EventArgs e)
        {

        }

        private void testMode_Click(object sender, EventArgs e){
            reset();
            simForms.testSetup(statsPanel, controlPanel, coverPanel, learnBox, questionLabel);
            if (test) { testMode.Text = "Test yourself"; } else { testMode.Text = "Return to simulation"; pulleyQuestion(); } //Change text displayed on button to reflect mode change. Generates a question if switched to test mode.
            test = !test;
        }

        private void generateQuestion_Click(object sender, EventArgs e){
            
            reset();
            pulleyQuestion();
        }
        private void checkBtn_Click(object sender, EventArgs e){
            reset();
            if (useTable){
                if (use2Pulley){
                    NumericUpDown[] boxes = { mass1Box, mass2Box, mass3Box, coeffBox}; //Array of input boxes.
                    double[] data = { m1, m2 , m3, mu}; //Array of data to input.
                    simForms.check(boxes, data, ans, ansBox.Text, switchBtn, correctLabel); //Calls routine to check answer and run animation if correct.
                }
                else{
                    NumericUpDown[] boxes = { mass1Box, mass2Box, coeffBox}; //Array of input boxes.
                    double[] data = { m1, m2, mu };  //Array of data to input.
                    simForms.check(boxes, data, ans, ansBox.Text, switchBtn, correctLabel); //Calls routine to check answer and run animation if correct.
                }  
            }else{
                NumericUpDown[] boxes = {mass1Box, mass2Box}; //Array of input boxes.
                double[] data = {m1,m2}; //Array of data to input.
                simForms.check(boxes, data, ans, ansBox.Text, switchBtn, correctLabel); //Calls routine to check answer and run animation if correct.
            }
        }

        private void exitBtn_Click(object sender, EventArgs e){
            this.Close(); //Close window when exit button clicked.
        }

        private void onePulleySim_Paint(object sender, PaintEventArgs e){
            System.Drawing.Color green = System.Drawing.ColorTranslator.FromHtml("#00FF00");
            Graphics g = this.CreateGraphics(); //Instantiate graphics.
            Pen myPen = new Pen(green) {Width = 1}; //Create pen.
            //Strings drawn below for each case.
            g.DrawLine(myPen, p3.Left + p3.Width / 2, pulley.Top + pulley.Height / 2, p3.Left + p3.Width / 2, p3.Top); //String connecting right pulley to right particle.
            if (useTable){
                g.DrawLine(myPen, p2.Left + p2.Width, p2.Top + p2.Height/2, pulley.Left, p2.Top + p2.Height / 2); //String connecting centre particle to right pulley.
                if (use2Pulley){ 
                    g.DrawLine(myPen, pulleyOne.Left + pulleyOne.Width, p2.Top + p2.Height / 2, p2.Left, p2.Top + p2.Height / 2); //String connecting centre particle to left pulley.
                    g.DrawLine(myPen, p1.Left + p1.Width/2, p1.Top,  p1.Left + p1.Width / 2, pulleyOne.Top + pulleyOne.Height + 20);  //String connecting left particle to left pulley.
                }
            }else{g.DrawLine(myPen, p2.Left + p2.Width / 2 - 5, pulley.Top + pulley.Height / 2, p2.Left + p2.Width / 2 - 5, p2.Top); } //String connecting left particle to single pulley.
        }

        private void checkBoxTable_CheckedChanged(object sender, EventArgs e){
            //Toggles between one pulley and table or one pulley without table.   
            useTable = checkBoxTable.Checked; //Makes option to enter friction coefficient (dis)appear, for pulley with table. 
            if (!checkBoxTable.Checked) { checkBoxPulley.Checked = false ; } //Ensures that the 2 pulley checkbox is unticked when this table checkbox is unticked.
            reset();
        }

        private void switchBtn_Click(object sender, EventArgs e){
            if (!start){
                reset();
                //Following lines instantiate simulation and appropriately configure the particle.
                onePulley sim = new onePulley();
                //Passes mass inputs into pulleySetup function, returns array of 2 particles configured for table or without table.
                if (useTable){ //If statemtn to call routine to setup simulation depending on chosen pulley arrrangement, returning configured particles that are stored in an array.
                    if (use2Pulley){masses = sim.pulleyTbl2Setup(Convert.ToDouble(mass1Box.Text), Convert.ToDouble(mass2Box.Text), Convert.ToDouble(mass3Box.Text), Convert.ToDouble(coeffBox.Text)); } 
                    else {masses = sim.pulleyTblSetup(Convert.ToDouble(mass1Box.Text), Convert.ToDouble(mass2Box.Text), Convert.ToDouble(coeffBox.Text));}
                }else{
                    masses = sim.pulleySetup(Convert.ToDouble(mass1Box.Text), Convert.ToDouble(mass2Box.Text)); 
                }
                start = true;
                // Following lines display relevant stats by calling the getters for the simulation.
                tnTxt.Text = "Tension: " + sim.getT1() + " N";
                tn2Txt.Text = "Tension 2: " + sim.getT2() + " N";
                accTxt.Text = "Acceleration: " + sim.getAcc() + " ms\u207b\xB2";
                pullTimer.Start();
            }else{
                if (pullTimer.Enabled) { pullTimer.Stop(); } else { pullTimer.Start(); } //Toggles the timer between starting and stopping to pause and play simulation.
            }
        }

        private void pullTimer_Tick(object sender, EventArgs e){ //Timer function, responible for animation.
            //Creates condition for which simulation must stop.
            bool condition;
            //Sets appropriate boundary conditions depending on the pulley arrangement being used.
            if (useTable){
                if (use2Pulley){
                    condition = p2.Left >= pulley.Left || p2.Left <= pulleyOne.Left || p1.Top < pulleyOne.Top + pulleyOne.Height + 20 || p3.Top < pulley.Top + pulley.Height;
                }else{
                    condition = (p2.Left >= pulley.Left || p3.Top >= table.Top + table.Height);
                }
            }else{
                condition = (p2.Top <= pulley.Top + pulley.Height|| p3.Top <= pulley.Top + pulley.Height|| p3.Top >= this.Height || p2.Top >= this.Height);
            }
            simForms.time(ref timeNum, ref start, condition, pullTimer);
            //Call move method for pictureboxes, update stats.
            if (use2Pulley) { masses[0].move(p1); masses[1].move(p2); masses[2].move(p3);}
            else{masses[0].move(p2);masses[1].move(p3);}
            speedTxt.Text = "Speed: " + masses[0].getSpeed().ToString() + " ms\u207b\xB9";
            timeTxt.Text = "Time Elapsed: " + timeNum / 1000 + " s";
        }
    }
}
