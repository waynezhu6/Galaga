using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;

namespace _v0._1_Galaga
{
    class GameManager
    {
        //Intro - displaying splash screen and player select
        //Ready - delay before gameplay starts
        //Gameplay - playing of the game has initialized
        //Gameover - game over when player runs out of lives 
        //WaveTransition - one wave is finished, and loading another
        public string gameState = "Intro";
        Wave currentWave;
        Player player;
        bool leftDown = false;
        bool rightDown = false;
        int iteration = 0;
        MainForm mainForm;
        public int score = 0;
        bool canStart = false;
        public Scores[] HiScores = new Scores[6];
        int waveNumber = 1;

        public static string iInitials;

        public GameManager(MainForm form)
        {
            GetScores();
            mainForm = form;
            currentWave = new Wave(this);
            player = new Player(currentWave, this);
        }

        public struct Scores
        {
            public string name;
            public int score;
        }

        public void GetScores()
        {
            try
            {
                string strInput;
                string[] splittedString;
                int index = 0;

                TextReader tr = new StreamReader("Scores.txt");

                while ((strInput = tr.ReadLine()) != null)
                {
                    splittedString = strInput.Split(' ');
                    HiScores[index].score = Convert.ToInt32(splittedString[0]);
                    HiScores[index].name = splittedString[1];
                    index++;
                }
                tr.Close();
            }
            catch
            {
                MessageBox.Show("File Error");
            }
        }

        public void AddScore(int newScore)
        {
            bool Higher = false;
            int i;
            for (i = 0; i < 5; i++)
            {
                if (newScore > HiScores[i].score)
                {
                    Higher = true;
                    break;
                }
            }

            if (Higher)
            {
                mainForm.gameTimer.Stop();
                HiScore HS = new HiScore(score, mainForm);
                HS.ShowDialog();
                iInitials = HS.initials;

                for (int index = 4; index >= i; index--) //shuffles scores down
                {
                    HiScores[index + 1].score = HiScores[index].score;
                    HiScores[index + 1].name = HiScores[index].name;
                }
                HiScores[i].score = newScore;
                HiScores[i].name = iInitials;
            }
        }

        public void FormClosed()
        {
            try
            {
                TextWriter tw = new StreamWriter("Scores.txt", false);

                for (int i = 0; i < 5; i++)
                {
                    if(HiScores[i].name == "")
                    {
                        HiScores[i].name = " ";
                    }
                    tw.WriteLine(HiScores[i].score + " " + HiScores[i].name);
                }
                tw.Close();
            }
            catch
            {
                MessageBox.Show("Saving Error");
            }
        }

