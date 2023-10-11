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

            //コンボボックスへ入力されているのがカテゴリ名かを判定
            var Link = "";
            foreach (var item in categoryDic.Where(x => x.Key.Equals(cbLink.Text))) {
                Link = categoryDic[item.Key];
            }
            if (Link.Equals("")) {
                Link = cbLink.Text;
            }

            //urlを取得し情報をクラスに格納
            using (var wc = new WebClient()) {
                try {
                    var url = wc.OpenRead(Link);
                    XDocument xdoc = XDocument.Load(url);

                    nodes = xdoc.Root.Descendants("item").Select(x => new ItemData { Title = x.Element("title").Value, Link = x.Element("link").Value, });

                    foreach (var node in nodes) {
                        lbRssTitle.Items.Add(node.Title);
                    }
                }
                catch (Exception) {
                    MessageBox.Show("***URLが取得できません***");
                }

            }
        }

        //コンボボックスへのカテゴリーの追加
        private void Category() {
            categoryDic.Add("IT", "https://news.yahoo.co.jp/rss/categories/it.xml");
            categoryDic.Add("スポーツ", "https://news.yahoo.co.jp/rss/categories/sports.xml");
            categoryDic.Add("国際", "https://news.yahoo.co.jp/rss/categories/world.xml");
            foreach (var categoryName in categoryDic.Keys) {
                cbLink.Items.Add(categoryName);
            }
        }

        //記事が選択された時の処理
        private void lbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {
            foreach (var title in nodes.Select(x => x.Title)) {
                foreach (var link in nodes.Where(x => x.Title.Equals(lbRssTitle.SelectedItem))) {
                    this.wbBrowser.Navigate(link.Link);
                }   
            }
        }
        
        private void Form1_SizeChanged(object sender, EventArgs e) {
            //wbBrowser.Size = new Size(Size.Width - 515, Size.Height - 96);
            //lbRssTitle.Size = new Size(Size.Width - 755, Size.Height - 96);
        }

        private void cbLink_SelectedValueChanged(object sender, EventArgs e) {
            string t = cbLink.Text;
            cbLink.Text = categoryDic[t];
            
        }
    }
}
