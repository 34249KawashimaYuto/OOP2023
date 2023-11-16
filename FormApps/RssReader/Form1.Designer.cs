
namespace RssReader {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.btGet = new System.Windows.Forms.Button();
            this.lbRssTitle = new System.Windows.Forms.ListBox();
            this.wbBrowser = new System.Windows.Forms.WebBrowser();
            this.rbIT = new System.Windows.Forms.RadioButton();
            this.rbSports = new System.Windows.Forms.RadioButton();
            this.rbInternational = new System.Windows.Forms.RadioButton();
            this.gbCategory = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rbScience = new System.Windows.Forms.RadioButton();
            this.tbLink = new System.Windows.Forms.TextBox();
            this.tbFavorite = new System.Windows.Forms.TextBox();
            this.btFavorite = new System.Windows.Forms.Button();
            this.cbFavorite = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cbHistory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbCategory.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btGet
            // 
            this.btGet.Location = new System.Drawing.Point(804, 12);
            this.btGet.Name = "btGet";
            this.btGet.Size = new System.Drawing.Size(75, 31);
            this.btGet.TabIndex = 1;
            this.btGet.Text = "取得";
            this.btGet.UseVisualStyleBackColor = true;
            this.btGet.Click += new System.EventHandler(this.btGet_Click);
            // 
            // lbRssTitle
            // 
            this.lbRssTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbRssTitle.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbRssTitle.FormattingEnabled = true;
            this.lbRssTitle.ItemHeight = 16;
            this.lbRssTitle.Location = new System.Drawing.Point(31, 97);
            this.lbRssTitle.Name = "lbRssTitle";
            this.lbRssTitle.Size = new System.Drawing.Size(1121, 132);
            this.lbRssTitle.TabIndex = 2;
            this.lbRssTitle.SelectedIndexChanged += new System.EventHandler(this.lbRssTitle_SelectedIndexChanged);
            // 
            // wbBrowser
            // 
            this.wbBrowser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.wbBrowser.Location = new System.Drawing.Point(31, 242);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.ScriptErrorsSuppressed = true;
            this.wbBrowser.Size = new System.Drawing.Size(1121, 425);
            this.wbBrowser.TabIndex = 3;
            // 
            // rbIT
            // 
            this.rbIT.AutoSize = true;
            this.rbIT.Location = new System.Drawing.Point(6, 18);
            this.rbIT.Name = "rbIT";
            this.rbIT.Size = new System.Drawing.Size(33, 16);
            this.rbIT.TabIndex = 5;
            this.rbIT.TabStop = true;
            this.rbIT.Text = "IT";
            this.rbIT.UseVisualStyleBackColor = true;
            this.rbIT.CheckedChanged += new System.EventHandler(this.category_Select);
            // 
            // rbSports
            // 
            this.rbSports.AutoSize = true;
            this.rbSports.Location = new System.Drawing.Point(45, 18);
            this.rbSports.Name = "rbSports";
            this.rbSports.Size = new System.Drawing.Size(61, 16);
            this.rbSports.TabIndex = 6;
            this.rbSports.TabStop = true;
            this.rbSports.Text = "スポーツ";
            this.rbSports.UseVisualStyleBackColor = true;
            this.rbSports.CheckedChanged += new System.EventHandler(this.category_Select);
            // 
            // rbInternational
            // 
            this.rbInternational.AutoSize = true;
            this.rbInternational.Location = new System.Drawing.Point(335, 18);
            this.rbInternational.Name = "rbInternational";
            this.rbInternational.Size = new System.Drawing.Size(47, 16);
            this.rbInternational.TabIndex = 7;
            this.rbInternational.TabStop = true;
            this.rbInternational.Text = "国際";
            this.rbInternational.UseVisualStyleBackColor = true;
            this.rbInternational.CheckedChanged += new System.EventHandler(this.category_Select);
            // 
            // gbCategory
            // 
            this.gbCategory.Controls.Add(this.radioButton4);
            this.gbCategory.Controls.Add(this.radioButton3);
            this.gbCategory.Controls.Add(this.radioButton2);
            this.gbCategory.Controls.Add(this.radioButton1);
            this.gbCategory.Controls.Add(this.rbScience);
            this.gbCategory.Controls.Add(this.rbIT);
            this.gbCategory.Controls.Add(this.rbSports);
            this.gbCategory.Controls.Add(this.rbInternational);
            this.gbCategory.Location = new System.Drawing.Point(31, 47);
            this.gbCategory.Name = "gbCategory";
            this.gbCategory.Size = new System.Drawing.Size(445, 41);
            this.gbCategory.TabIndex = 8;
            this.gbCategory.TabStop = false;
            this.gbCategory.Text = "カテゴリー";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(228, 18);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(48, 16);
            this.radioButton4.TabIndex = 12;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "ライフ";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.category_Select);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(165, 18);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(57, 16);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "エンタメ";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.category_Select);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(282, 18);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 16);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "国内";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.category_Select);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(112, 18);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 16);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "経済";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.category_Select);
            // 
            // rbScience
            // 
            this.rbScience.AutoSize = true;
            this.rbScience.Location = new System.Drawing.Point(388, 18);
            this.rbScience.Name = "rbScience";
            this.rbScience.Size = new System.Drawing.Size(47, 16);
            this.rbScience.TabIndex = 8;
            this.rbScience.TabStop = true;
            this.rbScience.Text = "科学";
            this.rbScience.UseVisualStyleBackColor = true;
            this.rbScience.CheckedChanged += new System.EventHandler(this.category_Select);
            // 
            // tbLink
            // 
            this.tbLink.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbLink.Location = new System.Drawing.Point(31, 13);
            this.tbLink.Name = "tbLink";
            this.tbLink.Size = new System.Drawing.Size(767, 28);
            this.tbLink.TabIndex = 9;
            this.tbLink.TextChanged += new System.EventHandler(this.TextChange);
            // 
            // tbFavorite
            // 
            this.tbFavorite.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbFavorite.Location = new System.Drawing.Point(6, 15);
            this.tbFavorite.Name = "tbFavorite";
            this.tbFavorite.Size = new System.Drawing.Size(222, 27);
            this.tbFavorite.TabIndex = 10;
            this.toolTip1.SetToolTip(this.tbFavorite, "お気に入りのURLにつける名前を入力");
            this.tbFavorite.TextChanged += new System.EventHandler(this.TextChange);
            // 
            // btFavorite
            // 
            this.btFavorite.BackColor = System.Drawing.Color.Transparent;
            this.btFavorite.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btFavorite.Location = new System.Drawing.Point(234, 13);
            this.btFavorite.Name = "btFavorite";
            this.btFavorite.Size = new System.Drawing.Size(27, 30);
            this.btFavorite.TabIndex = 11;
            this.btFavorite.Text = "☆";
            this.toolTip1.SetToolTip(this.btFavorite, "このURLをお気に入りとして追加する");
            this.btFavorite.UseVisualStyleBackColor = false;
            this.btFavorite.Click += new System.EventHandler(this.btFavorite_Click);
            this.btFavorite.MouseLeave += new System.EventHandler(this.btFavorite_MouseLeave);
            this.btFavorite.MouseHover += new System.EventHandler(this.btFavorite_MouseHover);
            // 
            // cbFavorite
            // 
            this.cbFavorite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFavorite.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbFavorite.FormattingEnabled = true;
            this.cbFavorite.Location = new System.Drawing.Point(6, 48);
            this.cbFavorite.Name = "cbFavorite";
            this.cbFavorite.Size = new System.Drawing.Size(255, 24);
            this.cbFavorite.TabIndex = 12;
            this.toolTip1.SetToolTip(this.cbFavorite, "お気に入り一覧を表示");
            this.cbFavorite.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btFavorite);
            this.groupBox1.Controls.Add(this.tbFavorite);
            this.groupBox1.Controls.Add(this.cbFavorite);
            this.groupBox1.Location = new System.Drawing.Point(885, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 78);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "お気に入り登録";
            // 
            // cbHistory
            // 
            this.cbHistory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHistory.FormattingEnabled = true;
            this.cbHistory.Location = new System.Drawing.Point(540, 66);
            this.cbHistory.Name = "cbHistory";
            this.cbHistory.Size = new System.Drawing.Size(339, 20);
            this.cbHistory.TabIndex = 15;
            this.toolTip1.SetToolTip(this.cbHistory, "履歴一覧を表示します");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(482, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "履歴";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(499, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "前回：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 690);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbHistory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbLink);
            this.Controls.Add(this.gbCategory);
            this.Controls.Add(this.wbBrowser);
            this.Controls.Add(this.lbRssTitle);
            this.Controls.Add(this.btGet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbCategory.ResumeLayout(false);
            this.gbCategory.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btGet;
        private System.Windows.Forms.ListBox lbRssTitle;
        private System.Windows.Forms.WebBrowser wbBrowser;
        private System.Windows.Forms.RadioButton rbIT;
        private System.Windows.Forms.RadioButton rbSports;
        private System.Windows.Forms.RadioButton rbInternational;
        private System.Windows.Forms.GroupBox gbCategory;
        private System.Windows.Forms.TextBox tbLink;
        private System.Windows.Forms.TextBox tbFavorite;
        private System.Windows.Forms.Button btFavorite;
        private System.Windows.Forms.ComboBox cbFavorite;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbScience;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbHistory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}