        public void Next()
        {
            if (gameState == "Intro")
            {
                if (iteration == 0)
                {
                    currentWave.visible = false;
                    mainForm.pBoxLogo.Invoke(new Action(() => mainForm.pBoxLogo.Location = new Point(72, 110)));
                    mainForm.lbl1Up.Invoke(new Action(() => mainForm.lbl1Up.Location = new Point(12, 41)));
                    mainForm.lblHiScore.Invoke(new Action(() => mainForm.lblHiScore.Location = new Point(267, 41)));
                    mainForm.lbl1UpScore.Invoke(new Action(() => mainForm.lbl1UpScore.Location = new Point(20, 74)));
                    mainForm.lblHiScoreScore.Invoke(new Action(() => mainForm.lblHiScoreScore.Location = new Point(430 - mainForm.lblHiScoreScore.Size.Width, 74)));

                    canStart = false;
                    mainForm.menuStrip.Invoke(new Action(() => mainForm.menuStrip.Enabled = true));
                    mainForm.menuStrip.Invoke(new Action(() => mainForm.menuStrip.Visible = true));

                    mainForm.lblStart.Invoke(new Action(() => mainForm.lblStart.Location = new Point(-100, -100)));
                    mainForm.lblScore.Invoke(new Action(() => mainForm.lblScore.Location = new Point(-100, -100)));
                }
                else if (iteration > 150)
                {
                    canStart = true;
                    mainForm.lblMenuStart.Invoke(new Action(() => mainForm.lblMenuStart.Location = new Point(170, 495)));
                    mainForm.lblMenuStart.Invoke(new Action(() => mainForm.lblMenuStart.Visible = true));
                }             
                iteration += 1;              

            }
            else if(gameState == "Ready")
            {
                if(iteration < 5)
                {
                    currentWave.visible = true;
                    mainForm.pBoxLogo.Invoke(new Action(() => mainForm.pBoxLogo.Location = new Point(-300, -300)));
                    mainForm.lblMenuStart.Invoke(new Action(() => mainForm.lblMenuStart.Location = new Point(-100, -100)));
                    mainForm.lbl1Up.Invoke(new Action(() => mainForm.lbl1Up.Location = new Point(-100, -100)));
                    mainForm.lblHiScore.Invoke(new Action(() => mainForm.lblHiScore.Location = new Point(-100, -100)));
                    mainForm.lbl1UpScore.Invoke(new Action(() => mainForm.lbl1UpScore.Location = new Point(-100, -100)));
                    mainForm.lblHiScoreScore.Invoke(new Action(() => mainForm.lblHiScoreScore.Location = new Point(-100, -100)));

                    mainForm.menuStrip.Invoke(new Action(() => mainForm.menuStrip.Enabled = false));
                    mainForm.menuStrip.Invoke(new Action(() => mainForm.menuStrip.Visible = false));

                    mainForm.lblScore.Invoke(new Action(() => mainForm.lblScore.Text = "Score: " + Convert.ToString(score).ToUpper()));
                    mainForm.lblScore.Invoke(new Action(() => mainForm.lblScore.Font = new Font("Copperplate Gothic Bold", 10, FontStyle.Regular)));
                    mainForm.lblScore.Invoke(new Action(() => mainForm.lblScore.ForeColor = Color.Red));
                    mainForm.lblScore.Invoke(new Action(() => mainForm.lblScore.BackColor = Color.Transparent));
                    mainForm.lblScore.Invoke(new Action(() => mainForm.lblScore.Location = new Point(430 - mainForm.lblScore.Size.Width, 20)));
                }             

                if (iteration < 30)
                {                 
                    iteration += 1;
                }
                else if(iteration < 180)
                {
                    if(iteration == 30)
                    {
                        player.img = new Bitmap("player.png");
                    }

                    if (iteration == 30)
                    {
                        mainForm.lblStart.Invoke(new Action(() => mainForm.lblStart.Text = "Ready"));
                        mainForm.lblStart.Invoke(new Action(() => mainForm.lblStart.Font = new Font("Copperplate Gothic Bold", 24, FontStyle.Bold)));
                        mainForm.lblStart.Invoke(new Action(() => mainForm.lblStart.ForeColor = Color.Red));
                        mainForm.lblStart.Invoke(new Action(() => mainForm.lblStart.BackColor = Color.Transparent));
                        mainForm.lblStart.Invoke(new Action(() => mainForm.lblStart.Location = new Point(160, 240)));
                    }                   
                    iteration += 1;
                }
                else if(iteration < 240)
                {          
                    if(iteration == 180)
                    {
                            mainForm.lblStart.Invoke(new Action(() => mainForm.lblStart.Location = new Point(-100, -100)));
                        }                         
                    iteration += 1;
                }
                else
                {
                    iteration = 0;
                    gameState = "Gameplay";                  
                }
            }
            else if(gameState == "Gameplay")
            {
                mainForm.lblScore.Invoke(new Action(() => mainForm.lblScore.Location = new Point(430 - mainForm.lblScore.Size.Width, 20)));
                mainForm.lblScore.Invoke(new Action(() => mainForm.lblScore.Text = "Score: " + Convert.ToString(score).ToUpper()));
                currentWave.Update();
                currentWave.Next();
                player.Update(leftDown, rightDown);
            }
            else if(gameState == "DeathLimbo")
            {
                if(iteration == 0)
                {
                    player.remainingLives -= 1;
                    iteration += 1;
                }
                
                if(player.remainingLives == 0)
                {
                    iteration = 0;
                    player.remainingLives = 3;
                    gameState = "Game Over";
                }

                if(currentWave.AllPathsComplete() && !player.bullet1.fired && !player.bullet2.fired)
                {               
                    if(iteration == 1)
                    {
                        currentWave.Update();
                        currentWave.Next();
                    }
                    iteration += 1;
                }
                else
                {
                    player.bullet1.Update();
                    player.bullet2.Update();
                    currentWave.Update();
                    currentWave.Next();
                }
                
                if(iteration > 100)
                {
                    player.X = 220;
                    player.Y = 540;
                    iteration = 0;
                    gameState = "Ready";
                }
            }
            else if(gameState == "Game Over")
            {

                if (iteration < 100)
                {                   
                    iteration += 1;
                }
                else if (iteration < 300)
                {
                    if(iteration == 100)
                    {
                            mainForm.lblStart.Invoke(new Action(() => mainForm.lblStart.Text = "GAME OVER"));
                            mainForm.lblStart.Invoke(new Action(() => mainForm.lblStart.Location = new Point(110, 240)));
                    }                
                    iteration += 1;
                }
                else if(iteration < 420)
                {
                    if (iteration == 300)
                    {
                        AddScore(score);
                        score = 0;
                        mainForm.lblStart.Invoke(new Action(() => mainForm.lblStart.Location = new Point(-200, -200)));
                    }
                    iteration += 1;
                }
                else
                {
                    iteration = 0;
                    gameState = "Intro";
                }              
            }
            else if(gameState == "WaveTransition")
            {
                currentWave = new Wave(this);
                player.currentWave = currentWave;
                if(player.bullet1.fired || player.bullet2.fired)
                {
                    player.bullet1.Update();
                    player.bullet2.Update();
                }
                if(iteration < 50)
                {
                    iteration += 1;
                }
                else if (iteration < 120)
                {
                    waveNumber += 1;   
                    mainForm.lblStart.Invoke(new Action(() => mainForm.lblStart.Text = "Wave " + Convert.ToString(waveNumber)));
                    mainForm.lblStart.Invoke(new Action(() => mainForm.lblStart.Location = new Point(160, 240)));
                    iteration += 1;
                }
                else
                {
                    iteration = 0;
                    gameState = "Ready";
                }
            }
        }

        public void Draw(Graphics g)
        {
            g.InterpolationMode = InterpolationMode.NearestNeighbor;
            currentWave.Draw(g);
            player.Draw(g);
        }

        public void UserInput(Keys input, bool down)
        {
            if(down)
            {
                if (input == Keys.Left)
                {
                    leftDown = true;
                }
                if (input == Keys.Right)
                {
                    rightDown = true;
                }
                if ((input == Keys.Space || input == Keys.Up) && gameState == "Gameplay")
                {
                    player.Shoot();
                }

                if(gameState == "Intro")
                {
                    iteration = 0;
                    currentWave = new Wave(this);
                    player.currentWave = currentWave;
                    gameState = "Ready";                
                }
            }
            else
            {
                if (input == Keys.Left) //left
                {
                    leftDown = false;
                }
                if (input == Keys.Right) //right
                {
                    rightDown = false;
                }
            }
        }
    }
}
