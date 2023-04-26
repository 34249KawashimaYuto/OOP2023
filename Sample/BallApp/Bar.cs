using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class Bar : Obj {
        public Bar(double xp, double yp): base(350, 400, @"pic\bar.png")
        {
            base.MoveX = xp;
            base.MoveY = yp;
        }
        //抽象クラスを継承しているので、不要なメソッドは空にする
        public override void Move() {
        }

        public void Move(Keys direction) {
            int stop = 1;
            if(direction == Keys.Right)
            {
                if (PosX == 600)
                {
                    stop = 0;
                }
                PosX = PosX + (20 * stop);
            }else if(direction == Keys.Left)
            {
                PosX -= 20;
            }
            

        }
    }
}
