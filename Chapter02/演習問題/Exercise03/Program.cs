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
            Console.WriteLine("1:店舗別売り上げ");
            Console.WriteLine("2:商品カテゴリー別売り上げ");
            Console.Write(">");
            int choice = int.Parse(Console.ReadLine());
            var sales = new SalesCounter(@"data\sales.csv");
            IDictionary<string, int> amount = new Dictionary<string, int>();
            switch (choice) {
                case 1:
                    //店舗別売り上げ
                    amount = sales.GetPerStoreSales();
                    break;
                case 2:
                    //商品カテゴリー別売り上げ
                    amount = sales.GetPerCategorySales();                    
                    break;
            }
            foreach (KeyValuePair<string, int> obj in amount) {
                Console.WriteLine("{0} {1:C}", obj.Key, obj.Value);
            }
        }
    }
}
