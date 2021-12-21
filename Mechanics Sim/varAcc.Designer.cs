
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
            this.statsPanel = new System.Windows.Forms.Panel();
            this.accTxt = new System.Windows.Forms.Label();
            this.velEqnTxt = new System.Windows.Forms.Label();
            this.dispTxt = new System.Windows.Forms.Label();
            this.timeTxt = new System.Windows.Forms.Label();
            this.accEqnTxt = new System.Windows.Forms.Label();
            this.Stats = new System.Windows.Forms.Label();
            this.speedTxt = new System.Windows.Forms.Label();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.x3Box = new System.Windows.Forms.NumericUpDown();
            this.t3Label = new System.Windows.Forms.Label();
            this.t2Label = new System.Windows.Forms.Label();
            this.x2Box = new System.Windows.Forms.NumericUpDown();
            this.x1Box = new System.Windows.Forms.NumericUpDown();
            this.t1Label = new System.Windows.Forms.Label();
            this.t0Label = new System.Windows.Forms.Label();
            this.x0Box = new System.Windows.Forms.NumericUpDown();
            this.exitBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.dispLabel = new System.Windows.Forms.Label();
            this.switchBtn = new System.Windows.Forms.Button();
            this.dimensionSwitch = new System.Windows.Forms.Button();
            this.varAccTimer = new System.Windows.Forms.Timer(this.components);
            this.statsPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.x3Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x2Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x1Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x0Box)).BeginInit();
            this.SuspendLayout();
            // 
            // statsPanel
            // 
            this.statsPanel.Controls.Add(this.accTxt);
            this.statsPanel.Controls.Add(this.velEqnTxt);
            this.statsPanel.Controls.Add(this.dispTxt);
            this.statsPanel.Controls.Add(this.timeTxt);
            this.statsPanel.Controls.Add(this.accEqnTxt);
            this.statsPanel.Controls.Add(this.Stats);
            this.statsPanel.Controls.Add(this.speedTxt);
            this.statsPanel.Location = new System.Drawing.Point(600, 11);
            this.statsPanel.Name = "statsPanel";
            this.statsPanel.Size = new System.Drawing.Size(556, 262);
            this.statsPanel.TabIndex = 30;
            // 
            // accTxt
            // 
            this.accTxt.AutoSize = true;
            this.accTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.accTxt.ForeColor = System.Drawing.Color.White;
            this.accTxt.Location = new System.Drawing.Point(49, 190);
            this.accTxt.Name = "accTxt";
            this.accTxt.Size = new System.Drawing.Size(126, 25);
            this.accTxt.TabIndex = 22;
            this.accTxt.Text = "Acceleration: ";
            // 
            // velEqnTxt
            // 
            this.velEqnTxt.AutoSize = true;
            this.velEqnTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.velEqnTxt.ForeColor = System.Drawing.Color.White;
            this.velEqnTxt.Location = new System.Drawing.Point(34, 32);
            this.velEqnTxt.Name = "velEqnTxt";
            this.velEqnTxt.Size = new System.Drawing.Size(172, 25);
            this.velEqnTxt.TabIndex = 21;
            this.velEqnTxt.Text = "Velocity equation:  ";
            // 
            // dispTxt
            // 
            this.dispTxt.AutoSize = true;
            this.dispTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dispTxt.ForeColor = System.Drawing.Color.White;
            this.dispTxt.Location = new System.Drawing.Point(49, 165);
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
            this.timeTxt.Location = new System.Drawing.Point(52, 215);
            this.timeTxt.Name = "timeTxt";
            this.timeTxt.Size = new System.Drawing.Size(132, 25);
            this.timeTxt.TabIndex = 19;
            this.timeTxt.Text = "Time elapsed: ";
            // 
            // accEqnTxt
            // 
            this.accEqnTxt.AutoSize = true;
            this.accEqnTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.accEqnTxt.ForeColor = System.Drawing.Color.White;
            this.accEqnTxt.Location = new System.Drawing.Point(0, 57);
            this.accEqnTxt.Name = "accEqnTxt";
            this.accEqnTxt.Size = new System.Drawing.Size(206, 25);
            this.accEqnTxt.TabIndex = 17;
            this.accEqnTxt.Text = "Acceleration equation: ";
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
            this.speedTxt.Location = new System.Drawing.Point(111, 140);
            this.speedTxt.Name = "speedTxt";
            this.speedTxt.Size = new System.Drawing.Size(73, 25);
            this.speedTxt.TabIndex = 15;
            this.speedTxt.Text = "Speed: ";
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.x3Box);
            this.controlPanel.Controls.Add(this.t3Label);
            this.controlPanel.Controls.Add(this.t2Label);
            this.controlPanel.Controls.Add(this.x2Box);
            this.controlPanel.Controls.Add(this.x1Box);
            this.controlPanel.Controls.Add(this.t1Label);
            this.controlPanel.Controls.Add(this.t0Label);
            this.controlPanel.Controls.Add(this.x0Box);
            this.controlPanel.Controls.Add(this.exitBtn);
            this.controlPanel.Controls.Add(this.resetBtn);
            this.controlPanel.Controls.Add(this.dispLabel);
            this.controlPanel.Controls.Add(this.switchBtn);
            this.controlPanel.Location = new System.Drawing.Point(12, 471);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(1126, 138);
            this.controlPanel.TabIndex = 31;
            // 
            // x3Box
            // 
            this.x3Box.DecimalPlaces = 2;
            this.x3Box.Location = new System.Drawing.Point(404, 62);
            this.x3Box.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.x3Box.Name = "x3Box";
            this.x3Box.Size = new System.Drawing.Size(43, 23);
            this.x3Box.TabIndex = 34;
            // 
            // t3Label
            // 
            this.t3Label.AutoSize = true;
            this.t3Label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.t3Label.ForeColor = System.Drawing.Color.White;
            this.t3Label.Location = new System.Drawing.Point(444, 56);
            this.t3Label.Name = "t3Label";
            this.t3Label.Size = new System.Drawing.Size(28, 30);
            this.t3Label.TabIndex = 40;
            this.t3Label.Text = "t³";
            // 
            // t2Label
            // 
            this.t2Label.AutoSize = true;
            this.t2Label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.t2Label.ForeColor = System.Drawing.Color.White;
            this.t2Label.Location = new System.Drawing.Point(362, 56);
            this.t2Label.Name = "t2Label";
            this.t2Label.Size = new System.Drawing.Size(48, 30);
            this.t2Label.TabIndex = 39;
            this.t2Label.Text = "t² +";
            // 
            // x2Box
            // 
            this.x2Box.DecimalPlaces = 2;
            this.x2Box.Location = new System.Drawing.Point(309, 62);
            this.x2Box.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.x2Box.Name = "x2Box";
            this.x2Box.Size = new System.Drawing.Size(56, 23);
            this.x2Box.TabIndex = 36;
            // 
            // x1Box
            // 
            this.x1Box.DecimalPlaces = 2;
            this.x1Box.Location = new System.Drawing.Point(217, 63);
            this.x1Box.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.x1Box.Name = "x1Box";
            this.x1Box.Size = new System.Drawing.Size(56, 23);
            this.x1Box.TabIndex = 35;
            // 
            // t1Label
            // 
            this.t1Label.AutoSize = true;
            this.t1Label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.t1Label.ForeColor = System.Drawing.Color.White;
            this.t1Label.Location = new System.Drawing.Point(272, 56);
            this.t1Label.Name = "t1Label";
            this.t1Label.Size = new System.Drawing.Size(40, 30);
            this.t1Label.TabIndex = 38;
            this.t1Label.Text = "t +";
            // 
            // t0Label
            // 
            this.t0Label.AutoSize = true;
            this.t0Label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.t0Label.ForeColor = System.Drawing.Color.White;
            this.t0Label.Location = new System.Drawing.Point(194, 55);
            this.t0Label.Name = "t0Label";
            this.t0Label.Size = new System.Drawing.Size(27, 30);
            this.t0Label.TabIndex = 32;
            this.t0Label.Text = "+";
            // 
            // x0Box
            // 
            this.x0Box.DecimalPlaces = 2;
            this.x0Box.Location = new System.Drawing.Point(144, 62);
            this.x0Box.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.x0Box.Name = "x0Box";
            this.x0Box.Size = new System.Drawing.Size(54, 23);
            this.x0Box.TabIndex = 37;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(190)))));
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitBtn.ForeColor = System.Drawing.Color.Black;
            this.exitBtn.Location = new System.Drawing.Point(914, 41);
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
            this.resetBtn.Location = new System.Drawing.Point(712, 41);
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
            this.dispLabel.ForeColor = System.Drawing.Color.White;
            this.dispLabel.Location = new System.Drawing.Point(3, 65);
            this.dispLabel.Name = "dispLabel";
            this.dispLabel.Size = new System.Drawing.Size(135, 15);
            this.dispLabel.TabIndex = 11;
            this.dispLabel.Text = "Displacement Equation: ";
            // 
            // switchBtn
            // 
            this.switchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(190)))));
            this.switchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.switchBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.switchBtn.ForeColor = System.Drawing.Color.Black;
            this.switchBtn.Location = new System.Drawing.Point(510, 42);
            this.switchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.switchBtn.Name = "switchBtn";
            this.switchBtn.Size = new System.Drawing.Size(196, 52);
            this.switchBtn.TabIndex = 0;
            this.switchBtn.Text = "Start/Stop";
            this.switchBtn.UseVisualStyleBackColor = false;
            this.switchBtn.Click += new System.EventHandler(this.switchBtn_Click);
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
            this.dimensionSwitch.Size = new System.Drawing.Size(54, 52);
            this.dimensionSwitch.TabIndex = 32;
            this.dimensionSwitch.Text = "1D";
            this.dimensionSwitch.UseVisualStyleBackColor = false;
            // 
            // varAccTimer
            // 
            this.varAccTimer.Interval = 20;
            this.varAccTimer.Tick += new System.EventHandler(this.varAccTimer_Tick);
            // 
            // varAccSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(1168, 621);
            this.Controls.Add(this.dimensionSwitch);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.statsPanel);
            this.Name = "varAccSim";
            this.Text = "Variable Acceleration Sim";
            this.Load += new System.EventHandler(this.varAccSim_Load);
            this.statsPanel.ResumeLayout(false);
            this.statsPanel.PerformLayout();
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.x3Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x2Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x1Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x0Box)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label t2Label;
        private System.Windows.Forms.Label t1Label;
        private System.Windows.Forms.Label t0Label;
        private System.Windows.Forms.Label t3Label;
        private System.Windows.Forms.Label velEqnTxt;
        private System.Windows.Forms.Label accTxt;
        private System.Windows.Forms.Button dimensionSwitch;
        private System.Windows.Forms.Timer varAccTimer;
    }
}