#define NonArray
//#define StringArray

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04 {
    class Program {
        static void Main(string[] args) {
#if NonArray
            var line = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";
#elif StringArray
            string[] lines = {
                "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886",
                "Novelist=夏目漱石;BestWork=坊ちゃん;Born=1867",
                "Novelist=太宰治;BestWork=人間失格;Born=1909",
                "Novelist=宮沢賢治;BestWork=銀河鉄道の夜;Born=1896",
            };

#endif
            var sw = 0;
            foreach (var semicolon in line.Split(';')) {
                foreach (var equal in semicolon.Split('=')) {
                    if (sw % 2 == 0) {
                        Console.Write("{0}：", Item(equal));
                    }
                    else {
                        Console.WriteLine(equal);
                    }
                    sw++;
                }
            }
        }
        //項目名を返すメソッド
        private static string Item(string item) {
            string returnItem = "";
            switch (item) {
                case "Novelist":
                    returnItem = "作家　";
                    break;
                case "BestWork":
                    returnItem = "代表作";
                    break;
                case "Born":
                    returnItem = "誕生年";
                    break;
            }
            return returnItem;
        }
    }
}
