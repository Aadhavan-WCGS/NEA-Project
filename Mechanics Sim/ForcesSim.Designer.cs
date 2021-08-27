
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
            this.Switch = new System.Windows.Forms.Button();
            this.forceTimer = new System.Windows.Forms.Timer(this.components);
            this.xforceLabel = new System.Windows.Forms.Label();
            this.massBox = new System.Windows.Forms.TextBox();
            this.xfBox = new System.Windows.Forms.TextBox();
            this.yfBox = new System.Windows.Forms.TextBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.speedBox = new System.Windows.Forms.Label();
            this.yforceLabel = new System.Windows.Forms.Label();
            this.Stats = new System.Windows.Forms.Label();
            this.massLabel = new System.Windows.Forms.Label();
            this.accBox = new System.Windows.Forms.Label();
            this.rfBox = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // Switch
            // 
            this.Switch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(190)))));
            this.Switch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Switch.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Switch.ForeColor = System.Drawing.Color.Black;
            this.Switch.Location = new System.Drawing.Point(1052, 640);
            this.Switch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Switch.Name = "Switch";
            this.Switch.Size = new System.Drawing.Size(230, 82);
            this.Switch.TabIndex = 0;
            this.Switch.Text = "Start/Stop";
            this.Switch.UseVisualStyleBackColor = false;
            this.Switch.Click += new System.EventHandler(this.Switch_Click);
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
            this.xforceLabel.Location = new System.Drawing.Point(790, 657);
            this.xforceLabel.Name = "xforceLabel";
            this.xforceLabel.Size = new System.Drawing.Size(94, 15);
            this.xforceLabel.TabIndex = 2;
            this.xforceLabel.Text = "Horizontal Force";
            // 
            // massBox
            // 
            this.massBox.BackColor = System.Drawing.Color.White;
            this.massBox.ForeColor = System.Drawing.Color.Black;
            this.massBox.Location = new System.Drawing.Point(717, 649);
            this.massBox.Name = "massBox";
            this.massBox.Size = new System.Drawing.Size(56, 23);
            this.massBox.TabIndex = 3;
            // 
            // xfBox
            // 
            this.xfBox.Location = new System.Drawing.Point(890, 649);
            this.xfBox.Name = "xfBox";
            this.xfBox.Size = new System.Drawing.Size(100, 23);
            this.xfBox.TabIndex = 4;
            // 
            // yfBox
            // 
            this.yfBox.Location = new System.Drawing.Point(890, 678);
            this.yfBox.Name = "yfBox";
            this.yfBox.Size = new System.Drawing.Size(100, 23);
            this.yfBox.TabIndex = 5;
            // 
            // ball
            // 
            this.ball.Image = ((System.Drawing.Image)(resources.GetObject("ball.Image")));
            this.ball.Location = new System.Drawing.Point(687, 210);
            this.ball.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(86, 85);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // speedBox
            // 
            this.speedBox.AutoSize = true;
            this.speedBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.speedBox.ForeColor = System.Drawing.Color.White;
            this.speedBox.Location = new System.Drawing.Point(1052, 35);
            this.speedBox.Name = "speedBox";
            this.speedBox.Size = new System.Drawing.Size(73, 25);
            this.speedBox.TabIndex = 6;
            this.speedBox.Text = "Speed: ";
            // 
            // yforceLabel
            // 
            this.yforceLabel.AutoSize = true;
            this.yforceLabel.ForeColor = System.Drawing.Color.White;
            this.yforceLabel.Location = new System.Drawing.Point(807, 686);
            this.yforceLabel.Name = "yforceLabel";
            this.yforceLabel.Size = new System.Drawing.Size(77, 15);
            this.yforceLabel.TabIndex = 7;
            this.yforceLabel.Text = "Vertical Force";
            // 
            // Stats
            // 
            this.Stats.AutoSize = true;
            this.Stats.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Stats.ForeColor = System.Drawing.Color.White;
            this.Stats.Location = new System.Drawing.Point(1134, 9);
            this.Stats.Name = "Stats";
            this.Stats.Size = new System.Drawing.Size(84, 25);
            this.Stats.TabIndex = 8;
            this.Stats.Text = "Statistics";
            // 
            // massLabel
            // 
            this.massLabel.AutoSize = true;
            this.massLabel.ForeColor = System.Drawing.Color.White;
            this.massLabel.Location = new System.Drawing.Point(674, 652);
            this.massLabel.Name = "massLabel";
            this.massLabel.Size = new System.Drawing.Size(37, 15);
            this.massLabel.TabIndex = 11;
            this.massLabel.Text = "Mass:";
            // 
            // accBox
            // 
            this.accBox.AutoSize = true;
            this.accBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.accBox.ForeColor = System.Drawing.Color.White;
            this.accBox.Location = new System.Drawing.Point(999, 60);
            this.accBox.Name = "accBox";
            this.accBox.Size = new System.Drawing.Size(126, 25);
            this.accBox.TabIndex = 12;
            this.accBox.Text = "Acceleration: ";
            // 
            // rfBox
            // 
            this.rfBox.AutoSize = true;
            this.rfBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rfBox.ForeColor = System.Drawing.Color.White;
            this.rfBox.Location = new System.Drawing.Point(976, 85);
            this.rfBox.Name = "rfBox";
            this.rfBox.Size = new System.Drawing.Size(149, 25);
            this.rfBox.TabIndex = 13;
            this.rfBox.Text = "Resultant Force: ";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.time.ForeColor = System.Drawing.Color.White;
            this.time.Location = new System.Drawing.Point(993, 110);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(132, 25);
            this.time.TabIndex = 14;
            this.time.Text = "Time Elapsed: ";
            // 
            // ForcesSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(1313, 749);
            this.Controls.Add(this.time);
            this.Controls.Add(this.rfBox);
            this.Controls.Add(this.accBox);
            this.Controls.Add(this.massLabel);
            this.Controls.Add(this.Stats);
            this.Controls.Add(this.yforceLabel);
            this.Controls.Add(this.speedBox);
            this.Controls.Add(this.yfBox);
            this.Controls.Add(this.xfBox);
            this.Controls.Add(this.massBox);
            this.Controls.Add(this.xforceLabel);
            this.Controls.Add(this.Switch);
            this.Controls.Add(this.ball);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimizeBox = false;
            this.Name = "ForcesSim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Forces Simulator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Switch;
        public System.Windows.Forms.Timer forceTimer;
        private System.Windows.Forms.Label xforceLabel;
        private System.Windows.Forms.TextBox massBox;
        private System.Windows.Forms.TextBox xfBox;
        private System.Windows.Forms.TextBox yfBox;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Label speedBox;
        private System.Windows.Forms.Label yforceLabel;
        private System.Windows.Forms.Label Stats;
        private System.Windows.Forms.Label massLabel;
        private System.Windows.Forms.Label accBox;
        private System.Windows.Forms.Label rfBox;
        private System.Windows.Forms.Label time;
    }
}