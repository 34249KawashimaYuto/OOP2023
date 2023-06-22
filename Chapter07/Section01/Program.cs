using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
#if false
            #region
            var flowerDict = new Dictionary<string, int>()
            {
                ["sunflower"] = 400,
                ["pansy"] = 300,
                ["tulip"] = 350,
                ["rose"] = 500,
                ["dahlia"] = 450,
            };

            //あさがお（250円）を追加
            flowerDict["morning glory"] = 250;

            Console.WriteLine("ひまわりの価格は{0}円です。",flowerDict["sunflower"]);
            Console.WriteLine("チューリップの価格は{0}円です。",flowerDict["tulip"]);
            Console.WriteLine("あさがおの価格は{0}円です。", flowerDict["morning glory"]);
            #endregion
#else
            var Prefectural = new Dictionary<string, string>() { };

            var prefecture = "";
            var city = "";
            var sw = "y";

            Console.WriteLine("県庁所在地の登録");

            Console.Write("県名：");
            prefecture = Console.ReadLine();

            while (prefecture != "999") {
                if (Prefectural.ContainsKey(prefecture)) {
                    Console.WriteLine("--既に登録されています--");
                    Console.Write("上書きしますか？(y/n)：");
                    sw = Console.ReadLine();
                }
                switch (sw) {
                    case "y":
                        Console.Write("所在地：");
                        city = Console.ReadLine();
                        Prefectural[prefecture] = city;
                        break;
                    case "n":
                        sw = "y";
                        break;
                }

                Console.Write("県名：");
                prefecture = Console.ReadLine();
            }
            Console.Write("県名を入力：");
            string search = Console.ReadLine();
            Console.WriteLine("{0}です。", Prefectural[search]);
#endif
        }
    }
}
