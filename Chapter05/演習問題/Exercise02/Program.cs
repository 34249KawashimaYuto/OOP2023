using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            Console.Write("数値：");
            int.TryParse(Console.ReadLine(),out int result);
            var addComma = result.ToString("#,0");

            Console.WriteLine(result);
            Console.WriteLine(addComma);
        }
    }
}
