﻿
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
            this.proj = new System.Windows.Forms.PictureBox();
            this.timeTxt = new System.Windows.Forms.Label();
            this.rangeTxt = new System.Windows.Forms.Label();
            this.Stats = new System.Windows.Forms.Label();
            this.speedTxt = new System.Windows.Forms.Label();
            this.accTxt = new System.Windows.Forms.Label();
            this.maxhTxt = new System.Windows.Forms.Label();
            this.tofTxt = new System.Windows.Forms.Label();
            this.angleBox = new System.Windows.Forms.TextBox();
            this.uBox = new System.Windows.Forms.TextBox();
            this.uTxt = new System.Windows.Forms.Label();
            this.aopTxt = new System.Windows.Forms.Label();
            this.switchBtn = new System.Windows.Forms.Button();
            this.projTimer = new System.Windows.Forms.Timer(this.components);
            this.controlPanel = new System.Windows.Forms.Panel();
            this.statsPanel = new System.Windows.Forms.Panel();
            this.resetBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.proj)).BeginInit();
            this.controlPanel.SuspendLayout();
            this.statsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // proj
            // 
            this.proj.Image = ((System.Drawing.Image)(resources.GetObject("proj.Image")));
            this.proj.Location = new System.Drawing.Point(12, 593);
            this.proj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.proj.Name = "proj";
            this.proj.Size = new System.Drawing.Size(59, 63);
            this.proj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.proj.TabIndex = 2;
            this.proj.TabStop = false;
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
            // angleBox
            // 
            this.angleBox.Location = new System.Drawing.Point(358, 25);
            this.angleBox.Name = "angleBox";
            this.angleBox.Size = new System.Drawing.Size(100, 23);
            this.angleBox.TabIndex = 22;
            // 
            // uBox
            // 
            this.uBox.Location = new System.Drawing.Point(358, 54);
            this.uBox.Name = "uBox";
            this.uBox.Size = new System.Drawing.Size(100, 23);
            this.uBox.TabIndex = 23;
            // 
            // uTxt
            // 
            this.uTxt.AutoSize = true;
            this.uTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uTxt.ForeColor = System.Drawing.Color.White;
            this.uTxt.Location = new System.Drawing.Point(229, 50);
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
            this.aopTxt.Location = new System.Drawing.Point(169, 25);
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
            this.switchBtn.Location = new System.Drawing.Point(464, 25);
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
            this.controlPanel.Controls.Add(this.resetBtn);
            this.controlPanel.Controls.Add(this.angleBox);
            this.controlPanel.Controls.Add(this.switchBtn);
            this.controlPanel.Controls.Add(this.uBox);
            this.controlPanel.Controls.Add(this.aopTxt);
            this.controlPanel.Controls.Add(this.uTxt);
            this.controlPanel.Location = new System.Drawing.Point(432, 625);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(996, 173);
            this.controlPanel.TabIndex = 27;
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
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(190)))));
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resetBtn.ForeColor = System.Drawing.Color.Black;
            this.resetBtn.Location = new System.Drawing.Point(700, 25);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(230, 52);
            this.resetBtn.TabIndex = 30;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // ProjectilesSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(1475, 810);
            this.Controls.Add(this.statsPanel);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.proj);
            this.MaximizeBox = false;
            this.Name = "ProjectilesSim";
            this.Text = "Projectiles Simulator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.proj)).EndInit();
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.statsPanel.ResumeLayout(false);
            this.statsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox proj;
        private System.Windows.Forms.Label timeTxt;
        private System.Windows.Forms.Label rangeTxt;
        private System.Windows.Forms.Label Stats;
        private System.Windows.Forms.Label speedTxt;
        private System.Windows.Forms.Label accTxt;
        private System.Windows.Forms.Label maxhTxt;
        private System.Windows.Forms.Label tofTxt;
        private System.Windows.Forms.TextBox angleBox;
        private System.Windows.Forms.TextBox uBox;
        private System.Windows.Forms.Label uTxt;
        private System.Windows.Forms.Label aopTxt;
        private System.Windows.Forms.Button switchBtn;
        private System.Windows.Forms.Timer projTimer;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Panel statsPanel;
        private System.Windows.Forms.Button resetBtn;
    }
}