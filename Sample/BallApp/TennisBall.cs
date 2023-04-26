using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class TennisBall : Obj {

        Random random = new Random();   //乱数インスタンス
        private static int count;
        public static int Count { get => count; set => count = value; }

        public TennisBall(double xp, double yp)
            : base(xp, yp, @"pic\tennis_ball.png") {

            int rndX = random.Next(-20, 30);
            MoveX = (rndX != 0 ? rndX : 1);
            int rndY = random.Next(-20, 30);
            MoveY = (rndY != 0 ? rndX : 1);

            Count++;
        }
        public override void Move(PictureBox pbBar, PictureBox pbBall) {
            Rectangle rBar = new Rectangle(pbBar.Location.X, pbBar.Location.Y,
                                           pbBar.Width, pbBar.Height);
            Rectangle rBall = new Rectangle(pbBall.Location.X, pbBall.Location.Y,
                                            pbBall.Width, pbBall.Height);
            if (PosX > 730 || PosX < 0)
            {
                MoveX = -MoveX;
            }
            if (PosY > 520 || PosY < 0 || rBar.IntersectsWith(rBall))
            {
                MoveY = -MoveY;
            }
            PosX += MoveX;
            PosY += MoveY;
        }
        public override void Move(Keys direction) {
        }
    }
}
