using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    class TennisBall : Obj {

        Random random = new Random();   //乱数インスタンス

        public TennisBall(double xp, double yp)
            : base(xp, yp, @"pic\tennis_ball.png") {

            int rndX = random.Next(-20, 30);
            MoveX = (rndX != 0 ? rndX : 1);
            int rndY = random.Next(-20, 30);
            MoveY = (rndY != 0 ? rndX : 1);
        }
        public override void Move() {
            if (PosX > 730 || PosX < 0)
            {
                MoveX = -MoveX;
            }
            if (PosY > 520 || PosY < 0)
            {
                MoveY = -MoveY;
            }
            PosX += MoveX;
            PosY += MoveY;
        }
    }
}
