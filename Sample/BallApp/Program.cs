using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class Program : Form {
        private Timer moveTimer;
        private Obj ball;
        private PictureBox pb;
        Bar bar;
        PictureBox pbBar;

        private List<Obj> balls = new List<Obj>();//ボールインスタンス格納
        private List<PictureBox> pbs = new List<PictureBox>();  //表示用

        static void Main(string[] args) {
            Application.Run(new Program());
        }
        public Program() {
            
            //フォーム
            this.Size = new Size(800, 600);
            this.BackColor = Color.Green;
            
            this.Text = "BallGame （サッカーボール:0個  テニスボール:0個）";
            this.MouseClick += Program_MouseClick;
            this.KeyDown += Program_KeyDown;
            
            //バー
            bar = new Bar(340, 520);
            pbBar = new PictureBox();
            pbBar.Image = bar.Image;
            pbBar.Location = new Point((int)bar.PosX, (int)bar.PosY);
            pbBar.Size = new Size(150, 10);
            pbBar.SizeMode = PictureBoxSizeMode.StretchImage;  //画像の表示モード
            pbBar.Parent = this;

            //タイマー生成
            moveTimer = new Timer();
            moveTimer.Interval = 10; //タイマーのインターバル（ms）
            moveTimer.Tick += MoveTimer_Tick;   //デリゲート登録
        }

        //キーが押された時のイベントハンドラ
        private void Program_KeyDown(object sender, KeyEventArgs e) {
            bar.Move(e.KeyData);
            pbBar.Location = new Point((int)bar.PosX, (int)bar.PosY);

        }

        //マウスクリック時のイベントハンドラ
        private void Program_MouseClick(object sender, MouseEventArgs e) {
            //ボールインスタンス生成
            if (e.Button == MouseButtons.Left)
            {
                Build(e.X, e.Y, 0); //左クリック：サッカーボール 
            }
            else if(e.Button == MouseButtons.Right)
            {
                Build(e.X, e.Y, 1); //右クリック：テニスボール
            }
        }

        //タイマータイムアウト時のイベントハンドラ
        private void MoveTimer_Tick(object sender, EventArgs e) {
            for (int i = 0; i < balls.Count; i++)
            {
                balls[i].Move();  //移動
                pbs[i].Location = new Point((int)balls[i].PosX, (int)balls[i].PosY);
            }
        }

        //ボールインスタンス生成用メソッド
        public void Build(int x,int y,int sw) {

            pb = new PictureBox();   //画像を表示するコントロール
            if (sw == 0){
                ball = new SoccerBall(x - 25, y - 25);
                pb.Size = new Size(50, 50);
            }
            else if (sw ==1){ 
                ball = new TennisBall(x - 15, y - 15);
                pb.Size = new Size(25, 25);
            }
            
            pb.Image = ball.Image;
            pb.Location = new Point((int)ball.PosX, (int)ball.PosY);
            
            pb.SizeMode = PictureBoxSizeMode.StretchImage;  //画像の表示モード
            pb.Parent = this;

            this.Text = "BallGame （サッカーボール:" + SoccerBall.Count+ "個  テニスボール:"+ TennisBall.Count + "個）";

            balls.Add(ball);
            pbs.Add(pb);
            moveTimer.Start();  //タイマースタート
        }
    }
}
