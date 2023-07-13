using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class Form1 : Form {
        //管理用データ
        BindingList<CarReport> CarReports = new BindingList<CarReport>();

        public Form1() {
            InitializeComponent();
            dgvCarReports.DataSource = CarReports;
        }

        //ステータスラベルのテキスト表示・非表示
        private void statasLabelDisp(string msg = "") {
            tsInfoText.Text = msg;
        }

        //追加ボタンがクリックされた時のイベントハンドラー
        private void btAddReport_Click(object sender, EventArgs e) {
            statasLabelDisp();  //ステータスラベルのテキスト非表示
            if (cbAuthor.Text.Equals("")) {
                statasLabelDisp("記録者を入力してください");
                return;
            }else if(cbCarName.Text.Equals("")) {
                statasLabelDisp("車名を入力してください");
                return;
            }

            var CarReport = new CarReport
            {
                Date = dtpDate.Value,
                Author = cbAuthor.Text,
                Maker = getSelectedMaker(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                CarImage = pbCarImage.Image,
            };
            CarReports.Add(CarReport);
            CheckLength();
            ItemClear();
            dgvCarReports.ClearSelection();
            //コンボボックスの重複制限
            if (!cbAuthor.Items.Contains(CarReport.Author))
                cbAuthor.Items.Add(CarReport.Author);
            if (!cbCarName.Items.Contains(CarReport.CarName))
                cbCarName.Items.Add(CarReport.CarName);
        }

        //選択されているメーカーを返却
        private CarReport.MakerGroup getSelectedMaker() {
            int tagNum = 0;
            foreach (var item in gbMaker.Controls) {
                if (((RadioButton)item).Checked) {
                    tagNum = int.Parse(((RadioButton)item).Tag.ToString());
                    break;
                }
            }
            return (CarReport.MakerGroup)tagNum;
        }

        //指定したラジオボタンをセット
        private void setSelectedMaker(CarReport.MakerGroup makerGroup) {
            switch (makerGroup) {
                case CarReport.MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.日産:
                    rbNissan.Checked = true;
                    break;
                case CarReport.MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case CarReport.MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.MakerGroup.スズキ:
                    rbSuzuki.Checked = true;
                    break;
                case CarReport.MakerGroup.ダイハツ:
                    rbDaihatsu.Checked = true;
                    break;
                case CarReport.MakerGroup.輸入車:
                    rbImported.Checked = true;
                    break;
                case CarReport.MakerGroup.その他:
                    rbOther.Checked = true;
                    break;
                default:
                    break;
            }
        }

        //開く..ボタンイベントハンドラー
        private void btImageOpen_Click(object sender, EventArgs e) {
            ofdImageFileOpen.ShowDialog();
            pbCarImage.Image = Image.FromFile(ofdImageFileOpen.FileName);
        }

        //削除ボタンイベントハンドラー
        private void btDeleteReport_Click(object sender, EventArgs e) {
            try {
                var index = dgvCarReports.SelectedRows[0].Index;
                dgvCarReports.Rows.RemoveAt(index);
            }
            catch (Exception) {
            }
            CheckLength();
        }

        private void Form1_Load(object sender, EventArgs e) {
            dgvCarReports.Columns[5].Visible = false;//画像項目非表示
            CheckLength();
        }

        //レコード選択時
        private void dgvCarReports_CellClick(object sender, DataGridViewCellEventArgs e) {
            dtpDate.Value = (DateTime)dgvCarReports.CurrentRow.Cells[0].Value;
            cbAuthor.Text = dgvCarReports.CurrentRow.Cells[1].Value.ToString();
            setSelectedMaker((CarReport.MakerGroup)dgvCarReports.CurrentRow.Cells[2].Value);
            cbCarName.Text = dgvCarReports.CurrentRow.Cells[3].Value.ToString();
            tbReport.Text = dgvCarReports.CurrentRow.Cells[4].Value.ToString();
            pbCarImage.Image = (Image)dgvCarReports.CurrentRow.Cells[5].Value;
        }

        //修正ボタンイベントハンドラー
        private void btModifyReport_Click(object sender, EventArgs e) {
            try {
                var index = dgvCarReports.SelectedRows[0].Index;
                CarReports[index] = new CarReport
                {
                    Date = dtpDate.Value,
                    Author = cbAuthor.Text,
                    Maker = getSelectedMaker(),
                    CarName = cbCarName.Text,
                    Report = tbReport.Text,
                    CarImage = pbCarImage.Image,
                };
            }
            catch (Exception) {
            }
        }

        private void CheckLength() {
            if (CarReports.Count() <= 0) {
                btModifyReport.Enabled = false;  //マスクする
                btDeleteReport.Enabled = false;
            }
            else {
                btModifyReport.Enabled = true;   //マスク解除
                btDeleteReport.Enabled = true;
            }
        }

        //各項目をクリアする
        private void ItemClear() {
            dtpDate.Value = DateTime.Today;
            cbAuthor.Text = null;
            foreach (var item in gbMaker.Controls) {
                ((RadioButton)item).Checked = false;
            }
            cbCarName.Text = null;
            tbReport.Text = null;
            pbCarImage.Image = null;
        }


        private void バージョン情報ToolStripMenuItem_Click(object sender, EventArgs e) {
            var vf = new VersionForm();
            vf.ShowDialog();    //モーダルダイアログ表示
        }

        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
