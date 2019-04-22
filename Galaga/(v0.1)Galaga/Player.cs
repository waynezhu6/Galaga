using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _v0._1_Galaga
{
    class Player
    {
        public Image img = new Bitmap("player.png");
        public Wave currentWave;
        public int Y = 540;
        public int X = 209;
        public Bullet bullet1, bullet2;
        public int remainingLives = 3;
        bool triggerDeathAnimation = false;
        int deathAnimationState = 0;
        public GameManager gameManager;

        public Player(Wave wave, GameManager GM)
        {
            currentWave = wave;
            bullet1 = new Bullet(this);
            bullet2 = new Bullet(this);
            gameManager = GM;
        }

        public void Draw(Graphics g)
        {           

            if(triggerDeathAnimation)
            {
                if(deathAnimationState < 5)
                {
                    img = new Bitmap("playerDie1.png");
                    deathAnimationState += 1;
                }
                else if(deathAnimationState < 10)
                {
                    img = new Bitmap("playerDie2.png");
                    deathAnimationState += 1;
                }
                else if(deathAnimationState < 15)
                {
                    img = new Bitmap("playerDie3.png");
                    deathAnimationState += 1;
                }
                else if(deathAnimationState < 20)
                {
                    img = new Bitmap("playerDie4.png");
                    deathAnimationState += 1;                   
                }
                else if(deathAnimationState < 25)
                {
                    img = new Bitmap(1, 1);
                    deathAnimationState += 1;
                }
                else if(deathAnimationState == 25)
                {
                    deathAnimationState = 0;
                    img = new Bitmap(1, 1);
                    triggerDeathAnimation = false;
                    gameManager.gameState = "DeathLimbo";                   
                }
                g.ResetTransform();
                g.DrawImage(img, X, Y, 36, 36);
            }
            else
            {
                Brush brush = new SolidBrush(Color.White);
                g.ResetTransform();
                bullet1.Draw(g);
                bullet2.Draw(g);
                g.DrawImage(img, X, Y, 36, 36);
            }
        }

        public void Update(bool left, bool right)
        {
            if(left && !right && X >= 24 && !triggerDeathAnimation)
            {
                X -= 4;
            }
            else if(!left && right && X <= 386 && !triggerDeathAnimation)
            {
                X += 4;
            }
            bullet1.Update();
            bullet2.Update();

            if(playerHitTest(X, Y))
            {
                triggerDeathAnimation = true;
            }
            
        }

        public void Shoot()
        {
            if(!bullet1.fired)
            {
                bullet1.Shoot(X);
            }
            else if(!bullet2.fired)
            {
                bullet2.Shoot(X);
            }          
        }

        public void HitTest(int x, int y, Bullet bullet)
        {
            if (currentWave.CheckCollision(x, y) || currentWave.CheckCollision(x + 10, y))
            {               
                bullet.Reset();
            }
        }

        public bool playerHitTest(int x, int y)
        {           
            if (currentWave.CheckCollision(x, y) || currentWave.CheckCollision(x + 36, y))
            {
                return true;
            }
            if (currentWave.CheckCollision(x, y + 36) || currentWave.CheckCollision(x, y + 36))
            {
                return true;
            }
            return false;
        }

    }
}
