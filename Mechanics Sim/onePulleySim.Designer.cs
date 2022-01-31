
namespace Mechanics_Sim
{
    partial class onePulleySim
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(onePulleySim));
            this.controlPanel = new System.Windows.Forms.Panel();
            this.coverPanel = new System.Windows.Forms.Panel();
            this.ansLabel = new System.Windows.Forms.Label();
            this.ansBox = new System.Windows.Forms.NumericUpDown();
            this.correctLabel = new System.Windows.Forms.Label();
            this.ansUnitsLabel = new System.Windows.Forms.Label();
            this.checkBtn = new System.Windows.Forms.Button();
            this.learnBox = new System.Windows.Forms.CheckBox();
            this.generateQuestion = new System.Windows.Forms.Button();
            this.massUnitLabel3 = new System.Windows.Forms.Label();
            this.testMode = new System.Windows.Forms.Button();
            this.massUnitLabel2 = new System.Windows.Forms.Label();
            this.massUnitLabel1 = new System.Windows.Forms.Label();
            this.coeffBox = new System.Windows.Forms.NumericUpDown();
            this.mass3Box = new System.Windows.Forms.NumericUpDown();
            this.mass2Box = new System.Windows.Forms.NumericUpDown();
            this.checkBoxPulley = new System.Windows.Forms.CheckBox();
            this.mass3Label = new System.Windows.Forms.Label();
            this.mass1Box = new System.Windows.Forms.NumericUpDown();
            this.checkBoxTable = new System.Windows.Forms.CheckBox();
            this.fricCoeffLabel = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.mass2Label = new System.Windows.Forms.Label();
            this.switchBtn = new System.Windows.Forms.Button();
            this.mass1Label = new System.Windows.Forms.Label();
            this.statsPanel = new System.Windows.Forms.Panel();
            this.tn2Txt = new System.Windows.Forms.Label();
            this.timeTxt = new System.Windows.Forms.Label();
            this.tnTxt = new System.Windows.Forms.Label();
            this.accTxt = new System.Windows.Forms.Label();
            this.StatsTxt = new System.Windows.Forms.Label();
            this.speedTxt = new System.Windows.Forms.Label();
            this.pullTimer = new System.Windows.Forms.Timer(this.components);
            this.assumptions = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.controlPanel.SuspendLayout();
            this.coverPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ansBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coeffBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mass3Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mass2Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mass1Box)).BeginInit();
            this.statsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.coverPanel);
            this.controlPanel.Controls.Add(this.checkBtn);
            this.controlPanel.Controls.Add(this.learnBox);
            this.controlPanel.Controls.Add(this.generateQuestion);
            this.controlPanel.Controls.Add(this.massUnitLabel3);
            this.controlPanel.Controls.Add(this.testMode);
            this.controlPanel.Controls.Add(this.massUnitLabel2);
            this.controlPanel.Controls.Add(this.massUnitLabel1);
            this.controlPanel.Controls.Add(this.coeffBox);
            this.controlPanel.Controls.Add(this.mass3Box);
            this.controlPanel.Controls.Add(this.mass2Box);
            this.controlPanel.Controls.Add(this.checkBoxPulley);
            this.controlPanel.Controls.Add(this.mass3Label);
            this.controlPanel.Controls.Add(this.mass1Box);
            this.controlPanel.Controls.Add(this.checkBoxTable);
            this.controlPanel.Controls.Add(this.fricCoeffLabel);
            this.controlPanel.Controls.Add(this.exitBtn);
            this.controlPanel.Controls.Add(this.resetBtn);
            this.controlPanel.Controls.Add(this.mass2Label);
            this.controlPanel.Controls.Add(this.switchBtn);
            this.controlPanel.Controls.Add(this.mass1Label);
            this.controlPanel.Location = new System.Drawing.Point(8, 449);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(1339, 138);
            this.controlPanel.TabIndex = 17;
            // 
            // coverPanel
            // 
            this.coverPanel.Controls.Add(this.ansLabel);
            this.coverPanel.Controls.Add(this.ansBox);
            this.coverPanel.Controls.Add(this.correctLabel);
            this.coverPanel.Controls.Add(this.ansUnitsLabel);
            this.coverPanel.ForeColor = System.Drawing.Color.Black;
            this.coverPanel.Location = new System.Drawing.Point(0, 34);
            this.coverPanel.Name = "coverPanel";
            this.coverPanel.Size = new System.Drawing.Size(361, 104);
            this.coverPanel.TabIndex = 70;
            this.coverPanel.Visible = false;
            // 
            // ansLabel
            // 
            this.ansLabel.AutoSize = true;
            this.ansLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ansLabel.ForeColor = System.Drawing.Color.White;
            this.ansLabel.Location = new System.Drawing.Point(7, 34);
            this.ansLabel.Name = "ansLabel";
            this.ansLabel.Size = new System.Drawing.Size(78, 25);
            this.ansLabel.TabIndex = 67;
            this.ansLabel.Text = "Answer:";
            // 
            // ansBox
            // 
            this.ansBox.DecimalPlaces = 2;
            this.ansBox.Location = new System.Drawing.Point(91, 36);
            this.ansBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ansBox.Name = "ansBox";
            this.ansBox.Size = new System.Drawing.Size(53, 23);
            this.ansBox.TabIndex = 66;
            // 
            // correctLabel
            // 
            this.correctLabel.AutoSize = true;
            this.correctLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.correctLabel.ForeColor = System.Drawing.Color.White;
            this.correctLabel.Location = new System.Drawing.Point(209, 34);
            this.correctLabel.Name = "correctLabel";
            this.correctLabel.Size = new System.Drawing.Size(78, 25);
            this.correctLabel.TabIndex = 69;
            this.correctLabel.Text = "Answer:";
            // 
            // ansUnitsLabel
            // 
            this.ansUnitsLabel.AutoSize = true;
            this.ansUnitsLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ansUnitsLabel.ForeColor = System.Drawing.Color.White;
            this.ansUnitsLabel.Location = new System.Drawing.Point(150, 34);
            this.ansUnitsLabel.Name = "ansUnitsLabel";
            this.ansUnitsLabel.Size = new System.Drawing.Size(53, 25);
            this.ansUnitsLabel.TabIndex = 68;
            this.ansUnitsLabel.Text = "units";
            // 
            // checkBtn
            // 
            this.checkBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(190)))));
            this.checkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBtn.ForeColor = System.Drawing.Color.Black;
            this.checkBtn.Location = new System.Drawing.Point(367, 53);
            this.checkBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(196, 52);
            this.checkBtn.TabIndex = 65;
            this.checkBtn.Text = "Check Answer";
            this.checkBtn.UseMnemonic = false;
            this.checkBtn.UseVisualStyleBackColor = false;
            this.checkBtn.Visible = false;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // learnBox
            // 
            this.learnBox.AutoSize = true;
            this.learnBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.learnBox.ForeColor = System.Drawing.Color.White;
            this.learnBox.Location = new System.Drawing.Point(1206, 66);
            this.learnBox.Name = "learnBox";
            this.learnBox.Size = new System.Drawing.Size(127, 29);
            this.learnBox.TabIndex = 58;
            this.learnBox.Text = "Learn more";
            this.learnBox.UseVisualStyleBackColor = true;
            this.learnBox.CheckedChanged += new System.EventHandler(this.learnBox_CheckedChanged);
            // 
            // generateQuestion
            // 
            this.generateQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(190)))));
            this.generateQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.generateQuestion.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.generateQuestion.ForeColor = System.Drawing.Color.Black;
            this.generateQuestion.Location = new System.Drawing.Point(569, 53);
            this.generateQuestion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generateQuestion.Name = "generateQuestion";
            this.generateQuestion.Size = new System.Drawing.Size(196, 52);
            this.generateQuestion.TabIndex = 64;
            this.generateQuestion.Text = "Next Question";
            this.generateQuestion.UseMnemonic = false;
            this.generateQuestion.UseVisualStyleBackColor = false;
            this.generateQuestion.Visible = false;
            this.generateQuestion.Click += new System.EventHandler(this.generateQuestion_Click);
            // 
            // massUnitLabel3
            // 
            this.massUnitLabel3.AutoSize = true;
            this.massUnitLabel3.ForeColor = System.Drawing.Color.White;
            this.massUnitLabel3.Location = new System.Drawing.Point(328, 106);
            this.massUnitLabel3.Name = "massUnitLabel3";
            this.massUnitLabel3.Size = new System.Drawing.Size(21, 15);
            this.massUnitLabel3.TabIndex = 57;
            this.massUnitLabel3.Text = "Kg";
            // 
            // testMode
            // 
            this.testMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(190)))));
            this.testMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.testMode.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.testMode.ForeColor = System.Drawing.Color.Black;
            this.testMode.Location = new System.Drawing.Point(771, 53);
            this.testMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.testMode.Name = "testMode";
            this.testMode.Size = new System.Drawing.Size(229, 52);
            this.testMode.TabIndex = 63;
            this.testMode.Text = "Test yourself";
            this.testMode.UseVisualStyleBackColor = false;
            this.testMode.Click += new System.EventHandler(this.testMode_Click);
            // 
            // massUnitLabel2
            // 
            this.massUnitLabel2.AutoSize = true;
            this.massUnitLabel2.ForeColor = System.Drawing.Color.White;
            this.massUnitLabel2.Location = new System.Drawing.Point(328, 76);
            this.massUnitLabel2.Name = "massUnitLabel2";
            this.massUnitLabel2.Size = new System.Drawing.Size(21, 15);
            this.massUnitLabel2.TabIndex = 56;
            this.massUnitLabel2.Text = "Kg";
            // 
            // massUnitLabel1
            // 
            this.massUnitLabel1.AutoSize = true;
            this.massUnitLabel1.ForeColor = System.Drawing.Color.White;
            this.massUnitLabel1.Location = new System.Drawing.Point(328, 44);
            this.massUnitLabel1.Name = "massUnitLabel1";
            this.massUnitLabel1.Size = new System.Drawing.Size(21, 15);
            this.massUnitLabel1.TabIndex = 55;
            this.massUnitLabel1.Text = "Kg";
            // 
            // coeffBox
            // 
            this.coeffBox.DecimalPlaces = 2;
            this.coeffBox.Location = new System.Drawing.Point(135, 41);
            this.coeffBox.Name = "coeffBox";
            this.coeffBox.Size = new System.Drawing.Size(73, 23);
            this.coeffBox.TabIndex = 20;
            // 
            // mass3Box
            // 
            this.mass3Box.DecimalPlaces = 2;
            this.mass3Box.Location = new System.Drawing.Point(266, 104);
            this.mass3Box.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.mass3Box.Name = "mass3Box";
            this.mass3Box.Size = new System.Drawing.Size(56, 23);
            this.mass3Box.TabIndex = 21;
            this.mass3Box.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // mass2Box
            // 
            this.mass2Box.DecimalPlaces = 2;
            this.mass2Box.Location = new System.Drawing.Point(266, 74);
            this.mass2Box.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.mass2Box.Name = "mass2Box";
            this.mass2Box.Size = new System.Drawing.Size(56, 23);
            this.mass2Box.TabIndex = 22;
            this.mass2Box.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // checkBoxPulley
            // 
            this.checkBoxPulley.AutoSize = true;
            this.checkBoxPulley.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxPulley.ForeColor = System.Drawing.Color.White;
            this.checkBoxPulley.Location = new System.Drawing.Point(135, 101);
            this.checkBoxPulley.Name = "checkBoxPulley";
            this.checkBoxPulley.Size = new System.Drawing.Size(72, 19);
            this.checkBoxPulley.TabIndex = 37;
            this.checkBoxPulley.Text = "2 pulleys";
            this.checkBoxPulley.UseVisualStyleBackColor = true;
            this.checkBoxPulley.CheckedChanged += new System.EventHandler(this.checkBoxPulley_CheckedChanged);
            // 
            // mass3Label
            // 
            this.mass3Label.AutoSize = true;
            this.mass3Label.ForeColor = System.Drawing.Color.White;
            this.mass3Label.Location = new System.Drawing.Point(214, 106);
            this.mass3Label.Name = "mass3Label";
            this.mass3Label.Size = new System.Drawing.Size(46, 15);
            this.mass3Label.TabIndex = 36;
            this.mass3Label.Text = "Mass 3:";
            // 
            // mass1Box
            // 
            this.mass1Box.DecimalPlaces = 2;
            this.mass1Box.Location = new System.Drawing.Point(266, 42);
            this.mass1Box.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.mass1Box.Name = "mass1Box";
            this.mass1Box.Size = new System.Drawing.Size(56, 23);
            this.mass1Box.TabIndex = 19;
            this.mass1Box.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // checkBoxTable
            // 
            this.checkBoxTable.AutoSize = true;
            this.checkBoxTable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxTable.ForeColor = System.Drawing.Color.White;
            this.checkBoxTable.Location = new System.Drawing.Point(135, 76);
            this.checkBoxTable.Name = "checkBoxTable";
            this.checkBoxTable.Size = new System.Drawing.Size(53, 19);
            this.checkBoxTable.TabIndex = 21;
            this.checkBoxTable.Text = "Table";
            this.checkBoxTable.UseVisualStyleBackColor = true;
            this.checkBoxTable.CheckedChanged += new System.EventHandler(this.checkBoxTable_CheckedChanged);
            // 
            // fricCoeffLabel
            // 
            this.fricCoeffLabel.AutoSize = true;
            this.fricCoeffLabel.ForeColor = System.Drawing.Color.White;
            this.fricCoeffLabel.Location = new System.Drawing.Point(3, 44);
            this.fricCoeffLabel.Name = "fricCoeffLabel";
            this.fricCoeffLabel.Size = new System.Drawing.Size(132, 15);
            this.fricCoeffLabel.TabIndex = 33;
            this.fricCoeffLabel.Text = "Friction Coefficient (μ): ";
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(190)))));
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitBtn.ForeColor = System.Drawing.Color.Black;
            this.exitBtn.Location = new System.Drawing.Point(1004, 54);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(196, 52);
            this.exitBtn.TabIndex = 32;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(190)))));
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resetBtn.ForeColor = System.Drawing.Color.Black;
            this.resetBtn.Location = new System.Drawing.Point(569, 53);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(196, 52);
            this.resetBtn.TabIndex = 12;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // mass2Label
            // 
            this.mass2Label.AutoSize = true;
            this.mass2Label.ForeColor = System.Drawing.Color.White;
            this.mass2Label.Location = new System.Drawing.Point(214, 76);
            this.mass2Label.Name = "mass2Label";
            this.mass2Label.Size = new System.Drawing.Size(46, 15);
            this.mass2Label.TabIndex = 14;
            this.mass2Label.Text = "Mass 2:";
            // 
            // switchBtn
            // 
            this.switchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(190)))));
            this.switchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.switchBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.switchBtn.ForeColor = System.Drawing.Color.Black;
            this.switchBtn.Location = new System.Drawing.Point(367, 53);
            this.switchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.switchBtn.Name = "switchBtn";
            this.switchBtn.Size = new System.Drawing.Size(196, 52);
            this.switchBtn.TabIndex = 0;
            this.switchBtn.Text = "Start/Stop";
            this.switchBtn.UseVisualStyleBackColor = false;
            this.switchBtn.Click += new System.EventHandler(this.switchBtn_Click);
            // 
            // mass1Label
            // 
            this.mass1Label.AutoSize = true;
            this.mass1Label.ForeColor = System.Drawing.Color.White;
            this.mass1Label.Location = new System.Drawing.Point(214, 44);
            this.mass1Label.Name = "mass1Label";
            this.mass1Label.Size = new System.Drawing.Size(46, 15);
            this.mass1Label.TabIndex = 11;
            this.mass1Label.Text = "Mass 1:";
            // 
            // statsPanel
            // 
            this.statsPanel.Controls.Add(this.tn2Txt);
            this.statsPanel.Controls.Add(this.timeTxt);
            this.statsPanel.Controls.Add(this.tnTxt);
            this.statsPanel.Controls.Add(this.accTxt);
            this.statsPanel.Controls.Add(this.StatsTxt);
            this.statsPanel.Controls.Add(this.speedTxt);
            this.statsPanel.Location = new System.Drawing.Point(983, 9);
            this.statsPanel.Name = "statsPanel";
            this.statsPanel.Size = new System.Drawing.Size(331, 200);
            this.statsPanel.TabIndex = 18;
            // 
            // tn2Txt
            // 
            this.tn2Txt.AutoSize = true;
            this.tn2Txt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tn2Txt.ForeColor = System.Drawing.Color.White;
            this.tn2Txt.Location = new System.Drawing.Point(61, 141);
            this.tn2Txt.Name = "tn2Txt";
            this.tn2Txt.Size = new System.Drawing.Size(100, 25);
            this.tn2Txt.TabIndex = 15;
            this.tn2Txt.Text = "Tension 2: ";
            // 
            // timeTxt
            // 
            this.timeTxt.AutoSize = true;
            this.timeTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeTxt.ForeColor = System.Drawing.Color.White;
            this.timeTxt.Location = new System.Drawing.Point(29, 91);
            this.timeTxt.Name = "timeTxt";
            this.timeTxt.Size = new System.Drawing.Size(132, 25);
            this.timeTxt.TabIndex = 14;
            this.timeTxt.Text = "Time Elapsed: ";
            // 
            // tnTxt
            // 
            this.tnTxt.AutoSize = true;
            this.tnTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tnTxt.ForeColor = System.Drawing.Color.White;
            this.tnTxt.Location = new System.Drawing.Point(76, 116);
            this.tnTxt.Name = "tnTxt";
            this.tnTxt.Size = new System.Drawing.Size(85, 25);
            this.tnTxt.TabIndex = 13;
            this.tnTxt.Text = "Tension: ";
            // 
            // accTxt
            // 
            this.accTxt.AutoSize = true;
            this.accTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.accTxt.ForeColor = System.Drawing.Color.White;
            this.accTxt.Location = new System.Drawing.Point(29, 56);
            this.accTxt.Name = "accTxt";
            this.accTxt.Size = new System.Drawing.Size(126, 25);
            this.accTxt.TabIndex = 12;
            this.accTxt.Text = "Acceleration: ";
            // 
            // StatsTxt
            // 
            this.StatsTxt.AutoSize = true;
            this.StatsTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StatsTxt.ForeColor = System.Drawing.Color.White;
            this.StatsTxt.Location = new System.Drawing.Point(164, 5);
            this.StatsTxt.Name = "StatsTxt";
            this.StatsTxt.Size = new System.Drawing.Size(84, 25);
            this.StatsTxt.TabIndex = 8;
            this.StatsTxt.Text = "Statistics";
            // 
            // speedTxt
            // 
            this.speedTxt.AutoSize = true;
            this.speedTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.speedTxt.ForeColor = System.Drawing.Color.White;
            this.speedTxt.Location = new System.Drawing.Point(82, 31);
            this.speedTxt.Name = "speedTxt";
            this.speedTxt.Size = new System.Drawing.Size(73, 25);
            this.speedTxt.TabIndex = 6;
            this.speedTxt.Text = "Speed: ";
            // 
            // pullTimer
            // 
            this.pullTimer.Interval = 20;
            this.pullTimer.Tick += new System.EventHandler(this.pullTimer_Tick);
            // 
            // assumptions
            // 
            this.assumptions.AutoSize = true;
            this.assumptions.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.assumptions.ForeColor = System.Drawing.Color.White;
            this.assumptions.Location = new System.Drawing.Point(12, 9);
            this.assumptions.Name = "assumptions";
            this.assumptions.Size = new System.Drawing.Size(729, 300);
            this.assumptions.TabIndex = 36;
            this.assumptions.Text = resources.GetString("assumptions.Text");
            this.assumptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.assumptions.Visible = false;
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.questionLabel.ForeColor = System.Drawing.Color.White;
            this.questionLabel.Location = new System.Drawing.Point(15, 29);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(88, 25);
            this.questionLabel.TabIndex = 37;
            this.questionLabel.Text = "Question\r\n";
            this.questionLabel.Visible = false;
            // 
            // onePulleySim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(1361, 599);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.assumptions);
            this.Controls.Add(this.statsPanel);
            this.Controls.Add(this.controlPanel);
            this.Name = "onePulleySim";
            this.Text = "onePulleySim";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.onePulleySim_Paint);
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.coverPanel.ResumeLayout(false);
            this.coverPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ansBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coeffBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mass3Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mass2Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mass1Box)).EndInit();
            this.statsPanel.ResumeLayout(false);
            this.statsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label mass1Label;
        private System.Windows.Forms.Button switchBtn;
        private System.Windows.Forms.Panel statsPanel;
        private System.Windows.Forms.Label timeTxt;
        private System.Windows.Forms.Label tnTxt;
        private System.Windows.Forms.Label accTxt;
        private System.Windows.Forms.Label StatsTxt;
        private System.Windows.Forms.Label speedTxt;
        private System.Windows.Forms.Timer pullTimer;
        private System.Windows.Forms.Label mass2Label;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.CheckBox checkBoxTable;
        private System.Windows.Forms.Label fricCoeffLabel;
        private System.Windows.Forms.Label mass3Label;
        private System.Windows.Forms.CheckBox checkBoxPulley;
        private System.Windows.Forms.NumericUpDown mass1Box;
        private System.Windows.Forms.NumericUpDown coeffBox;
        private System.Windows.Forms.NumericUpDown mass3Box;
        private System.Windows.Forms.NumericUpDown mass2Box;
        private System.Windows.Forms.Label tn2Txt;
        private System.Windows.Forms.Label massUnitLabel3;
        private System.Windows.Forms.Label massUnitLabel2;
        private System.Windows.Forms.Label massUnitLabel1;
        private System.Windows.Forms.Label assumptions;
        private System.Windows.Forms.CheckBox learnBox;
        private System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.Button generateQuestion;
        private System.Windows.Forms.Button testMode;
        private System.Windows.Forms.Label correctLabel;
        private System.Windows.Forms.Label ansUnitsLabel;
        private System.Windows.Forms.Label ansLabel;
        private System.Windows.Forms.NumericUpDown ansBox;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Panel coverPanel;
    }
}