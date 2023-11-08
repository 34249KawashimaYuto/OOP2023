using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {
        IEnumerable<ItemData> nodes;
        Dictionary<string, string> categoryDic = new Dictionary<string, string>();
        public Form1() {
            InitializeComponent();
            Category();
        }
        private void btGet_Click(object sender, EventArgs e) {
            //記事一覧をリセット
            lbRssTitle.Items.Clear();
            //試験用url
            //https://news.yahoo.co.jp/rss/categories/it.xml

            //urlを取得し情報をクラスに格納
            using (var wc = new WebClient()) {
                try {
                    var url = wc.OpenRead(tbLink.Text);
                    XDocument xdoc = XDocument.Load(url);

                    nodes = xdoc.Root.Descendants("item").Select(x => new ItemData { Title = x.Element("title").Value, Link = x.Element("link").Value, });

                    foreach (var node in nodes) {
                        lbRssTitle.Items.Add(node.Title);
                    }
                }
                catch (Exception) {
                    MessageBox.Show("***URLが正しくありません***");
                }
            }
        }

        //dictionaryへのカテゴリーの追加
        private void Category() {
            categoryDic.Add("IT", "https://news.yahoo.co.jp/rss/categories/it.xml");
            categoryDic.Add("スポーツ", "https://news.yahoo.co.jp/rss/categories/sports.xml");
            categoryDic.Add("国際", "https://news.yahoo.co.jp/rss/categories/world.xml");
            categoryDic.Add("科学", "https://news.yahoo.co.jp/rss/categories/science.xml");
        }

        //記事が選択された時の処理
        private void lbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {
            foreach (var title in nodes.Select(x => x.Title)) {
                foreach (var link in nodes.Where(x => x.Title.Equals(lbRssTitle.SelectedItem))) {
                    this.wbBrowser.Navigate(link.Link);
                }   
            }
        }

        //ラジオボタンが選択された時の処理
        private void category_Select(object sender, EventArgs e) {
            var Checked_InGroup = gbCategory.Controls.OfType<RadioButton>().SingleOrDefault(rb => rb.Checked == true);
            tbLink.Text = categoryDic[Checked_InGroup.Text];
        }

        //お気に入り登録ボタンを押したときの処理
        private void btFavorite_Click(object sender, EventArgs e) {
            try {
                string fTitle = tbFavorite.Text;
                categoryDic.Add(fTitle, tbLink.Text);
                cbFavorite.Items.Add(fTitle);
                tbFavorite.Clear();
            }
            catch {
                if (tbFavorite.Text.Equals(null)) {
                    MessageBox.Show("名前が入力されていません");
                }
            }
        }

        //お気に入り一覧を表示するコンボボックス選択時の処理
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            tbLink.Text = categoryDic[cbFavorite.SelectedItem.ToString()];
        }
    }
}
