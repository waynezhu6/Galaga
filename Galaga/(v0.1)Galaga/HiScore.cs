using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace _v0._1_Galaga
{
    public partial class HiScore : Form
    {
        public HiScore(int score, MainForm MF)
        {
            InitializeComponent();
            TopMost = true;
            Focus();
            tempScore = score;
            mainForm = MF;
            lblScore.Text = Convert.ToString(tempScore);
            lblScore.Location = new Point(150 - lblScore.Size.Width / 2, lblScore.Location.Y);        
        }

        int tempScore = 0;
        int currentLetter = 0;
        MainForm mainForm;
        public string initials;

        private void lblSubmit_Click(object sender, EventArgs e)
        {
            if(initials != "")
            {
                mainForm.gameTimer.Start();
                Close();
            }          
        }

        private void HiScore_KeyDown(object sender, KeyEventArgs e)
        {
            if (currentLetter == 0)
            {
                if (e.KeyCode == Keys.Back)
                {
                    lblLetter1.Text = "__";
                }
                else if (Regex.IsMatch(e.KeyCode.ToString(), @"^[a-zA-Z]+$") && e.KeyCode.ToString().Length == 1)
                {
                    lblLetter1.Text = e.KeyCode.ToString();
                    currentLetter = 1;
                    lblLetter1.ForeColor = Color.Red;
                    lblLetter2.ForeColor = Color.White;
                }
            }
            else if (currentLetter == 1)
            {
                if (e.KeyCode == Keys.Back)
                {
                    lblLetter2.Text = "__";
                }
                else if (Regex.IsMatch(e.KeyCode.ToString(), @"^[a-zA-Z]+$") && e.KeyCode.ToString().Length == 1)
                {
                    lblLetter2.Text = e.KeyCode.ToString();
                    currentLetter = 2;
                    lblLetter2.ForeColor = Color.Red;
                    lblLetter3.ForeColor = Color.White;
                }
            }
            else
            {
                if (e.KeyCode == Keys.Back)
                {
                    lblLetter3.Text = "__";
                }
                else if (Regex.IsMatch(e.KeyCode.ToString(), @"^[a-zA-Z]+$") && e.KeyCode.ToString().Length == 1)
                {
                    lblLetter3.Text = e.KeyCode.ToString();
                    currentLetter = 0;
                    lblLetter3.ForeColor = Color.Red;
                    lblLetter1.ForeColor = Color.White;
                }
            }
            initials = lblLetter1.Text + lblLetter2.Text + lblLetter3.Text;
            
        }
    }
}
