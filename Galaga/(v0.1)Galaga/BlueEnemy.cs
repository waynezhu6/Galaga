using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _v0._1_Galaga
{
    class BlueEnemy : Enemy
    {
        public BlueEnemy(Path path) :base(path)
        {
            img = new Bitmap("blueEnemy.png");
            type = "BlueEnemy";
        }
    }
}
