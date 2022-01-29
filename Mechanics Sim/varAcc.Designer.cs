
namespace Mechanics_Sim
{
    partial class varAccSim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(varAccSim));
            this.statsPanel = new System.Windows.Forms.Panel();
            this.accTxt = new System.Windows.Forms.Label();
            this.dispTxt = new System.Windows.Forms.Label();
            this.timeTxt = new System.Windows.Forms.Label();
            this.Stats = new System.Windows.Forms.Label();
            this.speedTxt = new System.Windows.Forms.Label();
            this.velEqnTxt = new System.Windows.Forms.Label();
            this.velEqnYTxt = new System.Windows.Forms.Label();
            this.accEqnTxt = new System.Windows.Forms.Label();
            this.accEqnYTxt = new System.Windows.Forms.Label();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.t3LabelX = new System.Windows.Forms.Label();
            this.correctLabel = new System.Windows.Forms.Label();
            this.ansUnitsLabel = new System.Windows.Forms.Label();
            this.ansLabel = new System.Windows.Forms.Label();
            this.ansBox = new System.Windows.Forms.NumericUpDown();
            this.checkBtn = new System.Windows.Forms.Button();
            this.generateQuestion = new System.Windows.Forms.Button();
            this.testMode = new System.Windows.Forms.Button();
            this.dispUnitLabel = new System.Windows.Forms.Label();
            this.learnBox = new System.Windows.Forms.CheckBox();
            this.y1Box = new System.Windows.Forms.NumericUpDown();
            this.x3Box = new System.Windows.Forms.NumericUpDown();
            this.y3Box = new System.Windows.Forms.NumericUpDown();
            this.y0Box = new System.Windows.Forms.NumericUpDown();
            this.t2LabelX = new System.Windows.Forms.Label();
            this.t3LabelY = new System.Windows.Forms.Label();
            this.x2Box = new System.Windows.Forms.NumericUpDown();
            this.t0LabelY = new System.Windows.Forms.Label();
            this.x1Box = new System.Windows.Forms.NumericUpDown();
            this.t2LabelY = new System.Windows.Forms.Label();
            this.t1LabelX = new System.Windows.Forms.Label();
            this.t0LabelX = new System.Windows.Forms.Label();
            this.y2Box = new System.Windows.Forms.NumericUpDown();
            this.x0Box = new System.Windows.Forms.NumericUpDown();
            this.bracketL = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.dispLabel = new System.Windows.Forms.Label();
            this.switchBtn = new System.Windows.Forms.Button();
            this.t1LabelY = new System.Windows.Forms.Label();
            this.bracketR = new System.Windows.Forms.Label();
            this.dimensionSwitch = new System.Windows.Forms.Button();
            this.varAccTimer = new System.Windows.Forms.Timer(this.components);
            this.assumptions = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.statsPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ansBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y1Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x3Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y3Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y0Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x2Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x1Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y2Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x0Box)).BeginInit();
            this.SuspendLayout();
            // 
            // statsPanel
            // 
            this.statsPanel.Controls.Add(this.accTxt);
            this.statsPanel.Controls.Add(this.dispTxt);
            this.statsPanel.Controls.Add(this.timeTxt);
            this.statsPanel.Controls.Add(this.Stats);
            this.statsPanel.Controls.Add(this.speedTxt);
            this.statsPanel.Controls.Add(this.velEqnTxt);
            this.statsPanel.Controls.Add(this.velEqnYTxt);
            this.statsPanel.Controls.Add(this.accEqnTxt);
            this.statsPanel.Controls.Add(this.accEqnYTxt);
            this.statsPanel.Location = new System.Drawing.Point(1122, 11);
            this.statsPanel.Name = "statsPanel";
            this.statsPanel.Size = new System.Drawing.Size(438, 303);
            this.statsPanel.TabIndex = 30;
            // 
            // accTxt
            // 
            this.accTxt.AutoSize = true;
            this.accTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.accTxt.ForeColor = System.Drawing.Color.White;
            this.accTxt.Location = new System.Drawing.Point(61, 241);
            this.accTxt.Name = "accTxt";
            this.accTxt.Size = new System.Drawing.Size(126, 25);
            this.accTxt.TabIndex = 22;
            this.accTxt.Text = "Acceleration: ";
            // 
            // dispTxt
            // 
            this.dispTxt.AutoSize = true;
            this.dispTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dispTxt.ForeColor = System.Drawing.Color.White;
            this.dispTxt.Location = new System.Drawing.Point(61, 216);
            this.dispTxt.Name = "dispTxt";
            this.dispTxt.Size = new System.Drawing.Size(135, 25);
            this.dispTxt.TabIndex = 20;
            this.dispTxt.Text = "Displacement: ";
            // 
            // timeTxt
            // 
            this.timeTxt.AutoSize = true;
            this.timeTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeTxt.ForeColor = System.Drawing.Color.White;
            this.timeTxt.Location = new System.Drawing.Point(64, 266);
            this.timeTxt.Name = "timeTxt";
            this.timeTxt.Size = new System.Drawing.Size(132, 25);
            this.timeTxt.TabIndex = 19;
            this.timeTxt.Text = "Time elapsed: ";
            // 
            // Stats
            // 
            this.Stats.AutoSize = true;
            this.Stats.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Stats.ForeColor = System.Drawing.Color.White;
            this.Stats.Location = new System.Drawing.Point(140, 7);
            this.Stats.Name = "Stats";
            this.Stats.Size = new System.Drawing.Size(84, 25);
            this.Stats.TabIndex = 16;
            this.Stats.Text = "Statistics";
            // 
            // speedTxt
            // 
            this.speedTxt.AutoSize = true;
            this.speedTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.speedTxt.ForeColor = System.Drawing.Color.White;
            this.speedTxt.Location = new System.Drawing.Point(123, 191);
            this.speedTxt.Name = "speedTxt";
            this.speedTxt.Size = new System.Drawing.Size(73, 25);
            this.speedTxt.TabIndex = 15;
            this.speedTxt.Text = "Speed: ";
            // 
            // velEqnTxt
            // 
            this.velEqnTxt.AutoSize = true;
            this.velEqnTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.velEqnTxt.ForeColor = System.Drawing.Color.White;
            this.velEqnTxt.Location = new System.Drawing.Point(36, 46);
            this.velEqnTxt.Name = "velEqnTxt";
            this.velEqnTxt.Size = new System.Drawing.Size(188, 25);
            this.velEqnTxt.TabIndex = 21;
            this.velEqnTxt.Text = "Velocity equation X:  ";
            // 
            // velEqnYTxt
            // 
            this.velEqnYTxt.AutoSize = true;
            this.velEqnYTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.velEqnYTxt.ForeColor = System.Drawing.Color.White;
            this.velEqnYTxt.Location = new System.Drawing.Point(36, 71);
            this.velEqnYTxt.Name = "velEqnYTxt";
            this.velEqnYTxt.Size = new System.Drawing.Size(188, 25);
            this.velEqnYTxt.TabIndex = 23;
            this.velEqnYTxt.Text = "Velocity equation Y:  ";
            this.velEqnYTxt.Visible = false;
            // 
            // accEqnTxt
            // 
            this.accEqnTxt.AutoSize = true;
            this.accEqnTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.accEqnTxt.ForeColor = System.Drawing.Color.White;
            this.accEqnTxt.Location = new System.Drawing.Point(0, 119);
            this.accEqnTxt.Name = "accEqnTxt";
            this.accEqnTxt.Size = new System.Drawing.Size(222, 25);
            this.accEqnTxt.TabIndex = 17;
            this.accEqnTxt.Text = "Acceleration equation X: ";
            // 
            // accEqnYTxt
            // 
            this.accEqnYTxt.AutoSize = true;
            this.accEqnYTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.accEqnYTxt.ForeColor = System.Drawing.Color.White;
            this.accEqnYTxt.Location = new System.Drawing.Point(0, 144);
            this.accEqnYTxt.Name = "accEqnYTxt";
            this.accEqnYTxt.Size = new System.Drawing.Size(222, 25);
            this.accEqnYTxt.TabIndex = 24;
            this.accEqnYTxt.Text = "Acceleration equation Y: ";
            this.accEqnYTxt.Visible = false;
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.t3LabelX);
            this.controlPanel.Controls.Add(this.correctLabel);
            this.controlPanel.Controls.Add(this.ansUnitsLabel);
            this.controlPanel.Controls.Add(this.ansLabel);
            this.controlPanel.Controls.Add(this.ansBox);
            this.controlPanel.Controls.Add(this.checkBtn);
            this.controlPanel.Controls.Add(this.generateQuestion);
            this.controlPanel.Controls.Add(this.testMode);
            this.controlPanel.Controls.Add(this.dispUnitLabel);
            this.controlPanel.Controls.Add(this.learnBox);
            this.controlPanel.Controls.Add(this.y1Box);
            this.controlPanel.Controls.Add(this.x3Box);
            this.controlPanel.Controls.Add(this.y3Box);
            this.controlPanel.Controls.Add(this.y0Box);
            this.controlPanel.Controls.Add(this.t2LabelX);
            this.controlPanel.Controls.Add(this.t3LabelY);
            this.controlPanel.Controls.Add(this.x2Box);
            this.controlPanel.Controls.Add(this.t0LabelY);
            this.controlPanel.Controls.Add(this.x1Box);
            this.controlPanel.Controls.Add(this.t2LabelY);
            this.controlPanel.Controls.Add(this.t1LabelX);
            this.controlPanel.Controls.Add(this.t0LabelX);
            this.controlPanel.Controls.Add(this.y2Box);
            this.controlPanel.Controls.Add(this.x0Box);
            this.controlPanel.Controls.Add(this.bracketL);
            this.controlPanel.Controls.Add(this.exitBtn);
            this.controlPanel.Controls.Add(this.resetBtn);
            this.controlPanel.Controls.Add(this.dispLabel);
            this.controlPanel.Controls.Add(this.switchBtn);
            this.controlPanel.Controls.Add(this.t1LabelY);
            this.controlPanel.Controls.Add(this.bracketR);
            this.controlPanel.Location = new System.Drawing.Point(12, 470);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(1637, 168);
            this.controlPanel.TabIndex = 31;
            // 
            // t3LabelX
            // 
            this.t3LabelX.AutoSize = true;
            this.t3LabelX.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.t3LabelX.ForeColor = System.Drawing.Color.White;
            this.t3LabelX.Location = new System.Drawing.Point(569, 60);
            this.t3LabelX.Name = "t3LabelX";
            this.t3LabelX.Size = new System.Drawing.Size(28, 30);
            this.t3LabelX.TabIndex = 40;
            this.t3LabelX.Text = "t³";
            // 
            // correctLabel
            // 
            this.correctLabel.AutoSize = true;
            this.correctLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.correctLabel.ForeColor = System.Drawing.Color.White;
            this.correctLabel.Location = new System.Drawing.Point(205, 14);
            this.correctLabel.Name = "correctLabel";
            this.correctLabel.Size = new System.Drawing.Size(78, 25);
            this.correctLabel.TabIndex = 64;
            this.correctLabel.Text = "Answer:";
            this.correctLabel.Visible = false;
            // 
            // ansUnitsLabel
            // 
            this.ansUnitsLabel.AutoSize = true;
            this.ansUnitsLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ansUnitsLabel.ForeColor = System.Drawing.Color.White;
            this.ansUnitsLabel.Location = new System.Drawing.Point(146, 14);
            this.ansUnitsLabel.Name = "ansUnitsLabel";
            this.ansUnitsLabel.Size = new System.Drawing.Size(53, 25);
            this.ansUnitsLabel.TabIndex = 63;
            this.ansUnitsLabel.Text = "units";
            this.ansUnitsLabel.Visible = false;
            // 
            // ansLabel
            // 
            this.ansLabel.AutoSize = true;
            this.ansLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ansLabel.ForeColor = System.Drawing.Color.White;
            this.ansLabel.Location = new System.Drawing.Point(3, 14);
            this.ansLabel.Name = "ansLabel";
            this.ansLabel.Size = new System.Drawing.Size(78, 25);
            this.ansLabel.TabIndex = 62;
            this.ansLabel.Text = "Answer:";
            this.ansLabel.Visible = false;
            // 
            // ansBox
            // 
            this.ansBox.DecimalPlaces = 2;
            this.ansBox.Location = new System.Drawing.Point(87, 16);
            this.ansBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ansBox.Name = "ansBox";
            this.ansBox.Size = new System.Drawing.Size(53, 23);
            this.ansBox.TabIndex = 61;
            this.ansBox.Visible = false;
            // 
            // checkBtn
            // 
            this.checkBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(190)))));
            this.checkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBtn.ForeColor = System.Drawing.Color.Black;
            this.checkBtn.Location = new System.Drawing.Point(662, 67);
            this.checkBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(196, 52);
            this.checkBtn.TabIndex = 60;
            this.checkBtn.Text = "Check Answer";
            this.checkBtn.UseMnemonic = false;
            this.checkBtn.UseVisualStyleBackColor = false;
            this.checkBtn.Visible = false;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // generateQuestion
            // 
            this.generateQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(190)))));
            this.generateQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.generateQuestion.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.generateQuestion.ForeColor = System.Drawing.Color.Black;
            this.generateQuestion.Location = new System.Drawing.Point(864, 66);
            this.generateQuestion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generateQuestion.Name = "generateQuestion";
            this.generateQuestion.Size = new System.Drawing.Size(196, 52);
            this.generateQuestion.TabIndex = 59;
            this.generateQuestion.Text = "Next Question";
            this.generateQuestion.UseMnemonic = false;
            this.generateQuestion.UseVisualStyleBackColor = false;
            this.generateQuestion.Visible = false;
            this.generateQuestion.Click += new System.EventHandler(this.generateQuestion_Click);
            // 
            // testMode
            // 
            this.testMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(190)))));
            this.testMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.testMode.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.testMode.ForeColor = System.Drawing.Color.Black;
            this.testMode.Location = new System.Drawing.Point(1066, 66);
            this.testMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.testMode.Name = "testMode";
            this.testMode.Size = new System.Drawing.Size(228, 52);
            this.testMode.TabIndex = 58;
            this.testMode.Text = "Test yourself";
            this.testMode.UseVisualStyleBackColor = false;
            this.testMode.Click += new System.EventHandler(this.testMode_Click);
            // 
            // dispUnitLabel
            // 
            this.dispUnitLabel.AutoSize = true;
            this.dispUnitLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dispUnitLabel.ForeColor = System.Drawing.Color.White;
            this.dispUnitLabel.Location = new System.Drawing.Point(619, 61);
            this.dispUnitLabel.Name = "dispUnitLabel";
            this.dispUnitLabel.Size = new System.Drawing.Size(28, 25);
            this.dispUnitLabel.TabIndex = 53;
            this.dispUnitLabel.Text = "m";
            // 
            // learnBox
            // 
            this.learnBox.AutoSize = true;
            this.learnBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.learnBox.ForeColor = System.Drawing.Color.White;
            this.learnBox.Location = new System.Drawing.Point(1502, 80);
            this.learnBox.Name = "learnBox";
            this.learnBox.Size = new System.Drawing.Size(127, 29);
            this.learnBox.TabIndex = 52;
            this.learnBox.Text = "Learn more";
            this.learnBox.UseVisualStyleBackColor = true;
            this.learnBox.CheckedChanged += new System.EventHandler(this.learnBox_CheckedChanged);
            // 
            // y1Box
            // 
            this.y1Box.DecimalPlaces = 2;
            this.y1Box.Location = new System.Drawing.Point(342, 98);
            this.y1Box.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.y1Box.Name = "y1Box";
            this.y1Box.Size = new System.Drawing.Size(56, 23);
            this.y1Box.TabIndex = 44;
            this.y1Box.Visible = false;
            // 
            // x3Box
            // 
            this.x3Box.DecimalPlaces = 2;
            this.x3Box.Location = new System.Drawing.Point(529, 66);
            this.x3Box.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.x3Box.Name = "x3Box";
            this.x3Box.Size = new System.Drawing.Size(43, 23);
            this.x3Box.TabIndex = 34;
            // 
            // y3Box
            // 
            this.y3Box.DecimalPlaces = 2;
            this.y3Box.Location = new System.Drawing.Point(529, 97);
            this.y3Box.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.y3Box.Name = "y3Box";
            this.y3Box.Size = new System.Drawing.Size(43, 23);
            this.y3Box.TabIndex = 43;
            this.y3Box.Visible = false;
            // 
            // y0Box
            // 
            this.y0Box.DecimalPlaces = 2;
            this.y0Box.Location = new System.Drawing.Point(269, 97);
            this.y0Box.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.y0Box.Name = "y0Box";
            this.y0Box.Size = new System.Drawing.Size(54, 23);
            this.y0Box.TabIndex = 46;
            this.y0Box.Visible = false;
            // 
            // t2LabelX
            // 
            this.t2LabelX.AutoSize = true;
            this.t2LabelX.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.t2LabelX.ForeColor = System.Drawing.Color.White;
            this.t2LabelX.Location = new System.Drawing.Point(487, 60);
            this.t2LabelX.Name = "t2LabelX";
            this.t2LabelX.Size = new System.Drawing.Size(48, 30);
            this.t2LabelX.TabIndex = 39;
            this.t2LabelX.Text = "t² +";
            // 
            // t3LabelY
            // 
            this.t3LabelY.AutoSize = true;
            this.t3LabelY.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.t3LabelY.ForeColor = System.Drawing.Color.White;
            this.t3LabelY.Location = new System.Drawing.Point(569, 91);
            this.t3LabelY.Name = "t3LabelY";
            this.t3LabelY.Size = new System.Drawing.Size(28, 30);
            this.t3LabelY.TabIndex = 49;
            this.t3LabelY.Text = "t³";
            this.t3LabelY.Visible = false;
            // 
            // x2Box
            // 
            this.x2Box.DecimalPlaces = 2;
            this.x2Box.Location = new System.Drawing.Point(434, 66);
            this.x2Box.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.x2Box.Name = "x2Box";
            this.x2Box.Size = new System.Drawing.Size(56, 23);
            this.x2Box.TabIndex = 36;
            // 
            // t0LabelY
            // 
            this.t0LabelY.AutoSize = true;
            this.t0LabelY.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.t0LabelY.ForeColor = System.Drawing.Color.White;
            this.t0LabelY.Location = new System.Drawing.Point(319, 90);
            this.t0LabelY.Name = "t0LabelY";
            this.t0LabelY.Size = new System.Drawing.Size(27, 30);
            this.t0LabelY.TabIndex = 42;
            this.t0LabelY.Text = "+";
            this.t0LabelY.Visible = false;
            // 
            // x1Box
            // 
            this.x1Box.DecimalPlaces = 2;
            this.x1Box.Location = new System.Drawing.Point(342, 67);
            this.x1Box.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.x1Box.Name = "x1Box";
            this.x1Box.Size = new System.Drawing.Size(56, 23);
            this.x1Box.TabIndex = 35;
            // 
            // t2LabelY
            // 
            this.t2LabelY.AutoSize = true;
            this.t2LabelY.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.t2LabelY.ForeColor = System.Drawing.Color.White;
            this.t2LabelY.Location = new System.Drawing.Point(487, 91);
            this.t2LabelY.Name = "t2LabelY";
            this.t2LabelY.Size = new System.Drawing.Size(48, 30);
            this.t2LabelY.TabIndex = 48;
            this.t2LabelY.Text = "t² +";
            this.t2LabelY.Visible = false;
            // 
            // t1LabelX
            // 
            this.t1LabelX.AutoSize = true;
            this.t1LabelX.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.t1LabelX.ForeColor = System.Drawing.Color.White;
            this.t1LabelX.Location = new System.Drawing.Point(397, 60);
            this.t1LabelX.Name = "t1LabelX";
            this.t1LabelX.Size = new System.Drawing.Size(40, 30);
            this.t1LabelX.TabIndex = 38;
            this.t1LabelX.Text = "t +";
            // 
            // t0LabelX
            // 
            this.t0LabelX.AutoSize = true;
            this.t0LabelX.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.t0LabelX.ForeColor = System.Drawing.Color.White;
            this.t0LabelX.Location = new System.Drawing.Point(319, 59);
            this.t0LabelX.Name = "t0LabelX";
            this.t0LabelX.Size = new System.Drawing.Size(27, 30);
            this.t0LabelX.TabIndex = 32;
            this.t0LabelX.Text = "+";
            // 
            // y2Box
            // 
            this.y2Box.DecimalPlaces = 2;
            this.y2Box.Location = new System.Drawing.Point(434, 97);
            this.y2Box.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.y2Box.Name = "y2Box";
            this.y2Box.Size = new System.Drawing.Size(56, 23);
            this.y2Box.TabIndex = 45;
            this.y2Box.Visible = false;
            // 
            // x0Box
            // 
            this.x0Box.DecimalPlaces = 2;
            this.x0Box.Location = new System.Drawing.Point(269, 66);
            this.x0Box.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.x0Box.Name = "x0Box";
            this.x0Box.Size = new System.Drawing.Size(54, 23);
            this.x0Box.TabIndex = 37;
            // 
            // bracketL
            // 
            this.bracketL.AutoSize = true;
            this.bracketL.Font = new System.Drawing.Font("Segoe UI", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bracketL.ForeColor = System.Drawing.Color.White;
            this.bracketL.Location = new System.Drawing.Point(214, 26);
            this.bracketL.Name = "bracketL";
            this.bracketL.Size = new System.Drawing.Size(69, 106);
            this.bracketL.TabIndex = 50;
            this.bracketL.Text = "(";
            this.bracketL.Visible = false;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(190)))));
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitBtn.ForeColor = System.Drawing.Color.Black;
            this.exitBtn.Location = new System.Drawing.Point(1300, 67);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(196, 52);
            this.exitBtn.TabIndex = 33;
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
            this.resetBtn.Location = new System.Drawing.Point(864, 66);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(196, 52);
            this.resetBtn.TabIndex = 12;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // dispLabel
            // 
            this.dispLabel.AutoSize = true;
            this.dispLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dispLabel.ForeColor = System.Drawing.Color.White;
            this.dispLabel.Location = new System.Drawing.Point(3, 61);
            this.dispLabel.Name = "dispLabel";
            this.dispLabel.Size = new System.Drawing.Size(215, 25);
            this.dispLabel.TabIndex = 11;
            this.dispLabel.Text = "Displacement Equation: ";
            // 
            // switchBtn
            // 
            this.switchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(190)))));
            this.switchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.switchBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.switchBtn.ForeColor = System.Drawing.Color.Black;
            this.switchBtn.Location = new System.Drawing.Point(662, 67);
            this.switchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.switchBtn.Name = "switchBtn";
            this.switchBtn.Size = new System.Drawing.Size(196, 52);
            this.switchBtn.TabIndex = 0;
            this.switchBtn.Text = "Start/Stop";
            this.switchBtn.UseVisualStyleBackColor = false;
            this.switchBtn.Click += new System.EventHandler(this.switchBtn_Click);
            // 
            // t1LabelY
            // 
            this.t1LabelY.AutoSize = true;
            this.t1LabelY.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.t1LabelY.ForeColor = System.Drawing.Color.White;
            this.t1LabelY.Location = new System.Drawing.Point(397, 91);
            this.t1LabelY.Name = "t1LabelY";
            this.t1LabelY.Size = new System.Drawing.Size(40, 30);
            this.t1LabelY.TabIndex = 47;
            this.t1LabelY.Text = "t +";
            this.t1LabelY.Visible = false;
            // 
            // bracketR
            // 
            this.bracketR.AutoSize = true;
            this.bracketR.Font = new System.Drawing.Font("Segoe UI", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bracketR.ForeColor = System.Drawing.Color.White;
            this.bracketR.Location = new System.Drawing.Point(578, 26);
            this.bracketR.Name = "bracketR";
            this.bracketR.Size = new System.Drawing.Size(69, 106);
            this.bracketR.TabIndex = 51;
            this.bracketR.Text = ")";
            this.bracketR.Visible = false;
            // 
            // dimensionSwitch
            // 
            this.dimensionSwitch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(190)))));
            this.dimensionSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dimensionSwitch.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dimensionSwitch.ForeColor = System.Drawing.Color.Black;
            this.dimensionSwitch.Location = new System.Drawing.Point(12, 11);
            this.dimensionSwitch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dimensionSwitch.Name = "dimensionSwitch";
            this.dimensionSwitch.Size = new System.Drawing.Size(170, 154);
            this.dimensionSwitch.TabIndex = 32;
            this.dimensionSwitch.Text = "1D";
            this.dimensionSwitch.UseVisualStyleBackColor = false;
            this.dimensionSwitch.Click += new System.EventHandler(this.dimensionSwitch_Click);
            // 
            // varAccTimer
            // 
            this.varAccTimer.Interval = 20;
            this.varAccTimer.Tick += new System.EventHandler(this.varAccTimer_Tick);
            // 
            // assumptions
            // 
            this.assumptions.AutoSize = true;
            this.assumptions.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.assumptions.ForeColor = System.Drawing.Color.White;
            this.assumptions.Location = new System.Drawing.Point(188, 11);
            this.assumptions.Name = "assumptions";
            this.assumptions.Size = new System.Drawing.Size(882, 275);
            this.assumptions.TabIndex = 35;
            this.assumptions.Text = resources.GetString("assumptions.Text");
            this.assumptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.assumptions.Visible = false;
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.questionLabel.ForeColor = System.Drawing.Color.White;
            this.questionLabel.Location = new System.Drawing.Point(188, 35);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(88, 25);
            this.questionLabel.TabIndex = 37;
            this.questionLabel.Text = "Question\r\n";
            this.questionLabel.Visible = false;
            // 
            // varAccSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(1653, 650);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.assumptions);
            this.Controls.Add(this.statsPanel);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.dimensionSwitch);
            this.Name = "varAccSim";
            this.Text = "Variable Acceleration Sim";
            this.Load += new System.EventHandler(this.varAccSim_Load);
            this.statsPanel.ResumeLayout(false);
            this.statsPanel.PerformLayout();
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ansBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y1Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x3Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y3Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y0Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x2Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x1Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y2Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x0Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel statsPanel;
        private System.Windows.Forms.Label dispTxt;
        private System.Windows.Forms.Label timeTxt;
        private System.Windows.Forms.Label accEqnTxt;
        private System.Windows.Forms.Label Stats;
        private System.Windows.Forms.Label speedTxt;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.NumericUpDown x0Box;
        private System.Windows.Forms.NumericUpDown x2Box;
        private System.Windows.Forms.NumericUpDown x1Box;
        private System.Windows.Forms.NumericUpDown x3Box;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label dispLabel;
        private System.Windows.Forms.Button switchBtn;
        private System.Windows.Forms.Label t2LabelX;
        private System.Windows.Forms.Label t1LabelX;
        private System.Windows.Forms.Label t0LabelX;
        private System.Windows.Forms.Label t3LabelX;
        private System.Windows.Forms.Label velEqnTxt;
        private System.Windows.Forms.Label accTxt;
        private System.Windows.Forms.Button dimensionSwitch;
        private System.Windows.Forms.Timer varAccTimer;
        private System.Windows.Forms.NumericUpDown y3Box;
        private System.Windows.Forms.Label t3LabelY;
        private System.Windows.Forms.Label t2LabelY;
        private System.Windows.Forms.NumericUpDown y2Box;
        private System.Windows.Forms.NumericUpDown y1Box;
        private System.Windows.Forms.Label t1LabelY;
        private System.Windows.Forms.Label t0LabelY;
        private System.Windows.Forms.NumericUpDown y0Box;
        private System.Windows.Forms.Label bracketL;
        private System.Windows.Forms.Label bracketR;
        private System.Windows.Forms.Label accEqnYTxt;
        private System.Windows.Forms.Label velEqnYTxt;
        private System.Windows.Forms.Label assumptions;
        private System.Windows.Forms.CheckBox learnBox;
        private System.Windows.Forms.Label dispUnitLabel;
        private System.Windows.Forms.Button testMode;
        private System.Windows.Forms.Button generateQuestion;
        private System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.Label correctLabel;
        private System.Windows.Forms.Label ansUnitsLabel;
        private System.Windows.Forms.Label ansLabel;
        private System.Windows.Forms.NumericUpDown ansBox;
        private System.Windows.Forms.Label questionLabel;
    }
}