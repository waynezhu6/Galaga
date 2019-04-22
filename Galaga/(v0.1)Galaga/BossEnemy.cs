using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _v0._1_Galaga
{
    class BossEnemy : Enemy
    {
        //int HPremaining = 1;
        public BossEnemy(Path path) : base(path)
        {
            img = new Bitmap("bossEnemy1.png");
            type = "BossEnemy";
        }
    }
}
