using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Section02 {
    class Program {
        static void Main(string[] args) {
#if false
            #region サンプルコード
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
            var Prefectural = new Dictionary<string, List<CityInfo>>() { };

            string prefecture, city, population;

            Console.WriteLine("<<都市の登録>>");
            Console.Write("県名：");
            prefecture = Console.ReadLine();

            //県名に"999"が入力されるまで
            while (Strings.StrConv(prefecture,VbStrConv.Narrow) != "999") {
                Console.Write("市町村：");
                city = Console.ReadLine();
                Console.Write("人口：");
                population = Strings.StrConv(Console.ReadLine(), VbStrConv.Narrow);

                //既に県名が存在するか？
                if (Prefectural.ContainsKey(prefecture)) {   
                    //存在する（市町村の追加）
                    Prefectural[prefecture].Add(new CityInfo { City = city, Population = int.Parse(population) });
                }
                else {
                    //存在しない（新規作成）
                    Prefectural[prefecture] = new List<CityInfo> { new CityInfo { City = city, Population = int.Parse(population) } };
                }

                Console.Write("県名：");
                prefecture = Console.ReadLine();
            }

            //表示形式
            Console.WriteLine("1:一覧表示,2:県名指定");
            Console.Write(">");
            switch (Strings.StrConv(Console.ReadLine(), VbStrConv.Narrow)) {
                //一覧表示
                case "1":
                    foreach (var prefList in Prefectural) {
                        foreach (var pref in prefList.Value) {
                            Console.WriteLine("{0}【{1}(人口:{2})】", prefList.Key, pref.City, pref.Population);
                        }                       
                    }
                    break;
                //県名指定
                case "2":
                    Console.Write("県名を入力：");
                    foreach (var searchPref in Prefectural.Where(p => p.Key == Console.ReadLine())) {
                        foreach (var pref in searchPref.Value) {
                            Console.WriteLine("{0}({1}人)です",pref.City,pref.Population);                            
                        }
                    }                    
                    break;
            }
#endif
        }
        class CityInfo {
            public string City { get; set; }   //都市
            public int Population { get; set; }    //人口
        }
    }
}
