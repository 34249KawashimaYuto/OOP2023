using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ColorChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        MyColor myColor;
        public MainWindow() {
            InitializeComponent();
            DataContext = GetColorList();
        }

        //スライダの値が変わった際のイベントハンドラ
        private void slider_Chenged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            int r = (int)rSlider.Value;
            rValue.Text = r.ToString();
            int g = (int)gSlider.Value;
            gValue.Text = g.ToString();
            int b = (int)bSlider.Value;
            bValue.Text = b.ToString();
            Color color =  getColor(r, g, b);
            colorArea.Background = new SolidColorBrush(color);
        }

        //STOCKボタンが押された際のイベントハンドラ
        private void stockButton_Click(object sender, RoutedEventArgs e) {
            Color getColor = this.getColor(int.Parse(rValue.Text), int.Parse(gValue.Text), int.Parse(bValue.Text));
            string cName = string.Format("R:{0} G:{1} B:{2}",getColor.R,getColor.G,getColor.B);
            foreach (var col in GetColorList()) {
                if (getColor == col.Color)
                    cName = col.Name;
            }
            myColor = new MyColor()
            {
                Color = getColor,
                Name = cName
            };
            stockList.Items.Add(myColor.Name);
        }

        //Listが選択された際のイベントハンドラ
        private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            string value = stockList.SelectedItem.ToString();
            bool sw = false;
            Color color = Color.FromRgb(0,0,0);
            foreach (var col in GetColorList()) {
                if (value.Equals(col.Name)) {
                    rValue.Text = col.Color.R.ToString();
                    gValue.Text = col.Color.G.ToString();
                    bValue.Text = col.Color.B.ToString();
                    sw = true;
                    color = col.Color;
                }
            }
            if(sw == false) {
                var results = System.Text.RegularExpressions.Regex.Matches(value, @"[0-9]+\.?[0-9]*");
                var nums = new List<string>();
                foreach (var item in results) {
                    nums.Add(item.ToString());
                }
                rValue.Text = nums[0];
                gValue.Text = nums[1];
                bValue.Text = nums[2];
                color = getColor(int.Parse(nums[0]), int.Parse(nums[1]), int.Parse(nums[2]));
            }
            colorArea.Background = new SolidColorBrush(color);

        }

        //RGB値から色を生成するメソッド
        private Color getColor(int v1, int v2, int v3) {
            return Color.FromRgb((byte)v1, (byte)v2, (byte)v3);
        }

        //すべての色を取得するメソッド
        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var color = ((MyColor)((ComboBox)sender).SelectedItem).Color;
            rValue.Text = color.R.ToString();
            gValue.Text = color.G.ToString();
            bValue.Text = color.B.ToString();
            colorArea.Background = new SolidColorBrush(color);
        }
    }

    public class MyColor {
        public Color Color { get; set; }
        public string Name { get; set; }
    }
}
