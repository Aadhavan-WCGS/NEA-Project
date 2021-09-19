
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
            this.controlPanel = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.mass2Box = new System.Windows.Forms.TextBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.mass2Label = new System.Windows.Forms.Label();
            this.switchBtn = new System.Windows.Forms.Button();
            this.mass1Label = new System.Windows.Forms.Label();
            this.mass1Box = new System.Windows.Forms.TextBox();
            this.statsPanel = new System.Windows.Forms.Panel();
            this.timeTxt = new System.Windows.Forms.Label();
            this.tnTxt = new System.Windows.Forms.Label();
            this.accTxt = new System.Windows.Forms.Label();
            this.StatsTxt = new System.Windows.Forms.Label();
            this.speedTxt = new System.Windows.Forms.Label();
            this.pullTimer = new System.Windows.Forms.Timer(this.components);
            this.checkBoxTable = new System.Windows.Forms.CheckBox();
            this.fricCoeffLabel = new System.Windows.Forms.Label();
            this.coeffBox = new System.Windows.Forms.TextBox();
            this.controlPanel.SuspendLayout();
            this.statsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.coeffBox);
            this.controlPanel.Controls.Add(this.fricCoeffLabel);
            this.controlPanel.Controls.Add(this.exitBtn);
            this.controlPanel.Controls.Add(this.mass2Box);
            this.controlPanel.Controls.Add(this.resetBtn);
            this.controlPanel.Controls.Add(this.mass2Label);
            this.controlPanel.Controls.Add(this.switchBtn);
            this.controlPanel.Controls.Add(this.mass1Label);
            this.controlPanel.Controls.Add(this.mass1Box);
            this.controlPanel.Location = new System.Drawing.Point(222, 470);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(932, 117);
            this.controlPanel.TabIndex = 17;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(190)))));
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitBtn.ForeColor = System.Drawing.Color.Black;
            this.exitBtn.Location = new System.Drawing.Point(732, 30);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(196, 52);
            this.exitBtn.TabIndex = 32;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // mass2Box
            // 
            this.mass2Box.BackColor = System.Drawing.Color.White;
            this.mass2Box.ForeColor = System.Drawing.Color.Black;
            this.mass2Box.Location = new System.Drawing.Point(266, 59);
            this.mass2Box.Name = "mass2Box";
            this.mass2Box.Size = new System.Drawing.Size(56, 23);
            this.mass2Box.TabIndex = 13;
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(190)))));
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resetBtn.ForeColor = System.Drawing.Color.Black;
            this.resetBtn.Location = new System.Drawing.Point(530, 30);
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
            this.mass2Label.Location = new System.Drawing.Point(214, 65);
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
            this.switchBtn.Location = new System.Drawing.Point(328, 30);
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
            this.mass1Label.Location = new System.Drawing.Point(214, 33);
            this.mass1Label.Name = "mass1Label";
            this.mass1Label.Size = new System.Drawing.Size(46, 15);
            this.mass1Label.TabIndex = 11;
            this.mass1Label.Text = "Mass 1:";
            // 
            // mass1Box
            // 
            this.mass1Box.BackColor = System.Drawing.Color.White;
            this.mass1Box.ForeColor = System.Drawing.Color.Black;
            this.mass1Box.Location = new System.Drawing.Point(266, 30);
            this.mass1Box.Name = "mass1Box";
            this.mass1Box.Size = new System.Drawing.Size(56, 23);
            this.mass1Box.TabIndex = 3;
            // 
            // statsPanel
            // 
            this.statsPanel.Controls.Add(this.timeTxt);
            this.statsPanel.Controls.Add(this.tnTxt);
            this.statsPanel.Controls.Add(this.accTxt);
            this.statsPanel.Controls.Add(this.StatsTxt);
            this.statsPanel.Controls.Add(this.speedTxt);
            this.statsPanel.Location = new System.Drawing.Point(906, 12);
            this.statsPanel.Name = "statsPanel";
            this.statsPanel.Size = new System.Drawing.Size(331, 156);
            this.statsPanel.TabIndex = 18;
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
            // tnTxt
            // 
            this.tnTxt.AutoSize = true;
            this.tnTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tnTxt.ForeColor = System.Drawing.Color.White;
            this.tnTxt.Location = new System.Drawing.Point(70, 81);
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
            // checkBoxTable
            // 
            this.checkBoxTable.AutoSize = true;
            this.checkBoxTable.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxTable.ForeColor = System.Drawing.Color.White;
            this.checkBoxTable.Location = new System.Drawing.Point(988, 174);
            this.checkBoxTable.Name = "checkBoxTable";
            this.checkBoxTable.Size = new System.Drawing.Size(109, 29);
            this.checkBoxTable.TabIndex = 21;
            this.checkBoxTable.Text = "Use table";
            this.checkBoxTable.UseVisualStyleBackColor = true;
            this.checkBoxTable.CheckedChanged += new System.EventHandler(this.checkBoxTable_CheckedChanged);
            // 
            // fricCoeffLabel
            // 
            this.fricCoeffLabel.AutoSize = true;
            this.fricCoeffLabel.ForeColor = System.Drawing.Color.White;
            this.fricCoeffLabel.Location = new System.Drawing.Point(3, 33);
            this.fricCoeffLabel.Name = "fricCoeffLabel";
            this.fricCoeffLabel.Size = new System.Drawing.Size(132, 15);
            this.fricCoeffLabel.TabIndex = 33;
            this.fricCoeffLabel.Text = "Friction Coefficient (μ): ";
            // 
            // coeffBox
            // 
            this.coeffBox.BackColor = System.Drawing.Color.White;
            this.coeffBox.ForeColor = System.Drawing.Color.Black;
            this.coeffBox.Location = new System.Drawing.Point(141, 30);
            this.coeffBox.Name = "coeffBox";
            this.coeffBox.Size = new System.Drawing.Size(56, 23);
            this.coeffBox.TabIndex = 34;
            // 
            // onePulleySim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(1249, 599);
            this.Controls.Add(this.checkBoxTable);
            this.Controls.Add(this.statsPanel);
            this.Controls.Add(this.controlPanel);
            this.Name = "onePulleySim";
            this.Text = "onePulleySim";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.onePulleySim_Paint);
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.statsPanel.ResumeLayout(false);
            this.statsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label mass1Label;
        private System.Windows.Forms.TextBox mass1Box;
        private System.Windows.Forms.Button switchBtn;
        private System.Windows.Forms.Panel statsPanel;
        private System.Windows.Forms.Label timeTxt;
        private System.Windows.Forms.Label tnTxt;
        private System.Windows.Forms.Label accTxt;
        private System.Windows.Forms.Label StatsTxt;
        private System.Windows.Forms.Label speedTxt;
        private System.Windows.Forms.Timer pullTimer;
        private System.Windows.Forms.Label mass2Label;
        private System.Windows.Forms.TextBox mass2Box;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.CheckBox checkBoxTable;
        private System.Windows.Forms.TextBox coeffBox;
        private System.Windows.Forms.Label fricCoeffLabel;
    }
}