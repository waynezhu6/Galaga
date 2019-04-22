using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace _v0._1_Galaga
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GM = new GameManager(this);           
            SetTimer();
            this.DoubleBuffered = true;
            SetDoubleBuffering(mainPanel, true);         
        }

        public static void SetDoubleBuffering(System.Windows.Forms.Control control, bool value)
        {
            System.Reflection.PropertyInfo controlProperty = typeof(System.Windows.Forms.Control)
                .GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            controlProperty.SetValue(control, value, null);
        }

        public System.Timers.Timer gameTimer;
        GameManager GM;

        private void SetTimer()
        {
            gameTimer = new System.Timers.Timer();
            gameTimer.Elapsed += new ElapsedEventHandler(TimerTick);
            gameTimer.Interval = 1000 / 120;
            gameTimer.Enabled = true;
        }

        private void TimerTick(object sender, ElapsedEventArgs e)
        {
            mainPanel.Invalidate();
            GM.Next();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            GM.Draw(g);            
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            GM.UserInput(e.KeyCode, true);
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            GM.UserInput(e.KeyCode, false);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            GM.FormClosed();
        }

        private void howToPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Up Arrow: Shoot\r\nLeft Arrow: Move left\r\nRight Arrow: Move right");
        }

        private void leaderboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("     Leaderboard\r\n\r\n" +
                "1.    " + GM.HiScores[0].score.ToString("D7") + "    " + GM.HiScores[0].name + "\r\n" +
                "2.    " + GM.HiScores[1].score.ToString("D7") + "    " + GM.HiScores[1].name + "\r\n" +
                "3.    " + GM.HiScores[2].score.ToString("D7") + "    " + GM.HiScores[2].name + "\r\n" +
                "4.    " + GM.HiScores[3].score.ToString("D7") + "    " + GM.HiScores[3].name + "\r\n" +
                "5.    " + GM.HiScores[4].score.ToString("D7") + "    " + GM.HiScores[4].name);
        }

        private void mainPanel_Click(object sender, EventArgs e)
        {
            GM.UserInput(Keys.A, true);
        }

        private void lblMenuStart_Click(object sender, EventArgs e)
        {
            GM.UserInput(Keys.A, true);
        }
    }
}
