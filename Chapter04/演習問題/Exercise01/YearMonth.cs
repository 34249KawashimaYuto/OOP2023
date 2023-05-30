using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    public class YearMonth {
        public int Year { get; private set; }

        public int Month { get; private set; }

        //コンストラクタ
        public YearMonth(int year,int month) {
            Year = year;
            Month = month;
        }

        //4.1.2
        public bool Is21Century {
            get {
                return Year >= 2001 && Year <= 2100;
            }
        }

        //4.1.3
        public YearMonth AddOneMonth() {
            var addOneYear = Year;
            var addOneMonth = Month;
            if(Month == 12) {
                addOneYear++;
                addOneMonth++;
            }
           else {
                addOneMonth++;
            }
            return new YearMonth(addOneYear,addOneMonth);
        }

        //4.1.4
        //public override string ToString() {
            //return "{0}日{1}月,";
        //}
    }
}
