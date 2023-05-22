using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {
            var sales = new SalesCounter(@"data\sales.csv");
            //店舗別売上
            //var amountPerStore = sales.GetPerStoreSales();
            //foreach (KeyValuePair<string, int> obj in amountPerStore) {
            //    Console.WriteLine("{0} {1:C}", obj.Key, obj.Value);
            //}
            //カテゴリー別売上
            var amountPerCategory = sales.GetPerCategorySales();
            foreach (KeyValuePair<string, int> obj in amountPerCategory) {
                Console.WriteLine("{0} {1:C}", obj.Key, obj.Value);
            }
        }
    }
}
