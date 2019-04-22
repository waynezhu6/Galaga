using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace _v0._1_Galaga
{
    class Bullet
    {
        //string path = Directory.GetCurrentDirectory();     
        Image img = new Bitmap("bullet.png");
        Player parentPlayer;
        public int locX = -100;
        public int locY = -100;
        public bool fired = false;

        public Bullet(Player p)
        {
            parentPlayer = p;
        }

        public void Update()
        {
            if(!fired)
            {
                locX = -100;
                locY = -100;
            }
            else
            {
                locY -= 12;
                if(locY < -40)
                {
                    fired = false;
                }
            }
            parentPlayer.HitTest(locX, locY, this);
            
        }

        public void Draw(Graphics g)
        {
            SolidBrush brush = new SolidBrush(Color.White);

            g.ResetTransform();
            //g.FillRectangle(brush, locX, locY, 8, 15);
            g.DrawImage(img, locX, locY, 10, 30);
        }

        public void Shoot(int x)
        {
            locX = x + 11;
            locY = 540;
            fired = true;
        }

        public void Reset()
        {
            fired = false;
            locX = -100;
            locY = -100;
        }
    }
}
