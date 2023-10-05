using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            Pickup3DigitNumber("sample.txt");
        }

        private static void Pickup3DigitNumber(string file) {
            foreach (var line in File.ReadLines(file)) {
                var regex = new Regex(@"^\d{3}\d*$");
                foreach (var words in line.Split(new char[] { ' ', }, StringSplitOptions.RemoveEmptyEntries)) {
                    if (regex.IsMatch(words))
                        Console.WriteLine(words);
                }
            }
        }
    }
}
