
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectilesSim));
            this.proj = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.proj)).BeginInit();
            this.SuspendLayout();
            // 
            // proj
            // 
            this.proj.Image = ((System.Drawing.Image)(resources.GetObject("proj.Image")));
            this.proj.Location = new System.Drawing.Point(653, 275);
            this.proj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.proj.Name = "proj";
            this.proj.Size = new System.Drawing.Size(86, 85);
            this.proj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.proj.TabIndex = 2;
            this.proj.TabStop = false;
            // 
            // ProjectilesSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(1392, 634);
            this.Controls.Add(this.proj);
            this.Name = "ProjectilesSim";
            this.Text = "Projectiles Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.proj)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox proj;
    }
}