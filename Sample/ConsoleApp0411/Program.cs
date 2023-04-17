using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0411 {
    class Program {
        static void Main(string[] args) {
            /*int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                for (int k = 0; k < count - i; k++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine();
                for (int j = 0; j < (i + 1); j++)
                {
                    Console.Write(" ");
                }
            }*/
            int[] currencyInt = { 10000, 5000, 2000, 1000, 500, 100, 50, 10, 5, 1 };//貨幣の種類
            string[] currencyStr = { "一万円札", "五千円札", "二千円札", "千円札",
                                     "五百円玉", "百円玉", "五十円玉",
                                     "十円玉", "五円玉", "一円玉"};//貨幣の種類（全角）

            Console.Write("金額:");
            int price = int.Parse(Console.ReadLine());
            Console.Write("支払:");
            int payment = int.Parse(Console.ReadLine());
            int change = payment - price;
            Console.WriteLine("お釣:{0}円", change);//釣り金額表示
            
            int sho = 0;
            int amr = change;
            for (int i = 0; i < currencyInt.Length; i++)
            {
                sho = amr / currencyInt[i];//貨幣の数を算出
                amr = amr % currencyInt[i];//釣り銭の残金の算出
                Console.Write(currencyStr[i].PadLeft(4, '　') + ":");
                astOut(sho);
            }
        }
        private static void astOut(int sho) {
                for (int j = 0; j < sho; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
        }
    }
}
