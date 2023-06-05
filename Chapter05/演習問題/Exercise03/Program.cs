﻿using System;
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
            var spaces = text.Count(n => n.ToString().Contains(' '));
            Console.WriteLine("空白数：{0}",spaces);
        }

        private static void Exercise3_2(string text) {
            Console.WriteLine(text.Replace("big", "small"));
        }

        private static void Exercise3_3(string text) {
            var words = text.Split(' ');
            Console.WriteLine("単語数：{0}",words.Length);
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
            foreach (var word in text.Split(' ')) {
                sb.AppendFormat("{0} ", word);
            }
            Console.WriteLine(sb);

        }
    }
}
