using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class Bar : Obj {
        public Bar(double xp, double yp): base(xp, yp, @"pic\bar.png")
        {
            base.MoveX = xp;
            base.MoveY = yp;
        }
        //抽象クラスを継承しているので、不要なメソッドは空にする
        public override void Move(PictureBox pbBar, PictureBox pbBall) {
        }

        public override void Move(Keys direction) {
            if(direction == Keys.Right)
            {
                if (PosX < 630)
                {
                    PosX += 20;
                }
               
            }else if(direction == Keys.Left)
            {
                if (PosX > 10)
                {
                    PosX -= 20;
                }
                
            }
            

        }

    }
}
