using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btDayCalc_Click(object sender, EventArgs e) {
            var dtp = dtpDate.Value;
            var dateTime = DateTime.Now - dtp;
            tbMessage.Text = dtp.ToString("yy年M月d日") + "から" + dateTime.Days + "日経過";
        }
        //実行時に1度だけ呼ばれるメソッド
        private void Form1_Load(object sender,EventArgs e) {
            tbTime.Text = DateTime.Now.ToString("yyyy年MM月dd日(ddd) HH時mm分ss秒");
            tmTimeDisp.Start();
        }

        private void btAgeCalc_Click(object sender, EventArgs e) {
            var age = GetAge(dtpDate.Value, DateTime.Now);
            tbMessage.Text = "貴方は" + age + "歳です。";
        }
        public static int GetAge(DateTime birthday,DateTime targetDay) {
            var age = targetDay.Year - birthday.Year;
            if (targetDay < birthday.AddYears(age))
                age--;
            return age;
        }

        //タイマーイベントハンドラ
        private void tmTimeDisp_Tick(object sender, EventArgs e) {
            tbTime.Text = DateTime.Now.ToString("yyyy年MM月dd日(ddd) HH時mm分ss秒");
        }
    }
}
