namespace _v0._1_Galaga
{
    partial class HiScore
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
            this.lblLetter1 = new System.Windows.Forms.Label();
            this.lblLetter3 = new System.Windows.Forms.Label();
            this.lblLetter2 = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblInitials = new System.Windows.Forms.Label();
            this.lblSubmit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLetter1
            // 
            this.lblLetter1.AutoSize = true;
            this.lblLetter1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetter1.ForeColor = System.Drawing.Color.White;
            this.lblLetter1.Location = new System.Drawing.Point(89, 167);
            this.lblLetter1.Name = "lblLetter1";
            this.lblLetter1.Size = new System.Drawing.Size(32, 24);
            this.lblLetter1.TabIndex = 0;
            this.lblLetter1.Text = "__";
            // 
            // lblLetter3
            // 
            this.lblLetter3.AutoSize = true;
            this.lblLetter3.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetter3.ForeColor = System.Drawing.Color.Red;
            this.lblLetter3.Location = new System.Drawing.Point(165, 167);
            this.lblLetter3.Name = "lblLetter3";
            this.lblLetter3.Size = new System.Drawing.Size(32, 24);
            this.lblLetter3.TabIndex = 1;
            this.lblLetter3.Text = "__";
            // 
            // lblLetter2
            // 
            this.lblLetter2.AutoSize = true;
            this.lblLetter2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetter2.ForeColor = System.Drawing.Color.Red;
            this.lblLetter2.Location = new System.Drawing.Point(127, 167);
            this.lblLetter2.Name = "lblLetter2";
            this.lblLetter2.Size = new System.Drawing.Size(32, 24);
            this.lblLetter2.TabIndex = 2;
            this.lblLetter2.Text = "__";
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore.ForeColor = System.Drawing.Color.Red;
            this.lblHighScore.Location = new System.Drawing.Point(50, 14);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(190, 24);
            this.lblHighScore.TabIndex = 3;
            this.lblHighScore.Text = "New Highscore";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Copperplate Gothic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(47, 41);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(193, 53);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "30000";
            // 
            // lblInitials
            // 
            this.lblInitials.AutoSize = true;
            this.lblInitials.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInitials.ForeColor = System.Drawing.Color.Red;
            this.lblInitials.Location = new System.Drawing.Point(69, 130);
            this.lblInitials.Name = "lblInitials";
            this.lblInitials.Size = new System.Drawing.Size(154, 21);
            this.lblInitials.TabIndex = 5;
            this.lblInitials.Text = "Your Initials:";
            // 
            // lblSubmit
            // 
            this.lblSubmit.AutoSize = true;
            this.lblSubmit.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubmit.ForeColor = System.Drawing.Color.White;
            this.lblSubmit.Location = new System.Drawing.Point(97, 210);
            this.lblSubmit.Name = "lblSubmit";
            this.lblSubmit.Size = new System.Drawing.Size(88, 24);
            this.lblSubmit.TabIndex = 6;
            this.lblSubmit.Text = "Submit";
            this.lblSubmit.Click += new System.EventHandler(this.lblSubmit_Click);
            // 
            // HiScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblSubmit);
            this.Controls.Add(this.lblInitials);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.lblLetter2);
            this.Controls.Add(this.lblLetter3);
            this.Controls.Add(this.lblLetter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HiScore";
            this.Text = "HiScore";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HiScore_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLetter1;
        private System.Windows.Forms.Label lblLetter3;
        private System.Windows.Forms.Label lblLetter2;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblInitials;
        private System.Windows.Forms.Label lblSubmit;
    }
}