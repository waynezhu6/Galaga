using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _v0._1_Galaga
{
    class RedEnemy : Enemy
    {
        public RedEnemy(Path path): base(path)
        {
            img = new Bitmap("redEnemy.png");
            type = "RedEnemy";
        }
    }
}
