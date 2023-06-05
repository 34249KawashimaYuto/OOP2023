using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {
            var text = "Jackdaws love my big sphinx of quartz";

            Exercise3_1(text);
            Console.WriteLine("----------");

            Exercise3_2(text);
            Console.WriteLine("----------");

            Exercise3_3(text);
            Console.WriteLine("----------");

            Exercise3_4(text);
            Console.WriteLine("----------");

            Exercise3_5(text);
        }

        private static void Exercise3_1(string text) {
            var count = 0;
            foreach(var c in text) {
                if(c == ' ') {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        private static void Exercise3_2(string text) {
            Console.WriteLine(text.Replace("big", "small"));
        }

        private static void Exercise3_3(string text) {
            var words = text.Split(' ');
            Console.WriteLine(words.Length);
        }

        private static void Exercise3_4(string text) {
            foreach (var word in text.Split(' ')) {
                if(word.Length <= 4) {
                    Console.WriteLine(word);
                }
            }
        }

        private static void Exercise3_5(string text) {
            StringBuilder sb = new StringBuilder("");
            foreach (var item in text.Split(' ')) {
                sb.AppendFormat("{0} ", item);
            }
            Console.WriteLine(sb);

        }
    }
}
