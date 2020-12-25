namespace Lenny_s_Tool___
{
    partial class Coinflip
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
            this.button1 = new System.Windows.Forms.Button();
            this.Head = new System.Windows.Forms.Label();
            this.Tails = new System.Windows.Forms.Label();
            this.TailsLose = new System.Windows.Forms.Label();
            this.HeadLose = new System.Windows.Forms.Label();
            this.Randomizer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 422);
            this.button1.TabIndex = 0;
            this.button1.Text = "Spin!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Head
            // 
            this.Head.AutoSize = true;
            this.Head.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Head.ForeColor = System.Drawing.Color.Silver;
            this.Head.Location = new System.Drawing.Point(322, 176);
            this.Head.Name = "Head";
            this.Head.Size = new System.Drawing.Size(158, 55);
            this.Head.TabIndex = 1;
            this.Head.Text = "Head!";
            // 
            // Tails
            // 
            this.Tails.AutoSize = true;
            this.Tails.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tails.ForeColor = System.Drawing.Color.Silver;
            this.Tails.Location = new System.Drawing.Point(330, 229);
            this.Tails.Name = "Tails";
            this.Tails.Size = new System.Drawing.Size(143, 55);
            this.Tails.TabIndex = 2;
            this.Tails.Text = "Tails!";
            // 
            // TailsLose
            // 
            this.TailsLose.AutoSize = true;
            this.TailsLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TailsLose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TailsLose.Location = new System.Drawing.Point(330, 229);
            this.TailsLose.Name = "TailsLose";
            this.TailsLose.Size = new System.Drawing.Size(143, 55);
            this.TailsLose.TabIndex = 3;
            this.TailsLose.Text = "Tails!";
            // 
            // HeadLose
            // 
            this.HeadLose.AutoSize = true;
            this.HeadLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadLose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.HeadLose.Location = new System.Drawing.Point(322, 176);
            this.HeadLose.Name = "HeadLose";
            this.HeadLose.Size = new System.Drawing.Size(158, 55);
            this.HeadLose.TabIndex = 4;
            this.HeadLose.Text = "Head!";
            // 
            // Randomizer
            // 
            this.Randomizer.AutoSize = true;
            this.Randomizer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Randomizer.Location = new System.Drawing.Point(541, 369);
            this.Randomizer.Name = "Randomizer";
            this.Randomizer.Size = new System.Drawing.Size(13, 13);
            this.Randomizer.TabIndex = 5;
            this.Randomizer.Text = "1";
            // 
            // Coinflip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(701, 447);
            this.Controls.Add(this.Randomizer);
            this.Controls.Add(this.HeadLose);
            this.Controls.Add(this.TailsLose);
            this.Controls.Add(this.Tails);
            this.Controls.Add(this.Head);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Coinflip";
            this.Text = "Coinflip";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Head;
        private System.Windows.Forms.Label Tails;
        private System.Windows.Forms.Label TailsLose;
        private System.Windows.Forms.Label HeadLose;
        private System.Windows.Forms.Label Randomizer;
    }
}