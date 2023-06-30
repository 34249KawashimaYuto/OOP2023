using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            var abbrs = new Abbreviations();

            //addメソッドの呼び出し例
            abbrs.Add("IOP", "国際オリンピック委員会");
            abbrs.Add("NPT", "核兵器不拡散条約");

            //7.2.3(Countの呼び出し)
            var count = abbrs.Count;
            Console.WriteLine(count);

            Console.WriteLine();    //改行

            //7.2.3(Removeの呼び出し)
            Console.WriteLine(abbrs.Remove("IOP"));
            Console.WriteLine(abbrs.Remove("NPT"));

            Console.WriteLine();    //改行

            //7.2.4
            foreach (var item in abbrs.Where(d => d.Key.Length == 3)) {
                Console.WriteLine("{0}={1}", item.Key, item.Value);
            }



        }
    }
}
