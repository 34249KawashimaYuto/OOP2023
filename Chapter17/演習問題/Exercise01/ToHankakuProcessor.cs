using Exercise01.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise01 {
    class ToHankakuProcessor :Framework.ITextFileService{
        private List<string> _line = new List<string>();
        private static Dictionary<char, char> dictionary = new Dictionary<char, char>()
        {
            {'０','0'},{'１','1'},{'２','2'},{'３','3'},{'４','4'},{'５','5'},{'６','6'},{'７','7'},{'８','8'},{ '９','9'},
        };
        void ITextFileService.Initialize(string fname) {
        }

        void ITextFileService.Execute(string line) {
            var str = line;
            foreach (var num in dictionary) {
                str = Regex.Replace(str, num.Key.ToString(), num.Value.ToString());
            }
            _line.Add(str);
        }

        void ITextFileService.Terminate() {
            foreach (var item in _line) {
                Console.WriteLine(item);
            }
        }
    }
}
