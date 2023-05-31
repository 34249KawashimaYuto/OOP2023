using Exercise01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            #region 4.1動作確認
            //var ym = new YearMonth(2023, 12);
            //var c21 = ym.Is21Century;
            //var ymNextMonth = ym.AddOneMonth();

            //Console.WriteLine(ym);
            //Console.WriteLine(ymNextMonth);
            #endregion

            // 4.2.1
            var ymCollection = new YearMonth[] {
                new YearMonth(1980, 1),
                new YearMonth(1990, 4),
                new YearMonth(2000, 7),
                new YearMonth(2010, 9),
                new YearMonth(2020, 12),
            };

            // 4.2.2
            Console.WriteLine("\n- 4.2.2 ---");
            Exercise2_2(ymCollection);
            Console.WriteLine("\n- 4.2.4 ---");

            // 4.2.4
            Exercise2_4(ymCollection);
            Console.WriteLine("\n- 4.2.5 ---");


            // 4.2.5
            Exercise2_5(ymCollection);
        }

        private static void Exercise2_2(YearMonth[] ymCollection) {
            foreach (var yearMonth in ymCollection) {
                Console.WriteLine(yearMonth);
            }
        }

        //4.2.3
        static YearMonth FindFirst21C(YearMonth[] yms) {
            foreach (var findFirst in yms) {
                if (findFirst.Is21Century) {
                    return findFirst;
                }
            }
            return null;
        }

        private static void Exercise2_4(YearMonth[] ymCollection) {
            var find = FindFirst21C(ymCollection);
            Console.WriteLine(find?.ToString() ?? "21世紀のデータはありません");
        }

        private static void Exercise2_5(YearMonth[] ymCollection) {
            var array = ymCollection.Select(ym => ym.AddOneMonth()).OrderBy(ym => ym.Year).ToArray();
            Exercise2_2(array);
        }
    }
}
