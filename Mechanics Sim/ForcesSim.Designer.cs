
namespace Mechanics_Sim
{
    partial class ForcesSim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForcesSim));
            this.switchBtn = new System.Windows.Forms.Button();
            this.forceTimer = new System.Windows.Forms.Timer(this.components);
            this.xforceLabel = new System.Windows.Forms.Label();
            this.speedTxt = new System.Windows.Forms.Label();
            this.yforceLabel = new System.Windows.Forms.Label();
            this.StatsTxt = new System.Windows.Forms.Label();
            this.massLabel = new System.Windows.Forms.Label();
            this.accTxt = new System.Windows.Forms.Label();
            this.rfTxt = new System.Windows.Forms.Label();
            this.timeTxt = new System.Windows.Forms.Label();
            this.statsPanel = new System.Windows.Forms.Panel();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.coverPanel = new System.Windows.Forms.Panel();
            this.ansLabel = new System.Windows.Forms.Label();
            this.ansUnitsLabel = new System.Windows.Forms.Label();
            this.correctLabel = new System.Windows.Forms.Label();
            this.ansBox = new System.Windows.Forms.NumericUpDown();
            this.generateQuestion = new System.Windows.Forms.Button();
            this.checkBtn = new System.Windows.Forms.Button();
            this.testMode = new System.Windows.Forms.Button();
            this.yfUnitLabel = new System.Windows.Forms.Label();
            this.xfUnitLabel = new System.Windows.Forms.Label();
            this.learnBox = new System.Windows.Forms.CheckBox();
            this.xfBox = new System.Windows.Forms.NumericUpDown();
            this.yfBox = new System.Windows.Forms.NumericUpDown();
            this.massBox = new System.Windows.Forms.NumericUpDown();
            this.exitBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.massUnitLabel = new System.Windows.Forms.Label();
            this.assumptions = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.statsPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.coverPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ansBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xfBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yfBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.massBox)).BeginInit();
            this.SuspendLayout();
            // 
            // switchBtn
            // 
            this.switchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(190)))));
            this.switchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.switchBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.switchBtn.ForeColor = System.Drawing.Color.Black;
            this.switchBtn.Location = new System.Drawing.Point(343, 51);
            this.switchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.switchBtn.Name = "switchBtn";
            this.switchBtn.Size = new System.Drawing.Size(196, 52);
            this.switchBtn.TabIndex = 0;
            this.switchBtn.Text = "Start/Stop";
            this.switchBtn.UseVisualStyleBackColor = false;
            this.switchBtn.Click += new System.EventHandler(this.Switch_Click);
            // 
            // forceTimer
            // 
            this.forceTimer.Interval = 20;
            this.forceTimer.Tick += new System.EventHandler(this.forceTimer_Tick);
            // 
            // xforceLabel
            // 
            this.xforceLabel.AutoSize = true;
            this.xforceLabel.ForeColor = System.Drawing.Color.White;
            this.xforceLabel.Location = new System.Drawing.Point(145, 59);
            this.xforceLabel.Name = "xforceLabel";
            this.xforceLabel.Size = new System.Drawing.Size(94, 15);
            this.xforceLabel.TabIndex = 2;
            this.xforceLabel.Text = "Horizontal Force";
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
            // yforceLabel
            // 
            this.yforceLabel.AutoSize = true;
            this.yforceLabel.ForeColor = System.Drawing.Color.White;
            this.yforceLabel.Location = new System.Drawing.Point(162, 88);
            this.yforceLabel.Name = "yforceLabel";
            this.yforceLabel.Size = new System.Drawing.Size(77, 15);
            this.yforceLabel.TabIndex = 7;
            this.yforceLabel.Text = "Vertical Force";
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
            // massLabel
            // 
            this.massLabel.AutoSize = true;
            this.massLabel.ForeColor = System.Drawing.Color.White;
            this.massLabel.Location = new System.Drawing.Point(6, 59);
            this.massLabel.Name = "massLabel";
            this.massLabel.Size = new System.Drawing.Size(37, 15);
            this.massLabel.TabIndex = 11;
            this.massLabel.Text = "Mass:";
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
            // rfTxt
            // 
            this.rfTxt.AutoSize = true;
            this.rfTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rfTxt.ForeColor = System.Drawing.Color.White;
            this.rfTxt.Location = new System.Drawing.Point(6, 81);
            this.rfTxt.Name = "rfTxt";
            this.rfTxt.Size = new System.Drawing.Size(149, 25);
            this.rfTxt.TabIndex = 13;
            this.rfTxt.Text = "Resultant Force: ";
            // 
            // timeTxt
            // 
            this.timeTxt.AutoSize = true;
            this.timeTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeTxt.ForeColor = System.Drawing.Color.White;
            this.timeTxt.Location = new System.Drawing.Point(23, 106);
            this.timeTxt.Name = "timeTxt";
            this.timeTxt.Size = new System.Drawing.Size(132, 25);
            this.timeTxt.TabIndex = 14;
            this.timeTxt.Text = "Time Elapsed: ";
            // 
            // statsPanel
            // 
            this.statsPanel.Controls.Add(this.timeTxt);
            this.statsPanel.Controls.Add(this.rfTxt);
            this.statsPanel.Controls.Add(this.accTxt);
            this.statsPanel.Controls.Add(this.StatsTxt);
            this.statsPanel.Controls.Add(this.speedTxt);
            this.statsPanel.Location = new System.Drawing.Point(970, 12);
            this.statsPanel.Name = "statsPanel";
            this.statsPanel.Size = new System.Drawing.Size(331, 156);
            this.statsPanel.TabIndex = 15;
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.coverPanel);
            this.controlPanel.Controls.Add(this.generateQuestion);
            this.controlPanel.Controls.Add(this.checkBtn);
            this.controlPanel.Controls.Add(this.testMode);
            this.controlPanel.Controls.Add(this.yfUnitLabel);
            this.controlPanel.Controls.Add(this.xfUnitLabel);
            this.controlPanel.Controls.Add(this.learnBox);
            this.controlPanel.Controls.Add(this.xfBox);
            this.controlPanel.Controls.Add(this.yfBox);
            this.controlPanel.Controls.Add(this.massBox);
            this.controlPanel.Controls.Add(this.exitBtn);
            this.controlPanel.Controls.Add(this.resetBtn);
            this.controlPanel.Controls.Add(this.massLabel);
            this.controlPanel.Controls.Add(this.yforceLabel);
            this.controlPanel.Controls.Add(this.xforceLabel);
            this.controlPanel.Controls.Add(this.switchBtn);
            this.controlPanel.Controls.Add(this.massUnitLabel);
            this.controlPanel.Location = new System.Drawing.Point(3, 599);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(1307, 138);
            this.controlPanel.TabIndex = 16;
            // 
            // coverPanel
            // 
            this.coverPanel.Controls.Add(this.ansLabel);
            this.coverPanel.Controls.Add(this.ansUnitsLabel);
            this.coverPanel.Controls.Add(this.correctLabel);
            this.coverPanel.Controls.Add(this.ansBox);
            this.coverPanel.ForeColor = System.Drawing.Color.Black;
            this.coverPanel.Location = new System.Drawing.Point(3, 42);
            this.coverPanel.Name = "coverPanel";
            this.coverPanel.Size = new System.Drawing.Size(334, 93);
            this.coverPanel.TabIndex = 71;
            this.coverPanel.Visible = false;
            // 
            // ansLabel
            // 
            this.ansLabel.AutoSize = true;
            this.ansLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ansLabel.ForeColor = System.Drawing.Color.White;
            this.ansLabel.Location = new System.Drawing.Point(24, 24);
            this.ansLabel.Name = "ansLabel";
            this.ansLabel.Size = new System.Drawing.Size(78, 25);
            this.ansLabel.TabIndex = 41;
            this.ansLabel.Text = "Answer:";
            // 
            // ansUnitsLabel
            // 
            this.ansUnitsLabel.AutoSize = true;
            this.ansUnitsLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ansUnitsLabel.ForeColor = System.Drawing.Color.White;
            this.ansUnitsLabel.Location = new System.Drawing.Point(167, 24);
            this.ansUnitsLabel.Name = "ansUnitsLabel";
            this.ansUnitsLabel.Size = new System.Drawing.Size(53, 25);
            this.ansUnitsLabel.TabIndex = 42;
            this.ansUnitsLabel.Text = "units";
            // 
            // correctLabel
            // 
            this.correctLabel.AutoSize = true;
            this.correctLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.correctLabel.ForeColor = System.Drawing.Color.White;
            this.correctLabel.Location = new System.Drawing.Point(226, 24);
            this.correctLabel.Name = "correctLabel";
            this.correctLabel.Size = new System.Drawing.Size(78, 25);
            this.correctLabel.TabIndex = 43;
            this.correctLabel.Text = "Answer:";
            // 
            // ansBox
            // 
            this.ansBox.DecimalPlaces = 2;
            this.ansBox.Location = new System.Drawing.Point(108, 26);
            this.ansBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ansBox.Name = "ansBox";
            this.ansBox.Size = new System.Drawing.Size(53, 23);
            this.ansBox.TabIndex = 40;
            // 
            // generateQuestion
            // 
            this.generateQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(190)))));
            this.generateQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.generateQuestion.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.generateQuestion.ForeColor = System.Drawing.Color.Black;
            this.generateQuestion.Location = new System.Drawing.Point(545, 51);
            this.generateQuestion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generateQuestion.Name = "generateQuestion";
            this.generateQuestion.Size = new System.Drawing.Size(196, 52);
            this.generateQuestion.TabIndex = 37;
            this.generateQuestion.Text = "Next Question";
            this.generateQuestion.UseMnemonic = false;
            this.generateQuestion.UseVisualStyleBackColor = false;
            this.generateQuestion.Visible = false;
            this.generateQuestion.Click += new System.EventHandler(this.generateQuestion_Click);
            // 
            // checkBtn
            // 
            this.checkBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(190)))));
            this.checkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBtn.ForeColor = System.Drawing.Color.Black;
            this.checkBtn.Location = new System.Drawing.Point(343, 51);
            this.checkBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(196, 52);
            this.checkBtn.TabIndex = 38;
            this.checkBtn.Text = "Check Answer";
            this.checkBtn.UseMnemonic = false;
            this.checkBtn.UseVisualStyleBackColor = false;
            this.checkBtn.Visible = false;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // testMode
            // 
            this.testMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(190)))));
            this.testMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.testMode.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.testMode.ForeColor = System.Drawing.Color.Black;
            this.testMode.Location = new System.Drawing.Point(747, 51);
            this.testMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.testMode.Name = "testMode";
            this.testMode.Size = new System.Drawing.Size(220, 52);
            this.testMode.TabIndex = 57;
            this.testMode.Text = "Test yourself";
            this.testMode.UseVisualStyleBackColor = false;
            this.testMode.Click += new System.EventHandler(this.testMode_Click);
            // 
            // yfUnitLabel
            // 
            this.yfUnitLabel.AutoSize = true;
            this.yfUnitLabel.ForeColor = System.Drawing.Color.White;
            this.yfUnitLabel.Location = new System.Drawing.Point(321, 88);
            this.yfUnitLabel.Name = "yfUnitLabel";
            this.yfUnitLabel.Size = new System.Drawing.Size(16, 15);
            this.yfUnitLabel.TabIndex = 56;
            this.yfUnitLabel.Text = "N";
            // 
            // xfUnitLabel
            // 
            this.xfUnitLabel.AutoSize = true;
            this.xfUnitLabel.ForeColor = System.Drawing.Color.White;
            this.xfUnitLabel.Location = new System.Drawing.Point(321, 59);
            this.xfUnitLabel.Name = "xfUnitLabel";
            this.xfUnitLabel.Size = new System.Drawing.Size(16, 15);
            this.xfUnitLabel.TabIndex = 55;
            this.xfUnitLabel.Text = "N";
            // 
            // learnBox
            // 
            this.learnBox.AutoSize = true;
            this.learnBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.learnBox.ForeColor = System.Drawing.Color.White;
            this.learnBox.Location = new System.Drawing.Point(1175, 57);
            this.learnBox.Name = "learnBox";
            this.learnBox.Size = new System.Drawing.Size(127, 29);
            this.learnBox.TabIndex = 53;
            this.learnBox.Text = "Learn more";
            this.learnBox.UseVisualStyleBackColor = true;
            this.learnBox.CheckedChanged += new System.EventHandler(this.learnBox_CheckedChanged);
            // 
            // xfBox
            // 
            this.xfBox.DecimalPlaces = 2;
            this.xfBox.Location = new System.Drawing.Point(259, 57);
            this.xfBox.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.xfBox.Name = "xfBox";
            this.xfBox.Size = new System.Drawing.Size(56, 23);
            this.xfBox.TabIndex = 36;
            // 
            // yfBox
            // 
            this.yfBox.DecimalPlaces = 2;
            this.yfBox.Location = new System.Drawing.Point(259, 86);
            this.yfBox.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.yfBox.Name = "yfBox";
            this.yfBox.Size = new System.Drawing.Size(56, 23);
            this.yfBox.TabIndex = 35;
            // 
            // massBox
            // 
            this.massBox.DecimalPlaces = 2;
            this.massBox.Location = new System.Drawing.Point(49, 57);
            this.massBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.massBox.Name = "massBox";
            this.massBox.Size = new System.Drawing.Size(56, 23);
            this.massBox.TabIndex = 34;
            this.massBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(190)))));
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitBtn.ForeColor = System.Drawing.Color.Black;
            this.exitBtn.Location = new System.Drawing.Point(973, 51);
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
            this.resetBtn.Location = new System.Drawing.Point(545, 51);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(196, 52);
            this.resetBtn.TabIndex = 12;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // massUnitLabel
            // 
            this.massUnitLabel.AutoSize = true;
            this.massUnitLabel.ForeColor = System.Drawing.Color.White;
            this.massUnitLabel.Location = new System.Drawing.Point(111, 59);
            this.massUnitLabel.Name = "massUnitLabel";
            this.massUnitLabel.Size = new System.Drawing.Size(21, 15);
            this.massUnitLabel.TabIndex = 54;
            this.massUnitLabel.Text = "Kg";
            // 
            // assumptions
            // 
            this.assumptions.AutoSize = true;
            this.assumptions.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.assumptions.ForeColor = System.Drawing.Color.White;
            this.assumptions.Location = new System.Drawing.Point(12, 9);
            this.assumptions.Name = "assumptions";
            this.assumptions.Size = new System.Drawing.Size(914, 175);
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
            this.questionLabel.Location = new System.Drawing.Point(12, 34);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(88, 25);
            this.questionLabel.TabIndex = 36;
            this.questionLabel.Text = "Question\r\n";
            this.questionLabel.Visible = false;
            // 
            // ForcesSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(1313, 749);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.assumptions);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.statsPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimizeBox = false;
            this.Name = "ForcesSim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Forces Simulator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statsPanel.ResumeLayout(false);
            this.statsPanel.PerformLayout();
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.coverPanel.ResumeLayout(false);
            this.coverPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ansBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xfBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yfBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.massBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button switchBtn;
        public System.Windows.Forms.Timer forceTimer;
        private System.Windows.Forms.Label xforceLabel;
        private System.Windows.Forms.Label speedTxt;
        private System.Windows.Forms.Label yforceLabel;
        private System.Windows.Forms.Label StatsTxt;
        private System.Windows.Forms.Label massLabel;
        private System.Windows.Forms.Label accTxt;
        private System.Windows.Forms.Label rfTxt;
        private System.Windows.Forms.Label timeTxt;
        private System.Windows.Forms.Panel statsPanel;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.NumericUpDown xfBox;
        private System.Windows.Forms.NumericUpDown yfBox;
        private System.Windows.Forms.NumericUpDown massBox;
        private System.Windows.Forms.CheckBox learnBox;
        private System.Windows.Forms.Label assumptions;
        private System.Windows.Forms.Label yfUnitLabel;
        private System.Windows.Forms.Label xfUnitLabel;
        private System.Windows.Forms.Label massUnitLabel;
        private System.Windows.Forms.Button testMode;
        private System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.Button generateQuestion;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label correctLabel;
        private System.Windows.Forms.Label ansUnitsLabel;
        private System.Windows.Forms.Label ansLabel;
        private System.Windows.Forms.NumericUpDown ansBox;
        private System.Windows.Forms.Panel coverPanel;
    }
}