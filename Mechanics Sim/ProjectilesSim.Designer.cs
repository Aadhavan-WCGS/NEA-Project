
namespace Mechanics_Sim
{
    partial class ProjectilesSim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectilesSim));
            this.timeTxt = new System.Windows.Forms.Label();
            this.rangeTxt = new System.Windows.Forms.Label();
            this.Stats = new System.Windows.Forms.Label();
            this.speedTxt = new System.Windows.Forms.Label();
            this.accTxt = new System.Windows.Forms.Label();
            this.maxhTxt = new System.Windows.Forms.Label();
            this.tofTxt = new System.Windows.Forms.Label();
            this.uTxt = new System.Windows.Forms.Label();
            this.aopTxt = new System.Windows.Forms.Label();
            this.switchBtn = new System.Windows.Forms.Button();
            this.projTimer = new System.Windows.Forms.Timer(this.components);
            this.controlPanel = new System.Windows.Forms.Panel();
            this.coverPanel = new System.Windows.Forms.Panel();
            this.ansLabel = new System.Windows.Forms.Label();
            this.correctLabel = new System.Windows.Forms.Label();
            this.ansBox = new System.Windows.Forms.NumericUpDown();
            this.ansUnitsLabel = new System.Windows.Forms.Label();
            this.checkBtn = new System.Windows.Forms.Button();
            this.generateQuestion = new System.Windows.Forms.Button();
            this.testMode = new System.Windows.Forms.Button();
            this.uBox = new System.Windows.Forms.NumericUpDown();
            this.angleBox = new System.Windows.Forms.NumericUpDown();
            this.degreeLabel = new System.Windows.Forms.Label();
            this.learnBox = new System.Windows.Forms.CheckBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.speedLabel = new System.Windows.Forms.Label();
            this.statsPanel = new System.Windows.Forms.Panel();
            this.assumptions = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.controlPanel.SuspendLayout();
            this.coverPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ansBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleBox)).BeginInit();
            this.statsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeTxt
            // 
            this.timeTxt.AutoSize = true;
            this.timeTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeTxt.ForeColor = System.Drawing.Color.White;
            this.timeTxt.Location = new System.Drawing.Point(29, 154);
            this.timeTxt.Name = "timeTxt";
            this.timeTxt.Size = new System.Drawing.Size(132, 25);
            this.timeTxt.TabIndex = 19;
            this.timeTxt.Text = "Time elapsed: ";
            // 
            // rangeTxt
            // 
            this.rangeTxt.AutoSize = true;
            this.rangeTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rangeTxt.ForeColor = System.Drawing.Color.White;
            this.rangeTxt.Location = new System.Drawing.Point(87, 104);
            this.rangeTxt.Name = "rangeTxt";
            this.rangeTxt.Size = new System.Drawing.Size(74, 25);
            this.rangeTxt.TabIndex = 18;
            this.rangeTxt.Text = "Range: ";
            this.rangeTxt.Click += new System.EventHandler(this.rangeTxt_Click);
            // 
            // Stats
            // 
            this.Stats.AutoSize = true;
            this.Stats.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Stats.ForeColor = System.Drawing.Color.White;
            this.Stats.Location = new System.Drawing.Point(170, 6);
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
            this.speedTxt.Location = new System.Drawing.Point(88, 32);
            this.speedTxt.Name = "speedTxt";
            this.speedTxt.Size = new System.Drawing.Size(73, 25);
            this.speedTxt.TabIndex = 15;
            this.speedTxt.Text = "Speed: ";
            // 
            // accTxt
            // 
            this.accTxt.AutoSize = true;
            this.accTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.accTxt.ForeColor = System.Drawing.Color.White;
            this.accTxt.Location = new System.Drawing.Point(35, 57);
            this.accTxt.Name = "accTxt";
            this.accTxt.Size = new System.Drawing.Size(126, 25);
            this.accTxt.TabIndex = 17;
            this.accTxt.Text = "Acceleration: ";
            // 
            // maxhTxt
            // 
            this.maxhTxt.AutoSize = true;
            this.maxhTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maxhTxt.ForeColor = System.Drawing.Color.White;
            this.maxhTxt.Location = new System.Drawing.Point(43, 82);
            this.maxhTxt.Name = "maxhTxt";
            this.maxhTxt.Size = new System.Drawing.Size(116, 25);
            this.maxhTxt.TabIndex = 20;
            this.maxhTxt.Text = "Max height: ";
            // 
            // tofTxt
            // 
            this.tofTxt.AutoSize = true;
            this.tofTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tofTxt.ForeColor = System.Drawing.Color.White;
            this.tofTxt.Location = new System.Drawing.Point(25, 129);
            this.tofTxt.Name = "tofTxt";
            this.tofTxt.Size = new System.Drawing.Size(133, 25);
            this.tofTxt.TabIndex = 21;
            this.tofTxt.Text = "Time of flight: ";
            // 
            // uTxt
            // 
            this.uTxt.AutoSize = true;
            this.uTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uTxt.ForeColor = System.Drawing.Color.White;
            this.uTxt.Location = new System.Drawing.Point(79, 53);
            this.uTxt.Name = "uTxt";
            this.uTxt.Size = new System.Drawing.Size(123, 25);
            this.uTxt.TabIndex = 24;
            this.uTxt.Text = "Initial speed: ";
            // 
            // aopTxt
            // 
            this.aopTxt.AutoSize = true;
            this.aopTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aopTxt.ForeColor = System.Drawing.Color.White;
            this.aopTxt.Location = new System.Drawing.Point(19, 28);
            this.aopTxt.Name = "aopTxt";
            this.aopTxt.Size = new System.Drawing.Size(183, 25);
            this.aopTxt.TabIndex = 25;
            this.aopTxt.Text = "Angle of projection: ";
            // 
            // switchBtn
            // 
            this.switchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(190)))));
            this.switchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.switchBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.switchBtn.ForeColor = System.Drawing.Color.Black;
            this.switchBtn.Location = new System.Drawing.Point(381, 26);
            this.switchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.switchBtn.Name = "switchBtn";
            this.switchBtn.Size = new System.Drawing.Size(230, 52);
            this.switchBtn.TabIndex = 26;
            this.switchBtn.Text = "Start/Stop";
            this.switchBtn.UseVisualStyleBackColor = false;
            this.switchBtn.Click += new System.EventHandler(this.Switch_Click);
            // 
            // projTimer
            // 
            this.projTimer.Interval = 20;
            this.projTimer.Tick += new System.EventHandler(this.projTimer_Tick);
            // 
            // controlPanel
            // 
            this.controlPanel.AutoScroll = true;
            this.controlPanel.AutoSize = true;
            this.controlPanel.Controls.Add(this.coverPanel);
            this.controlPanel.Controls.Add(this.checkBtn);
            this.controlPanel.Controls.Add(this.generateQuestion);
            this.controlPanel.Controls.Add(this.testMode);
            this.controlPanel.Controls.Add(this.uBox);
            this.controlPanel.Controls.Add(this.angleBox);
            this.controlPanel.Controls.Add(this.degreeLabel);
            this.controlPanel.Controls.Add(this.learnBox);
            this.controlPanel.Controls.Add(this.exitBtn);
            this.controlPanel.Controls.Add(this.resetBtn);
            this.controlPanel.Controls.Add(this.switchBtn);
            this.controlPanel.Controls.Add(this.aopTxt);
            this.controlPanel.Controls.Add(this.uTxt);
            this.controlPanel.Controls.Add(this.speedLabel);
            this.controlPanel.Location = new System.Drawing.Point(2, 639);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(1508, 113);
            this.controlPanel.TabIndex = 27;
            // 
            // coverPanel
            // 
            this.coverPanel.Controls.Add(this.ansLabel);
            this.coverPanel.Controls.Add(this.correctLabel);
            this.coverPanel.Controls.Add(this.ansBox);
            this.coverPanel.Controls.Add(this.ansUnitsLabel);
            this.coverPanel.ForeColor = System.Drawing.Color.Black;
            this.coverPanel.Location = new System.Drawing.Point(4, 28);
            this.coverPanel.Name = "coverPanel";
            this.coverPanel.Size = new System.Drawing.Size(371, 52);
            this.coverPanel.TabIndex = 72;
            this.coverPanel.Visible = false;
            // 
            // ansLabel
            // 
            this.ansLabel.AutoSize = true;
            this.ansLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ansLabel.ForeColor = System.Drawing.Color.White;
            this.ansLabel.Location = new System.Drawing.Point(3, 14);
            this.ansLabel.Name = "ansLabel";
            this.ansLabel.Size = new System.Drawing.Size(78, 25);
            this.ansLabel.TabIndex = 37;
            this.ansLabel.Text = "Answer:";
            // 
            // correctLabel
            // 
            this.correctLabel.AutoSize = true;
            this.correctLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.correctLabel.ForeColor = System.Drawing.Color.White;
            this.correctLabel.Location = new System.Drawing.Point(205, 14);
            this.correctLabel.Name = "correctLabel";
            this.correctLabel.Size = new System.Drawing.Size(78, 25);
            this.correctLabel.TabIndex = 39;
            this.correctLabel.Text = "Answer:";
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
            this.ansBox.TabIndex = 36;
            // 
            // ansUnitsLabel
            // 
            this.ansUnitsLabel.AutoSize = true;
            this.ansUnitsLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ansUnitsLabel.ForeColor = System.Drawing.Color.White;
            this.ansUnitsLabel.Location = new System.Drawing.Point(146, 14);
            this.ansUnitsLabel.Name = "ansUnitsLabel";
            this.ansUnitsLabel.Size = new System.Drawing.Size(53, 25);
            this.ansUnitsLabel.TabIndex = 38;
            this.ansUnitsLabel.Text = "units";
            // 
            // checkBtn
            // 
            this.checkBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(190)))));
            this.checkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBtn.ForeColor = System.Drawing.Color.Black;
            this.checkBtn.Location = new System.Drawing.Point(381, 26);
            this.checkBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(230, 52);
            this.checkBtn.TabIndex = 37;
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
            this.generateQuestion.Location = new System.Drawing.Point(617, 25);
            this.generateQuestion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generateQuestion.Name = "generateQuestion";
            this.generateQuestion.Size = new System.Drawing.Size(230, 52);
            this.generateQuestion.TabIndex = 36;
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
            this.testMode.Location = new System.Drawing.Point(853, 26);
            this.testMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.testMode.Name = "testMode";
            this.testMode.Size = new System.Drawing.Size(230, 52);
            this.testMode.TabIndex = 38;
            this.testMode.Text = "Test yourself";
            this.testMode.UseVisualStyleBackColor = false;
            this.testMode.Click += new System.EventHandler(this.testMode_Click);
            // 
            // uBox
            // 
            this.uBox.DecimalPlaces = 2;
            this.uBox.Location = new System.Drawing.Point(208, 57);
            this.uBox.Name = "uBox";
            this.uBox.Size = new System.Drawing.Size(53, 23);
            this.uBox.TabIndex = 32;
            // 
            // angleBox
            // 
            this.angleBox.DecimalPlaces = 2;
            this.angleBox.Location = new System.Drawing.Point(208, 29);
            this.angleBox.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.angleBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.angleBox.Name = "angleBox";
            this.angleBox.Size = new System.Drawing.Size(53, 23);
            this.angleBox.TabIndex = 30;
            this.angleBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // degreeLabel
            // 
            this.degreeLabel.AutoSize = true;
            this.degreeLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.degreeLabel.ForeColor = System.Drawing.Color.White;
            this.degreeLabel.Location = new System.Drawing.Point(258, 23);
            this.degreeLabel.Name = "degreeLabel";
            this.degreeLabel.Size = new System.Drawing.Size(19, 25);
            this.degreeLabel.TabIndex = 36;
            this.degreeLabel.Text = "°";
            // 
            // learnBox
            // 
            this.learnBox.AutoSize = true;
            this.learnBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.learnBox.ForeColor = System.Drawing.Color.White;
            this.learnBox.Location = new System.Drawing.Point(1325, 41);
            this.learnBox.Name = "learnBox";
            this.learnBox.Size = new System.Drawing.Size(127, 29);
            this.learnBox.TabIndex = 35;
            this.learnBox.Text = "Learn more";
            this.learnBox.UseVisualStyleBackColor = true;
            this.learnBox.CheckedChanged += new System.EventHandler(this.learnBox_CheckedChanged);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(190)))));
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitBtn.ForeColor = System.Drawing.Color.Black;
            this.exitBtn.Location = new System.Drawing.Point(1089, 26);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(230, 52);
            this.exitBtn.TabIndex = 31;
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
            this.resetBtn.Location = new System.Drawing.Point(617, 26);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(230, 52);
            this.resetBtn.TabIndex = 30;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.speedLabel.ForeColor = System.Drawing.Color.White;
            this.speedLabel.Location = new System.Drawing.Point(258, 55);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(51, 25);
            this.speedLabel.TabIndex = 37;
            this.speedLabel.Text = "ms¯¹";
            // 
            // statsPanel
            // 
            this.statsPanel.Controls.Add(this.tofTxt);
            this.statsPanel.Controls.Add(this.maxhTxt);
            this.statsPanel.Controls.Add(this.timeTxt);
            this.statsPanel.Controls.Add(this.rangeTxt);
            this.statsPanel.Controls.Add(this.accTxt);
            this.statsPanel.Controls.Add(this.Stats);
            this.statsPanel.Controls.Add(this.speedTxt);
            this.statsPanel.Location = new System.Drawing.Point(1089, 12);
            this.statsPanel.Name = "statsPanel";
            this.statsPanel.Size = new System.Drawing.Size(374, 242);
            this.statsPanel.TabIndex = 29;
            // 
            // assumptions
            // 
            this.assumptions.AutoSize = true;
            this.assumptions.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.assumptions.ForeColor = System.Drawing.Color.White;
            this.assumptions.Location = new System.Drawing.Point(12, 9);
            this.assumptions.Name = "assumptions";
            this.assumptions.Size = new System.Drawing.Size(952, 300);
            this.assumptions.TabIndex = 34;
            this.assumptions.Text = resources.GetString("assumptions.Text");
            this.assumptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.assumptions.Visible = false;
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.questionLabel.ForeColor = System.Drawing.Color.White;
            this.questionLabel.Location = new System.Drawing.Point(12, 84);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(88, 25);
            this.questionLabel.TabIndex = 35;
            this.questionLabel.Text = "Question\r\n";
            this.questionLabel.Visible = false;
            // 
            // ProjectilesSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(1508, 764);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.statsPanel);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.assumptions);
            this.MaximizeBox = false;
            this.Name = "ProjectilesSim";
            this.Text = "Projectiles Simulator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.coverPanel.ResumeLayout(false);
            this.coverPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ansBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleBox)).EndInit();
            this.statsPanel.ResumeLayout(false);
            this.statsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeTxt;
        private System.Windows.Forms.Label rangeTxt;
        private System.Windows.Forms.Label Stats;
        private System.Windows.Forms.Label speedTxt;
        private System.Windows.Forms.Label accTxt;
        private System.Windows.Forms.Label maxhTxt;
        private System.Windows.Forms.Label tofTxt;
        private System.Windows.Forms.Label uTxt;
        private System.Windows.Forms.Label aopTxt;
        private System.Windows.Forms.Button switchBtn;
        private System.Windows.Forms.Timer projTimer;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Panel statsPanel;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.NumericUpDown angleBox;
        private System.Windows.Forms.NumericUpDown uBox;
        private System.Windows.Forms.Label assumptions;
        private System.Windows.Forms.CheckBox learnBox;
        private System.Windows.Forms.Label degreeLabel;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button testMode;
        private System.Windows.Forms.Button generateQuestion;
        private System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.NumericUpDown ansBox;
        private System.Windows.Forms.Label ansLabel;
        private System.Windows.Forms.Label ansUnitsLabel;
        private System.Windows.Forms.Label correctLabel;
        private System.Windows.Forms.Panel coverPanel;
    }
}