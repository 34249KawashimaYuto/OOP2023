using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    class SoccerBall {
        //フィールド
        private Image image;    //画像データ

        private double posX;    //X座標
        private double posY;    //Y座標

        private double moveX;   //移動量（ｘ方向）
        private double moveY;   //移動量（ｙ方向）

        Random random= new Random();   //乱数インスタンス

        public SoccerBall(double xp, double yp) {
            Image = Image.FromFile(@"pic\soccer_ball.png");
            PosX = xp;
            PosY = yp;

            int rndX = random.Next(-15, 15);
            moveX = (rndX != 0 ? rndX : 1);
            int rndY = random.Next(-15, 15);
            moveY = (rndY != 0 ? rndX : 1);
        }

        //プロパティ
        public double PosX { get => posX; set => posX = value; }
        public double PosY { get => posY; set => posY = value; }
        public Image Image { get => image; set => image = value; }

        //メソッド
        public void Move() {
            if (posX > 730 || posX < 0)
            {
                moveX = -moveX;
            }
            if (posY > 500 || posY < 0)
            {
                moveY = -moveY;
            }
            posX += moveX;
            posY += moveY;

            
            
        }
    }
}
