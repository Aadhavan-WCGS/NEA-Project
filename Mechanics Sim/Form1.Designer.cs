
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
            this.pullBtn = new System.Windows.Forms.Button();
            this.varAccBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fsButton
            // 
            this.fsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(190)))));
            this.fsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fsButton.Location = new System.Drawing.Point(10, 20);
            this.fsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fsButton.Name = "fsButton";
            this.fsButton.Size = new System.Drawing.Size(122, 27);
            this.fsButton.TabIndex = 0;
            this.fsButton.Text = "Forces";
            this.fsButton.UseVisualStyleBackColor = false;
            this.fsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // prButton
            // 
            this.prButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(190)))));
            this.prButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prButton.Location = new System.Drawing.Point(10, 51);
            this.prButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prButton.Name = "prButton";
            this.prButton.Size = new System.Drawing.Size(122, 27);
            this.prButton.TabIndex = 1;
            this.prButton.Text = "Projectiles";
            this.prButton.UseVisualStyleBackColor = false;
            this.prButton.Click += new System.EventHandler(this.prButton_Click);
            // 
            // pullBtn
            // 
            this.pullBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(190)))));
            this.pullBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pullBtn.Location = new System.Drawing.Point(10, 82);
            this.pullBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pullBtn.Name = "pullBtn";
            this.pullBtn.Size = new System.Drawing.Size(122, 27);
            this.pullBtn.TabIndex = 2;
            this.pullBtn.Text = "Pulleys";
            this.pullBtn.UseVisualStyleBackColor = false;
            this.pullBtn.Click += new System.EventHandler(this.pullBtn_Click);
            // 
            // varAccBtn
            // 
            this.varAccBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(190)))));
            this.varAccBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.varAccBtn.Location = new System.Drawing.Point(10, 113);
            this.varAccBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.varAccBtn.Name = "varAccBtn";
            this.varAccBtn.Size = new System.Drawing.Size(122, 40);
            this.varAccBtn.TabIndex = 3;
            this.varAccBtn.Text = "Variable Acceleration";
            this.varAccBtn.UseVisualStyleBackColor = false;
            this.varAccBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(561, 338);
            this.Controls.Add(this.varAccBtn);
            this.Controls.Add(this.pullBtn);
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
        private System.Windows.Forms.Button pullBtn;
        private System.Windows.Forms.Button varAccBtn;
    }
}

