namespace FireGunGame
{
    partial class Form1
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
            this.Load = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.FireAway = new System.Windows.Forms.Button();
            this.Fire = new System.Windows.Forms.Button();
            this.Spin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(12, 415);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(75, 23);
            this.Load.TabIndex = 0;
            this.Load.Text = "LOAD";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(713, 49);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "EXIT";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // FireAway
            // 
            this.FireAway.Location = new System.Drawing.Point(495, 415);
            this.FireAway.Name = "FireAway";
            this.FireAway.Size = new System.Drawing.Size(129, 23);
            this.FireAway.TabIndex = 2;
            this.FireAway.Text = "FIRE AWAY";
            this.FireAway.UseVisualStyleBackColor = true;
            this.FireAway.Click += new System.EventHandler(this.FireAway_Click);
            // 
            // Fire
            // 
            this.Fire.Location = new System.Drawing.Point(303, 415);
            this.Fire.Name = "Fire";
            this.Fire.Size = new System.Drawing.Size(75, 23);
            this.Fire.TabIndex = 3;
            this.Fire.Text = "FIRE";
            this.Fire.UseVisualStyleBackColor = true;
            this.Fire.Click += new System.EventHandler(this.Fire_Click);
            // 
            // Spin
            // 
            this.Spin.Location = new System.Drawing.Point(154, 415);
            this.Spin.Name = "Spin";
            this.Spin.Size = new System.Drawing.Size(75, 23);
            this.Spin.TabIndex = 4;
            this.Spin.Text = "SPIN";
            this.Spin.UseVisualStyleBackColor = true;
            this.Spin.Click += new System.EventHandler(this.Spin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(56, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(543, 363);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Spin);
            this.Controls.Add(this.Fire);
            this.Controls.Add(this.FireAway);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Load);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button FireAway;
        private System.Windows.Forms.Button Fire;
        private System.Windows.Forms.Button Spin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

