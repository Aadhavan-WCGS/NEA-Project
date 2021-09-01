
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
            this.switchBtn = new System.Windows.Forms.Button();
            this.forceTimer = new System.Windows.Forms.Timer(this.components);
            this.xforceLabel = new System.Windows.Forms.Label();
            this.massBox = new System.Windows.Forms.TextBox();
            this.xfBox = new System.Windows.Forms.TextBox();
            this.yfBox = new System.Windows.Forms.TextBox();
            this.speedTxt = new System.Windows.Forms.Label();
            this.yforceLabel = new System.Windows.Forms.Label();
            this.StatsTxt = new System.Windows.Forms.Label();
            this.massLabel = new System.Windows.Forms.Label();
            this.accTxt = new System.Windows.Forms.Label();
            this.rfTxt = new System.Windows.Forms.Label();
            this.timeTxt = new System.Windows.Forms.Label();
            this.statsPanel = new System.Windows.Forms.Panel();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.resetBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.statsPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // switchBtn
            // 
            this.switchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(190)))));
            this.switchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.switchBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.switchBtn.ForeColor = System.Drawing.Color.Black;
            this.switchBtn.Location = new System.Drawing.Point(365, 51);
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
            // massBox
            // 
            this.massBox.BackColor = System.Drawing.Color.White;
            this.massBox.ForeColor = System.Drawing.Color.Black;
            this.massBox.Location = new System.Drawing.Point(72, 51);
            this.massBox.Name = "massBox";
            this.massBox.Size = new System.Drawing.Size(56, 23);
            this.massBox.TabIndex = 3;
            // 
            // xfBox
            // 
            this.xfBox.Location = new System.Drawing.Point(245, 51);
            this.xfBox.Name = "xfBox";
            this.xfBox.Size = new System.Drawing.Size(100, 23);
            this.xfBox.TabIndex = 4;
            // 
            // yfBox
            // 
            this.yfBox.Location = new System.Drawing.Point(245, 80);
            this.yfBox.Name = "yfBox";
            this.yfBox.Size = new System.Drawing.Size(100, 23);
            this.yfBox.TabIndex = 5;
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
            this.massLabel.Location = new System.Drawing.Point(29, 54);
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
            this.controlPanel.Controls.Add(this.exitBtn);
            this.controlPanel.Controls.Add(this.resetBtn);
            this.controlPanel.Controls.Add(this.massLabel);
            this.controlPanel.Controls.Add(this.yforceLabel);
            this.controlPanel.Controls.Add(this.yfBox);
            this.controlPanel.Controls.Add(this.xfBox);
            this.controlPanel.Controls.Add(this.massBox);
            this.controlPanel.Controls.Add(this.xforceLabel);
            this.controlPanel.Controls.Add(this.switchBtn);
            this.controlPanel.Location = new System.Drawing.Point(296, 598);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(1004, 138);
            this.controlPanel.TabIndex = 16;
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(190)))));
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resetBtn.ForeColor = System.Drawing.Color.Black;
            this.resetBtn.Location = new System.Drawing.Point(585, 51);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(196, 52);
            this.resetBtn.TabIndex = 12;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(190)))));
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitBtn.ForeColor = System.Drawing.Color.Black;
            this.exitBtn.Location = new System.Drawing.Point(787, 51);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(196, 52);
            this.exitBtn.TabIndex = 33;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // ForcesSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(1313, 749);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button switchBtn;
        public System.Windows.Forms.Timer forceTimer;
        private System.Windows.Forms.Label xforceLabel;
        private System.Windows.Forms.TextBox massBox;
        private System.Windows.Forms.TextBox xfBox;
        private System.Windows.Forms.TextBox yfBox;
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
    }
}