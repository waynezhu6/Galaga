using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _v0._1_Galaga
{
    class Wave
    {
        int tick = 0;
        int movecount = 0;
        int killCount = 0;
        bool inPlace = false; //true if every enemy has deployed
        Random r = new Random();
        GameManager gameManager;
        public Enemy[] enemiesArray = new Enemy[0];
        public bool visible = true;

        public Wave(GameManager GM)
        {
            gameManager = GM;

            for (int i = 0; i < 40; i++) //specify different enemy types here
            {
                Array.Resize(ref enemiesArray, enemiesArray.Length + 1);
                Enemy temp;
                if(i < 4)
                {
                    temp = new RedEnemy(new PathManager(i));
                }
                else if(i < 8)
                {
                    temp = new BlueEnemy(new PathManager(i));
                }
                else if(i < 12)
                {
                    temp = new BossEnemy(new PathManager(i));
                }
                else if(i < 16)
                {
                    temp = new RedEnemy(new PathManager(i));
                }
                else if(i < 24)
                {
                    temp = new RedEnemy(new PathManager(i));
                }
                else if(i < 32)
                {
                    temp = new BlueEnemy(new PathManager(i));
                }
                else
                {
                    temp = new BlueEnemy(new PathManager(i));
                }
                temp.alive = true;
                enemiesArray[enemiesArray.Length - 1] = temp;
                enemiesArray[enemiesArray.Length - 1].defaultPath.parentEnemy = enemiesArray[enemiesArray.Length - 1];
            }

        }

        public void Update()
        {
            tick += 1;
            if (tick % 10 == 1 && movecount < 4)
            {
                enemiesArray[movecount].moving = true;
                enemiesArray[movecount + 4].moving = true;

                movecount += 1;
            }
            else if (tick % 10 == 1 && tick > 0 && movecount < 8)
            {
                enemiesArray[movecount + 4].moving = true;
                enemiesArray[movecount + 8].moving = true;

                movecount += 1;
            }
            else if (tick % 10 == 1 && tick > 0 && movecount < 12)
            {
                enemiesArray[movecount + 8].moving = true;
                enemiesArray[movecount + 12].moving = true;

                movecount += 1;
            }
            else if (tick % 10 == 1 && tick > 0 && movecount < 16)
            {
                enemiesArray[movecount + 12].moving = true;
                enemiesArray[movecount + 16].moving = true;

                movecount += 1;
            }
            else if (tick % 10 == 1 && tick > 0 && movecount < 20)
            {
                enemiesArray[movecount + 16].moving = true;
                enemiesArray[movecount + 20].moving = true;

                movecount += 1;
            }
            else if (tick % 15 == 1 && tick > 500 && gameManager.gameState == "Gameplay")
            {
                inPlace = true;
                Scramble();
            }

        }

        public void Draw(Graphics g)
        {
            if(visible)
            {
                for (int i = 0; i < enemiesArray.Length; i++)
                {
                    if (enemiesArray[i].alive || enemiesArray[i].triggerDeathAnimation == true)
                    {
                        enemiesArray[i].Draw(g);
                    }
                }
            }
            
        }

        public void Next()
        {
            for (int i = 0; i < enemiesArray.Length; i++)
            {
                if (enemiesArray[i].moving && enemiesArray[i].alive)
                {
                    enemiesArray[i].Next();
                }
            }
        }

        public bool CheckCollision(int x, int y)
        {
            for (int i = 0; i < enemiesArray.Length; i++)
            {
                if(enemiesArray[i].alive)
                {
                    if (enemiesArray[i].HitTest(x, y))
                    {
                        killCount += 1;

                        if (enemiesArray[i].type == "BlueEnemy")
                        {
                            if (enemiesArray[i].scramble)
                            {
                                gameManager.score += 100;
                            }
                            else
                            {
                                gameManager.score += 50;
                            }
                        }
                        else if (enemiesArray[i].type == "RedEnemy")
                        {
                            if (enemiesArray[i].scramble)
                            {
                                gameManager.score += 160;
                            }
                            else
                            {
                                gameManager.score += 80;
                            }
                        }
                        else if (enemiesArray[i].type == "BossEnemy")
                        {
                            if (enemiesArray[i].scramble)
                            {
                                gameManager.score += 150;
                            }
                            else
                            {
                                gameManager.score += 400;
                            }
                        }

                        enemiesArray[i].triggerDeathAnimation = true;
                        enemiesArray[i].alive = false;
                        if (killCount == 40)
                        {
                            gameManager.gameState = "WaveTransition";
                        }
                        return true;
                    }
                }               
            }
            return false;
        }

        public void Scramble()
        {
            int enemyID = r.Next(0, enemiesArray.Length - 1);
            Enemy temp = enemiesArray[enemyID];

            if (!temp.scramble)
            {
                temp.defaultPath = new PathManager(temp.locX, temp.locY);
                temp.defaultPath.parentEnemy = temp;
                temp.scramble = true;
            }
        }

        public bool AllPathsComplete()
        {
            for(int i = 0; i < enemiesArray.Length; i++)
            {
                if (enemiesArray[i].alive)
                {
                    if (!enemiesArray[i].defaultPath.finished)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

    }
}
