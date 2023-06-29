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
        }
    }
}
