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

            //県庁所在地の登録
            string prefecture;
            string city;

            Console.WriteLine("県庁所在地の登録");
            Console.Write("県名：");
            prefecture = Console.ReadLine();

            while (prefecture != "999") {
                Console.Write("所在地：");
                city = Console.ReadLine();

                //既に県名が存在するか？
                if (Prefectural.ContainsKey(prefecture)) {
                    Console.WriteLine("既に県名が登録されています");
                    Console.Write("上書きしますか？(y/n)：");
                    if (Console.ReadLine() == "y") {
                        Prefectural[prefecture] = city;
                    }
                }
                else {
                    Prefectural[prefecture] = city;
                }

                Console.Write("県名：");
                prefecture = Console.ReadLine();
            }

            //表示形式
            Console.WriteLine("1:一覧表示,2:県名指定");
            Console.Write(">");
            switch (Console.ReadLine()) {
                case "1":
                    foreach (var pref in Prefectural) {
                        Console.WriteLine("{0}({1})",pref.Key,pref.Value);
                    }
                    break;
                case "2":
                    Console.Write("県名を入力：");
                    Console.WriteLine("{0}です", Prefectural[Console.ReadLine()]);
                    break;
            }
#endif
        }
    }
}
