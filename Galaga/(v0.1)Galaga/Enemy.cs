using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace _v0._1_Galaga
{
    class Enemy
    {
        public int locX; //x location on screen, top corner
        public int locY; //y location on screen, top corner
        public bool alive = true;
        public bool moving = false;

        public float angle = 0; //in degrees
        public Path defaultPath;
        Matrix result = new Matrix();
        //Matrix rotate = new Matrix();
        public bool scramble = false;
        public bool triggerDeathAnimation = false;
        int deathAnimationState = 0;
        public string type;

        public Size temp;
        public Image img;

        public Enemy(Path path)
        {
            defaultPath = path;
            locX = -100;
            locY = -100;
        }

        public void Next()
        {
            if (defaultPath.currentStep <= defaultPath.totalSteps)
            {
                Point testPoint = defaultPath.Next();
                locX = testPoint.X;
                locY = testPoint.Y;             
            }

        }

        public void Draw(Graphics g)
        {
            SolidBrush brush = new SolidBrush(Color.White);

            if (triggerDeathAnimation)
            {
                if (deathAnimationState < 5)
                {
                    img = new Bitmap("enemyDie1.png");
                    deathAnimationState += 1;
                }
                else if (deathAnimationState < 10)
                {
                    img = new Bitmap("enemyDie2.png");
                    deathAnimationState += 1;
                }
                else if (deathAnimationState < 15)
                {
                    img = new Bitmap("enemyDie3.png");
                    deathAnimationState += 1;
                }
                else if (deathAnimationState < 20)
                {
                    img = new Bitmap("enemyDie4.png");
                    deathAnimationState += 1;
                }
                else if (deathAnimationState < 25)
                {
                    img = new Bitmap(1, 1);
                    deathAnimationState += 1;
                }
                else
                {
                    triggerDeathAnimation = false;
                }
                g.ResetTransform();                
                g.DrawImage(img, locX, locY, 36, 36);
            }
            else
            {
                g.ResetTransform();
                
                /*if (defaultPath.currentStep > defaultPath.totalSteps)
                {
                    result.Reset();
                }
                else
                {
                    angle = defaultPath.GetAngle();
                    result.Reset();
                    result.RotateAt(angle, new Point(locX + 16, locY + 16)); //dependant on enemy sprite resolution
                }*/

                g.Transform = result;
                g.InterpolationMode = InterpolationMode.NearestNeighbor;
                g.DrawImage(img, locX, locY, 32, 32);
            }
                       
        }

        public bool HitTest(int x, int y)
        {
            Matrix rotate = new Matrix();
            if(Math.Abs(x - locX) < 40)
            {
                rotate.Reset();
                rotate.RotateAt((float)(-angle), new Point(locX + 10, locY + 10));

                Point[] temp = { new Point(x, y) };
                rotate.TransformPoints(temp);

                if (temp[0].X > locX && temp[0].X < locX + 32)
                {
                    if (temp[0].Y > locY && temp[0].Y < locY + 32)
                    {
                        return true;
                        
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            
        }

        public void Debug()
        {
            defaultPath.Debug();
        }
    }
}
