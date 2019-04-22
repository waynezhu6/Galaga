namespace _v0._1_Galaga
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.lblMenuStart = new System.Windows.Forms.Label();
            this.pBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblHiScoreScore = new System.Windows.Forms.Label();
            this.lbl1UpScore = new System.Windows.Forms.Label();
            this.lblHiScore = new System.Windows.Forms.Label();
            this.lbl1Up = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leaderboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToPlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mainPanel.Controls.Add(this.lblMenuStart);
            this.mainPanel.Controls.Add(this.pBoxLogo);
            this.mainPanel.Controls.Add(this.lblHiScoreScore);
            this.mainPanel.Controls.Add(this.lbl1UpScore);
            this.mainPanel.Controls.Add(this.lblHiScore);
            this.mainPanel.Controls.Add(this.lbl1Up);
            this.mainPanel.Controls.Add(this.lblScore);
            this.mainPanel.Controls.Add(this.lblStart);
            this.mainPanel.Controls.Add(this.menuStrip);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(450, 600);
            this.mainPanel.TabIndex = 8;
            this.mainPanel.Click += new System.EventHandler(this.mainPanel_Click);
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // lblMenuStart
            // 
            this.lblMenuStart.AutoSize = true;
            this.lblMenuStart.Font = new System.Drawing.Font("Copperplate Gothic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuStart.ForeColor = System.Drawing.Color.Red;
            this.lblMenuStart.Location = new System.Drawing.Point(177, 495);
            this.lblMenuStart.Name = "lblMenuStart";
            this.lblMenuStart.Size = new System.Drawing.Size(108, 33);
            this.lblMenuStart.TabIndex = 24;
            this.lblMenuStart.Text = "Start";
            this.lblMenuStart.Visible = false;
            this.lblMenuStart.Click += new System.EventHandler(this.lblMenuStart_Click);
            // 
            // pBoxLogo
            // 
            this.pBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pBoxLogo.Image")));
            this.pBoxLogo.Location = new System.Drawing.Point(72, 110);
            this.pBoxLogo.Name = "pBoxLogo";
            this.pBoxLogo.Size = new System.Drawing.Size(300, 260);
            this.pBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxLogo.TabIndex = 23;
            this.pBoxLogo.TabStop = false;
            // 
            // lblHiScoreScore
            // 
            this.lblHiScoreScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHiScoreScore.Font = new System.Drawing.Font("Copperplate Gothic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHiScoreScore.ForeColor = System.Drawing.Color.White;
            this.lblHiScoreScore.Location = new System.Drawing.Point(273, 74);
            this.lblHiScoreScore.Name = "lblHiScoreScore";
            this.lblHiScoreScore.Size = new System.Drawing.Size(165, 33);
            this.lblHiScoreScore.TabIndex = 22;
            this.lblHiScoreScore.Text = "30000";
            this.lblHiScoreScore.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl1UpScore
            // 
            this.lbl1UpScore.AutoSize = true;
            this.lbl1UpScore.Font = new System.Drawing.Font("Copperplate Gothic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1UpScore.ForeColor = System.Drawing.Color.White;
            this.lbl1UpScore.Location = new System.Drawing.Point(18, 74);
            this.lbl1UpScore.Name = "lbl1UpScore";
            this.lbl1UpScore.Size = new System.Drawing.Size(57, 33);
            this.lbl1UpScore.TabIndex = 21;
            this.lbl1UpScore.Text = "00";
            // 
            // lblHiScore
            // 
            this.lblHiScore.AutoSize = true;
            this.lblHiScore.Font = new System.Drawing.Font("Copperplate Gothic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHiScore.ForeColor = System.Drawing.Color.Red;
            this.lblHiScore.Location = new System.Drawing.Point(267, 41);
            this.lblHiScore.Name = "lblHiScore";
            this.lblHiScore.Size = new System.Drawing.Size(171, 33);
            this.lblHiScore.TabIndex = 20;
            this.lblHiScore.Text = "HI-SCORE";
            // 
            // lbl1Up
            // 
            this.lbl1Up.AutoSize = true;
            this.lbl1Up.Font = new System.Drawing.Font("Copperplate Gothic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Up.ForeColor = System.Drawing.Color.Red;
            this.lbl1Up.Location = new System.Drawing.Point(12, 41);
            this.lbl1Up.Name = "lbl1Up";
            this.lbl1Up.Size = new System.Drawing.Size(82, 33);
            this.lbl1Up.TabIndex = 19;
            this.lbl1Up.Text = "1UP";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(-100, -100);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(35, 13);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "label1";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(-100, -100);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(35, 13);
            this.lblStart.TabIndex = 0;
            this.lblStart.Text = "label1";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(450, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leaderboardToolStripMenuItem,
            this.howToPlayToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.menuToolStripMenuItem.Text = "More";
            // 
            // leaderboardToolStripMenuItem
            // 
            this.leaderboardToolStripMenuItem.Name = "leaderboardToolStripMenuItem";
            this.leaderboardToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.leaderboardToolStripMenuItem.Text = "Leaderboard";
            this.leaderboardToolStripMenuItem.Click += new System.EventHandler(this.leaderboardToolStripMenuItem_Click);
            // 
            // howToPlayToolStripMenuItem
            // 
            this.howToPlayToolStripMenuItem.Name = "howToPlayToolStripMenuItem";
            this.howToPlayToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.howToPlayToolStripMenuItem.Text = "How to Play";
            this.howToPlayToolStripMenuItem.Click += new System.EventHandler(this.howToPlayToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 600);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "GALAGA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        public System.Windows.Forms.Label lblStart;
        public System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leaderboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToPlayToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuStrip;
        public System.Windows.Forms.Label lblMenuStart;
        public System.Windows.Forms.PictureBox pBoxLogo;
        public System.Windows.Forms.Label lblHiScoreScore;
        public System.Windows.Forms.Label lbl1UpScore;
        public System.Windows.Forms.Label lblHiScore;
        public System.Windows.Forms.Label lbl1Up;
    }
}

