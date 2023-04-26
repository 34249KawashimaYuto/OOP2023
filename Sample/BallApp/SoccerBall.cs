﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    class SoccerBall:Obj{

        Random random= new Random();   //乱数インスタンス

        private static int count;
        public static int Count { get => count; set => count = value; }

        //コンストラクタ
        public SoccerBall(double xp, double yp)
            :base(xp, yp, @"pic\soccer_ball.png"){

            int rndX = random.Next(-25, 25);
            MoveX = (rndX != 0 ? rndX : 1);
            int rndY = random.Next(-25, 25);
            MoveY = (rndY != 0 ? rndX : 1);

            Count++;
        }

        //メソッド
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
