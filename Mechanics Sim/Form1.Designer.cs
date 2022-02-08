
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fsButton
            // 
            this.fsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(190)))));
            this.fsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fsButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fsButton.Location = new System.Drawing.Point(12, 87);
            this.fsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fsButton.Name = "fsButton";
            this.fsButton.Size = new System.Drawing.Size(537, 50);
            this.fsButton.TabIndex = 0;
            this.fsButton.Text = "Forces";
            this.fsButton.UseVisualStyleBackColor = false;
            this.fsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // prButton
            // 
            this.prButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(190)))));
            this.prButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prButton.Location = new System.Drawing.Point(12, 141);
            this.prButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prButton.Name = "prButton";
            this.prButton.Size = new System.Drawing.Size(537, 54);
            this.prButton.TabIndex = 1;
            this.prButton.Text = "Projectiles";
            this.prButton.UseVisualStyleBackColor = false;
            this.prButton.Click += new System.EventHandler(this.prButton_Click);
            // 
            // pullBtn
            // 
            this.pullBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(190)))));
            this.pullBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pullBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pullBtn.Location = new System.Drawing.Point(12, 199);
            this.pullBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pullBtn.Name = "pullBtn";
            this.pullBtn.Size = new System.Drawing.Size(537, 48);
            this.pullBtn.TabIndex = 2;
            this.pullBtn.Text = "Pulleys";
            this.pullBtn.UseVisualStyleBackColor = false;
            this.pullBtn.Click += new System.EventHandler(this.pullBtn_Click);
            // 
            // varAccBtn
            // 
            this.varAccBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(190)))));
            this.varAccBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.varAccBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.varAccBtn.Location = new System.Drawing.Point(12, 251);
            this.varAccBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.varAccBtn.Name = "varAccBtn";
            this.varAccBtn.Size = new System.Drawing.Size(537, 50);
            this.varAccBtn.TabIndex = 3;
            this.varAccBtn.Text = "Variable Acceleration";
            this.varAccBtn.UseVisualStyleBackColor = false;
            this.varAccBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(194, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(159, 30);
            this.titleLabel.TabIndex = 17;
            this.titleLabel.Text = "Mechanics Sim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 30);
            this.label1.TabIndex = 18;
            this.label1.Text = "Choose a topic:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(566, 312);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.varAccBtn);
            this.Controls.Add(this.pullBtn);
            this.Controls.Add(this.prButton);
            this.Controls.Add(this.fsButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Mechanics Sim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fsButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button prButton;
        private System.Windows.Forms.Button pullBtn;
        private System.Windows.Forms.Button varAccBtn;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label label1;
    }
}

