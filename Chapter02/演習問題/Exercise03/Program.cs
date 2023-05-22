using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("**売上集計**");
            Console.WriteLine("1 店舗別売り上げ");
            Console.WriteLine("2 商品カテゴリー別売り上げ");
            Console.Write("＞ ");
            string choice = Console.ReadLine();
            var sales = new SalesCounter(@"data\sales.csv");
            var amount = sales.GetPerStoreSales();//初期値として店舗別を設定
            switch (int.Parse(choice)) {
                case 2:
                    //カテゴリー別売上
                    amount = sales.GetPerCategorySales();                    
                    break;
            }
            foreach (KeyValuePair<string, int> obj in amount) {
                Console.WriteLine("{0} {1:C}", obj.Key, obj.Value);
            }
        }
    }
}
