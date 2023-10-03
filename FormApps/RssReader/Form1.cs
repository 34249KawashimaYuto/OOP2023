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
        public Form1() {
            InitializeComponent();
            cbAdd();
        }
        IEnumerable<ItemData> nodes;
        private void btGet_Click(object sender, EventArgs e) {
            //試験用url
            //https://news.yahoo.co.jp/rss/categories/it.xml

            using (var wc = new WebClient()) {
                var url = wc.OpenRead(tbUrl.Text);
                XDocument xdoc = XDocument.Load(url);

                nodes = xdoc.Root.Descendants("item").Select(x => new ItemData { Title = x.Element("title").Value, Link = x.Element("link").Value, });

                foreach (var node in nodes) {
                    lbRssTitle.Items.Add(node.Title);
                }
                //this.wbBrowser.Navigate(useUrl);
            }
        }

        private void cbAdd() {
            cbLink.Items.Add("https://news.yahoo.co.jp/rss/categories/it.xml");
            cbLink.Items.Add("https://news.yahoo.co.jp/rss/categories/sports.xml");
            cbLink.Items.Add("https://news.yahoo.co.jp/rss/categories/world.xml");
        }

        private void lbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {
            foreach (var title in nodes.Select(x => x.Title)) {
                foreach (var link in nodes.Where(x => x.Title.Equals(lbRssTitle.SelectedItem))) {
                    this.wbBrowser.Navigate(link.Link);
                }   
            }
        }

    }
}
