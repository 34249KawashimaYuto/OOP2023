using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSample {
    //商品クラス
    class Product {
        //商品コード
        public int Code { get; set; }//自動実装プロパティ
        //商品名
        public string Name { get; set; }
        //商品価格（税抜き）
        public int Prise { get; set; }

        //コンストラクタ
        public Product(int code, string name, int price) {
            this.Code = code;
            this.Name = name;
            this.Prise = price;
        }

        //消費税額を求める（消費税率は10%）
        public int GetTax() {
            return (int)(Prise * 0.1);
        }

        //税込価格を求める
        public int GetPriceIncludingTax() {
            return Prise + GetTax();
        }
    }
}
