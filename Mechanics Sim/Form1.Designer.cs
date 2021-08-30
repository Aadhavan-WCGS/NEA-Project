
namespace Mechanics_Sim
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.fsButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.prButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fsButton
            // 
            this.fsButton.Location = new System.Drawing.Point(10, 9);
            this.fsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fsButton.Name = "fsButton";
            this.fsButton.Size = new System.Drawing.Size(82, 22);
            this.fsButton.TabIndex = 0;
            this.fsButton.Text = "Forces";
            this.fsButton.UseVisualStyleBackColor = true;
            this.fsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // prButton
            // 
            this.prButton.Location = new System.Drawing.Point(10, 35);
            this.prButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prButton.Name = "prButton";
            this.prButton.Size = new System.Drawing.Size(82, 22);
            this.prButton.TabIndex = 1;
            this.prButton.Text = "Projectiles";
            this.prButton.UseVisualStyleBackColor = true;
            this.prButton.Click += new System.EventHandler(this.prButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 338);
            this.Controls.Add(this.prButton);
            this.Controls.Add(this.fsButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fsButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button prButton;
    }
}

