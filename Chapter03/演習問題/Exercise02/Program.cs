using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            var names = new List<string> {
                 "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
            };
            Exercise2_1(names);
            Console.WriteLine();
            Exercise2_2(names);
            Console.WriteLine();
            Exercise2_3(names);
            Console.WriteLine();
            Exercise2_4(names);
        }

        private static void Exercise2_1(List<string> names) {
            Console.WriteLine("*** 3.2.1 ***");
            string line;
            do {
                line = Console.ReadLine();
                if (string.IsNullOrEmpty(line))
                    break;
                Console.WriteLine(names.FindIndex(s => s == line));
            } while (true);
        }

        private static void Exercise2_2(List<string> names) {
            Console.WriteLine("*** 3.2.2 ***");
            Console.WriteLine(names.Count(n => n.Contains('o')));
            
        }

        private static void Exercise2_3(List<string> names) {
            Console.WriteLine("*** 3.2.3 ***");
            foreach (var item in names.Where(s => s.Contains('o'))) {
                Console.WriteLine(item);
            }
        }

        private static void Exercise2_4(List<string> names) {
            Console.WriteLine("*** 3.2.4 ***");
            foreach (var item in names.Where(s => s.StartsWith("B")).Select(s => s.Length)) {
                Console.WriteLine(item);
            }
        }
    }
}