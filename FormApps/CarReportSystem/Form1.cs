﻿using System;
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

        //追加ボタンがクリックされた時のイベントハンドラー
        private void btAddReport_Click(object sender, EventArgs e) {
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
                DialogResult result = MessageBox.Show("削除するデータが存在しません。");
            } 
        }

        private void Form1_Load(object sender, EventArgs e) {
            dgvCarReports.Columns[5].Visible = false;//画像項目非表示
            btModifyReport.Enabled = false;//マスクする
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
                DialogResult result = MessageBox.Show("修正するデータが存在しません。");
            }
        }
    }
}
