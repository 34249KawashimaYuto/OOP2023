using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSample {

    class Program {
        static void Main(string[] args) {
            #region P26のサンプルプログラム
            //インスタンスの作成
            //Product karinto = new Product(123, "かりんとう", 180);
            //Product daifuku = new Product(235, "大福もち", 160);

            //Console.WriteLine("かりんとうの税込価格：" + karinto.GetPriceIncludingTax());
            //Console.WriteLine("大福もちの税込価格：" + daifuku.GetPriceIncludingTax());
            #endregion

            #region 演習1
            ////DateTime date = new DateTime(2023, 5, 8);

            ////今日の日付を求める
            //DateTime date = DateTime.Today;
            //Console.WriteLine("今日の日付：" + date.ToString("yyyy年MM日dd日"));

            ////10日後を求める
            //DateTime daysAfter10 = date.AddDays(10);
            //Console.WriteLine("10日後：" + daysAfter10.ToString("yyyy年MM日dd日"));

            ////10日前を求める
            //DateTime daysBefore10 = date.AddDays(-10);
            //Console.WriteLine("10日前：" + daysBefore10.ToString("yyyy年MM日dd日"));
            #endregion

            #region 演習2
            string[] DayOfWeekJp = { "日曜日", "月曜日", "火曜日", "水曜日", "木曜日", "金曜日", "土曜日" };

            Console.Write("西暦：");
            int birthYear = int.Parse(Console.ReadLine());
            Console.Write("月：");
            int birthMonth = int.Parse(Console.ReadLine());
            Console.Write("日：");
            int birthDay = int.Parse(Console.ReadLine());

            DateTime birth = new DateTime(birthYear, birthMonth, birthDay);//日付型に
            DateTime today = DateTime.Today;
            TimeSpan timespan = today.Subtract(birth);//日付の計算
            Console.WriteLine("あなたが生まれてから今日まで{0}日目です。",timespan.Days);
            Console.WriteLine(DayOfWeekJp[(int)(birth.DayOfWeek)]);
            #endregion
        }
    }
}