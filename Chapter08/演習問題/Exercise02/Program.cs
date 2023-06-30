using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            var dateTime = DateTime.Today;
            Console.WriteLine(NextDay(dateTime, DayOfWeek.Monday).ToString("yyyy年M月d日(ddd)"));
        }

        private static DateTime NextDay(DateTime dateTime, DayOfWeek dayOfWeek) {
            var days = (int)dayOfWeek - (int)dateTime.DayOfWeek;    //指定曜日と本日の曜日の差を求める
            return dateTime.AddDays(days + 7);
        }
    }
}
