using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btButton_Click(object sender, EventArgs e) {

            int num1 = int.Parse(tbNum1.Text);
            int num2 = int.Parse(tbNum2.Text);
            int sum = num1 + num2;
            tbAns.Text = sum.ToString();
        }

        private void label5_Click(object sender, EventArgs e) {

        }

        private void btPow_Click(object sender, EventArgs e) {
            int num3 = Decimal.ToInt32(nud1.Value);
            int num4 = Decimal.ToInt32(nud2.Value);
            int pow = 1;
            for (int i = 0;i < num4;i++)
            {
                pow = pow * num3;
            }
            tbAns2.Text = pow.ToString();
        }
    }
}
