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
            var spaces = text.Count(c => c.ToString().Contains(' '));
            Console.WriteLine("空白数：{0}",spaces);
        }

        private static void Exercise3_2(string text) {
            Console.WriteLine(text.Replace("big", "small"));
        }

        private static void Exercise3_3(string text) {
            var count = text.Split(' ').Length;
            Console.WriteLine("単語数：{0}",count);
        }

        private static void Exercise3_4(string text) {
            var words = text.Split(' ').Where(word => word.Length <= 4);
            foreach (var word in words)
                    Console.WriteLine(word);
        }

        private static void Exercise3_5(string text) {
            var array = text.Split(' ').ToArray();

            if (array.Length > 0) {
                var sb = new StringBuilder();
                foreach (var word in array) {
                    sb.AppendFormat("{0} ", word);
                }
                var cleateWords = sb.ToString().Trim();
                Console.WriteLine(cleateWords);
            }
        }
    }
}
