namespace YazilimSinamaSonProje
{
    partial class ZimmetEkleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.Utils.SuperToolTip superToolTip4 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem4 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem4 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip5 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem5 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem5 = new DevExpress.Utils.ToolTipItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZimmetEkleForm));
            DevExpress.Utils.SuperToolTip superToolTip6 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem6 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem6 = new DevExpress.Utils.ToolTipItem();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnSil = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCikis = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnYeni = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnZimmetKaydet = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnKisi = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pnlKisi = new System.Windows.Forms.Panel();
            this.spinEditZimmetAded = new DevExpress.XtraEditors.SpinEdit();
            this.cbxPersonal = new System.Windows.Forms.ComboBox();
            this.cbxUrun = new System.Windows.Forms.ComboBox();
            this.txtZimmetId = new YazilimSinamaSonProje.Controls.MyTextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwZimmet = new System.Windows.Forms.DataGridView();
            this.dgwMevcut = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.pnlKisi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditZimmetAded.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZimmetId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwZimmet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMevcut)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.DrawGroupsBorderMode = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barBtnSil,
            this.barBtnCikis,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barBtnYeni,
            this.barBtnZimmetKaydet,
            this.barbtnKisi});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowCategoryInCaption = false;
            this.ribbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowQatLocationSelector = false;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(430, 96);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // barBtnSil
            // 
            this.barBtnSil.Caption = "Sil";
            this.barBtnSil.Id = 1;
            this.barBtnSil.ImageOptions.Image = global::YazilimSinamaSonProje.Properties.Resources.close_16x16;
            this.barBtnSil.ImageOptions.LargeImage = global::YazilimSinamaSonProje.Properties.Resources.close_32x32;
            this.barBtnSil.Name = "barBtnSil";
            toolTipTitleItem4.Appearance.Image = global::YazilimSinamaSonProje.Properties.Resources.comment_16x16;
            toolTipTitleItem4.Appearance.Options.UseImage = true;
            toolTipTitleItem4.Image = global::YazilimSinamaSonProje.Properties.Resources.comment_16x16;
            toolTipTitleItem4.Text = "(Delete)";
            toolTipItem4.LeftIndent = 6;
            toolTipItem4.Text = "Yeni Üye Sil";
            superToolTip4.Items.Add(toolTipTitleItem4);
            superToolTip4.Items.Add(toolTipItem4);
            this.barBtnSil.SuperTip = superToolTip4;
            // 
            // barBtnCikis
            // 
            this.barBtnCikis.Caption = "Çıkış";
            this.barBtnCikis.Id = 2;
            this.barBtnCikis.ImageOptions.Image = global::YazilimSinamaSonProje.Properties.Resources.cancel_16x162;
            this.barBtnCikis.ImageOptions.LargeImage = global::YazilimSinamaSonProje.Properties.Resources.cancel_32x322;
            this.barBtnCikis.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4));
            this.barBtnCikis.Name = "barBtnCikis";
            toolTipTitleItem5.Appearance.Image = global::YazilimSinamaSonProje.Properties.Resources.comment_16x16;
            toolTipTitleItem5.Appearance.Options.UseImage = true;
            toolTipTitleItem5.Image = global::YazilimSinamaSonProje.Properties.Resources.comment_16x16;
            toolTipTitleItem5.Text = "(Alt+F4)";
            toolTipItem5.LeftIndent = 6;
            toolTipItem5.Text = "Çıkış Yap";
            superToolTip5.Items.Add(toolTipTitleItem5);
            superToolTip5.Items.Add(toolTipItem5);
            this.barBtnCikis.SuperTip = superToolTip5;
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barBtnYeni
            // 
            this.barBtnYeni.Caption = "Yeni";
            this.barBtnYeni.Id = 5;
            this.barBtnYeni.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnYeni.ImageOptions.Image")));
            this.barBtnYeni.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnYeni.ImageOptions.LargeImage")));
            this.barBtnYeni.Name = "barBtnYeni";
            // 
            // barBtnZimmetKaydet
            // 
            this.barBtnZimmetKaydet.Caption = "Zimmetle";
            this.barBtnZimmetKaydet.Id = 6;
            this.barBtnZimmetKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnZimmetKaydet.ImageOptions.Image")));
            this.barBtnZimmetKaydet.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnZimmetKaydet.ImageOptions.LargeImage")));
            this.barBtnZimmetKaydet.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Insert);
            this.barBtnZimmetKaydet.Name = "barBtnZimmetKaydet";
            toolTipTitleItem6.Appearance.Image = global::YazilimSinamaSonProje.Properties.Resources.comment_16x16;
            toolTipTitleItem6.Appearance.Options.UseImage = true;
            toolTipTitleItem6.Image = global::YazilimSinamaSonProje.Properties.Resources.comment_16x16;
            toolTipTitleItem6.Text = "(Insert)";
            toolTipItem6.LeftIndent = 6;
            toolTipItem6.Text = "Zimmetle";
            superToolTip6.Items.Add(toolTipTitleItem6);
            superToolTip6.Items.Add(toolTipItem6);
            this.barBtnZimmetKaydet.SuperTip = superToolTip6;
            this.barBtnZimmetKaydet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnZimmetKaydet_ItemClick);
            // 
            // barbtnKisi
            // 
            this.barbtnKisi.Caption = "Kişi Ekle";
            this.barbtnKisi.Id = 7;
            this.barbtnKisi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtnKisi.ImageOptions.Image")));
            this.barbtnKisi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtnKisi.ImageOptions.LargeImage")));
            this.barbtnKisi.Name = "barbtnKisi";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnZimmetKaydet);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnCikis);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // pnlKisi
            // 
            this.pnlKisi.BackColor = System.Drawing.Color.DarkRed;
            this.pnlKisi.Controls.Add(this.spinEditZimmetAded);
            this.pnlKisi.Controls.Add(this.cbxPersonal);
            this.pnlKisi.Controls.Add(this.cbxUrun);
            this.pnlKisi.Controls.Add(this.txtZimmetId);
            this.pnlKisi.Controls.Add(this.label4);
            this.pnlKisi.Controls.Add(this.label2);
            this.pnlKisi.Controls.Add(this.label6);
            this.pnlKisi.Controls.Add(this.label1);
            this.pnlKisi.Location = new System.Drawing.Point(0, 94);
            this.pnlKisi.MaximumSize = new System.Drawing.Size(432, 277);
            this.pnlKisi.Name = "pnlKisi";
            this.pnlKisi.Size = new System.Drawing.Size(432, 261);
            this.pnlKisi.TabIndex = 5;
            // 
            // spinEditZimmetAded
            // 
            this.spinEditZimmetAded.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditZimmetAded.Location = new System.Drawing.Point(189, 98);
            this.spinEditZimmetAded.MenuManager = this.ribbonControl1;
            this.spinEditZimmetAded.Name = "spinEditZimmetAded";
            this.spinEditZimmetAded.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditZimmetAded.Properties.Mask.EditMask = "n0";
            this.spinEditZimmetAded.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.spinEditZimmetAded.Size = new System.Drawing.Size(158, 22);
            this.spinEditZimmetAded.TabIndex = 17;
            // 
            // cbxPersonal
            // 
            this.cbxPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(119)))), ((int)(((byte)(176)))));
            this.cbxPersonal.FormattingEnabled = true;
            this.cbxPersonal.Location = new System.Drawing.Point(189, 170);
            this.cbxPersonal.Name = "cbxPersonal";
            this.cbxPersonal.Size = new System.Drawing.Size(158, 24);
            this.cbxPersonal.TabIndex = 16;
            // 
            // cbxUrun
            // 
            this.cbxUrun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(119)))), ((int)(((byte)(176)))));
            this.cbxUrun.FormattingEnabled = true;
            this.cbxUrun.Location = new System.Drawing.Point(189, 134);
            this.cbxUrun.Name = "cbxUrun";
            this.cbxUrun.Size = new System.Drawing.Size(158, 24);
            this.cbxUrun.TabIndex = 15;
            // 
            // txtZimmetId
            // 
            this.txtZimmetId.EnterMoveNextControl = true;
            this.txtZimmetId.Location = new System.Drawing.Point(189, 66);
            this.txtZimmetId.MenuManager = this.ribbonControl1;
            this.txtZimmetId.Name = "txtZimmetId";
            this.txtZimmetId.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Blue;
            this.txtZimmetId.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtZimmetId.Properties.MaxLength = 11;
            this.txtZimmetId.Size = new System.Drawing.Size(158, 22);
            this.txtZimmetId.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Urun ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Zimmet Aded";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Personal ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Zimmet Id";
            // 
            // dgwZimmet
            // 
            this.dgwZimmet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwZimmet.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgwZimmet.Location = new System.Drawing.Point(388, 102);
            this.dgwZimmet.Name = "dgwZimmet";
            this.dgwZimmet.RowTemplate.Height = 24;
            this.dgwZimmet.Size = new System.Drawing.Size(10, 10);
            this.dgwZimmet.TabIndex = 7;
            // 
            // dgwMevcut
            // 
            this.dgwMevcut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwMevcut.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgwMevcut.Location = new System.Drawing.Point(372, 102);
            this.dgwMevcut.Name = "dgwMevcut";
            this.dgwMevcut.RowTemplate.Height = 24;
            this.dgwMevcut.Size = new System.Drawing.Size(10, 23);
            this.dgwMevcut.TabIndex = 9;
            // 
            // ZimmetEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 353);
            this.Controls.Add(this.dgwMevcut);
            this.Controls.Add(this.dgwZimmet);
            this.Controls.Add(this.pnlKisi);
            this.Controls.Add(this.ribbonControl1);
            this.MaximumSize = new System.Drawing.Size(448, 400);
            this.MinimumSize = new System.Drawing.Size(448, 400);
            this.Name = "ZimmetEkleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZimmetEkleForm";
            this.Load += new System.EventHandler(this.ZimmetEkleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.pnlKisi.ResumeLayout(false);
            this.pnlKisi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditZimmetAded.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZimmetId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwZimmet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMevcut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem barBtnSil;
        private DevExpress.XtraBars.BarButtonItem barBtnCikis;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barBtnYeni;
        private DevExpress.XtraBars.BarButtonItem barBtnZimmetKaydet;
        private DevExpress.XtraBars.BarButtonItem barbtnKisi;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private System.Windows.Forms.Panel pnlKisi;
        private Controls.MyTextEdit txtZimmetId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxPersonal;
        private System.Windows.Forms.ComboBox cbxUrun;
        private DevExpress.XtraEditors.SpinEdit spinEditZimmetAded;
        private System.Windows.Forms.DataGridView dgwZimmet;
        private System.Windows.Forms.DataGridView dgwMevcut;
    }
}