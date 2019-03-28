namespace YazilimSinamaSonProje
{
    partial class UrunEkleForm
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
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunEkleForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnSil = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCikis = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnYeni = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnUrunEkle = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnKisi = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pnlKisi = new System.Windows.Forms.Panel();
            this.txtMarkaId = new YazilimSinamaSonProje.Controls.MyTextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUrunId = new YazilimSinamaSonProje.Controls.MyTextEdit();
            this.txtUrunAdedi = new YazilimSinamaSonProje.Controls.MyTextEdit();
            this.txtMarkaAdi = new YazilimSinamaSonProje.Controls.MyTextEdit();
            this.lblUrunAded = new System.Windows.Forms.Label();
            this.lblUrunId = new System.Windows.Forms.Label();
            this.txtUrunIsmi = new YazilimSinamaSonProje.Controls.MyTextEdit();
            this.lblMarkaAdı = new System.Windows.Forms.Label();
            this.lblMarkaId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.pnlKisi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarkaId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAdedi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarkaAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunIsmi.Properties)).BeginInit();
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
            this.barBtnUrunEkle,
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
            this.ribbonControl1.Size = new System.Drawing.Size(401, 96);
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
            toolTipTitleItem1.Appearance.Image = global::YazilimSinamaSonProje.Properties.Resources.comment_16x16;
            toolTipTitleItem1.Appearance.Options.UseImage = true;
            toolTipTitleItem1.Image = global::YazilimSinamaSonProje.Properties.Resources.comment_16x16;
            toolTipTitleItem1.Text = "(Delete)";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Yeni Üye Sil";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.barBtnSil.SuperTip = superToolTip1;
            // 
            // barBtnCikis
            // 
            this.barBtnCikis.Caption = "Çıkış";
            this.barBtnCikis.Id = 2;
            this.barBtnCikis.ImageOptions.Image = global::YazilimSinamaSonProje.Properties.Resources.cancel_16x162;
            this.barBtnCikis.ImageOptions.LargeImage = global::YazilimSinamaSonProje.Properties.Resources.cancel_32x322;
            this.barBtnCikis.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4));
            this.barBtnCikis.Name = "barBtnCikis";
            toolTipTitleItem2.Appearance.Image = global::YazilimSinamaSonProje.Properties.Resources.comment_16x16;
            toolTipTitleItem2.Appearance.Options.UseImage = true;
            toolTipTitleItem2.Image = global::YazilimSinamaSonProje.Properties.Resources.comment_16x16;
            toolTipTitleItem2.Text = "(Alt+F4)";
            toolTipItem2.LeftIndent = 6;
            toolTipItem2.Text = "Çıkış Yap";
            superToolTip2.Items.Add(toolTipTitleItem2);
            superToolTip2.Items.Add(toolTipItem2);
            this.barBtnCikis.SuperTip = superToolTip2;
            this.barBtnCikis.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnCikis_ItemClick);
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
            // barBtnUrunEkle
            // 
            this.barBtnUrunEkle.Caption = "Ürün Ekle";
            this.barBtnUrunEkle.Id = 6;
            this.barBtnUrunEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnUrunEkle.ImageOptions.Image")));
            this.barBtnUrunEkle.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnUrunEkle.ImageOptions.LargeImage")));
            this.barBtnUrunEkle.Name = "barBtnUrunEkle";
            this.barBtnUrunEkle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnUrunEkle_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnUrunEkle);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnCikis);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // pnlKisi
            // 
            this.pnlKisi.BackColor = System.Drawing.Color.DarkRed;
            this.pnlKisi.Controls.Add(this.txtMarkaId);
            this.pnlKisi.Controls.Add(this.label4);
            this.pnlKisi.Controls.Add(this.txtUrunId);
            this.pnlKisi.Controls.Add(this.txtUrunAdedi);
            this.pnlKisi.Controls.Add(this.txtMarkaAdi);
            this.pnlKisi.Controls.Add(this.lblUrunAded);
            this.pnlKisi.Controls.Add(this.lblUrunId);
            this.pnlKisi.Controls.Add(this.txtUrunIsmi);
            this.pnlKisi.Controls.Add(this.lblMarkaAdı);
            this.pnlKisi.Controls.Add(this.lblMarkaId);
            this.pnlKisi.Location = new System.Drawing.Point(0, 90);
            this.pnlKisi.MaximumSize = new System.Drawing.Size(432, 277);
            this.pnlKisi.Name = "pnlKisi";
            this.pnlKisi.Size = new System.Drawing.Size(401, 250);
            this.pnlKisi.TabIndex = 5;
            // 
            // txtMarkaId
            // 
            this.txtMarkaId.EnterMoveNextControl = true;
            this.txtMarkaId.Location = new System.Drawing.Point(164, 39);
            this.txtMarkaId.MenuManager = this.ribbonControl1;
            this.txtMarkaId.Name = "txtMarkaId";
            this.txtMarkaId.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Blue;
            this.txtMarkaId.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtMarkaId.Properties.MaxLength = 11;
            this.txtMarkaId.Size = new System.Drawing.Size(158, 22);
            this.txtMarkaId.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ürün İsmi";
            // 
            // txtUrunId
            // 
            this.txtUrunId.EnterMoveNextControl = true;
            this.txtUrunId.Location = new System.Drawing.Point(164, 107);
            this.txtUrunId.MenuManager = this.ribbonControl1;
            this.txtUrunId.Name = "txtUrunId";
            this.txtUrunId.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Blue;
            this.txtUrunId.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtUrunId.Properties.MaxLength = 50;
            this.txtUrunId.Size = new System.Drawing.Size(158, 22);
            this.txtUrunId.TabIndex = 12;
            // 
            // txtUrunAdedi
            // 
            this.txtUrunAdedi.EnterMoveNextControl = true;
            this.txtUrunAdedi.Location = new System.Drawing.Point(164, 176);
            this.txtUrunAdedi.MenuManager = this.ribbonControl1;
            this.txtUrunAdedi.Name = "txtUrunAdedi";
            this.txtUrunAdedi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Blue;
            this.txtUrunAdedi.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtUrunAdedi.Properties.MaxLength = 50;
            this.txtUrunAdedi.Size = new System.Drawing.Size(158, 22);
            this.txtUrunAdedi.TabIndex = 14;
            // 
            // txtMarkaAdi
            // 
            this.txtMarkaAdi.EnterMoveNextControl = true;
            this.txtMarkaAdi.Location = new System.Drawing.Point(164, 73);
            this.txtMarkaAdi.MenuManager = this.ribbonControl1;
            this.txtMarkaAdi.Name = "txtMarkaAdi";
            this.txtMarkaAdi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Blue;
            this.txtMarkaAdi.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtMarkaAdi.Properties.MaxLength = 50;
            this.txtMarkaAdi.Size = new System.Drawing.Size(158, 22);
            this.txtMarkaAdi.TabIndex = 11;
            // 
            // lblUrunAded
            // 
            this.lblUrunAded.AutoSize = true;
            this.lblUrunAded.Location = new System.Drawing.Point(44, 181);
            this.lblUrunAded.Name = "lblUrunAded";
            this.lblUrunAded.Size = new System.Drawing.Size(75, 17);
            this.lblUrunAded.TabIndex = 7;
            this.lblUrunAded.Text = "Ürün Adedi";
            // 
            // lblUrunId
            // 
            this.lblUrunId.AutoSize = true;
            this.lblUrunId.Location = new System.Drawing.Point(44, 110);
            this.lblUrunId.Name = "lblUrunId";
            this.lblUrunId.Size = new System.Drawing.Size(54, 17);
            this.lblUrunId.TabIndex = 5;
            this.lblUrunId.Text = "Ürün Id";
            // 
            // txtUrunIsmi
            // 
            this.txtUrunIsmi.EnterMoveNextControl = true;
            this.txtUrunIsmi.Location = new System.Drawing.Point(164, 143);
            this.txtUrunIsmi.MenuManager = this.ribbonControl1;
            this.txtUrunIsmi.Name = "txtUrunIsmi";
            this.txtUrunIsmi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Blue;
            this.txtUrunIsmi.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtUrunIsmi.Properties.MaxLength = 50;
            this.txtUrunIsmi.Size = new System.Drawing.Size(158, 22);
            this.txtUrunIsmi.TabIndex = 13;
            // 
            // lblMarkaAdı
            // 
            this.lblMarkaAdı.AutoSize = true;
            this.lblMarkaAdı.Location = new System.Drawing.Point(44, 76);
            this.lblMarkaAdı.Name = "lblMarkaAdı";
            this.lblMarkaAdı.Size = new System.Drawing.Size(72, 17);
            this.lblMarkaAdı.TabIndex = 4;
            this.lblMarkaAdı.Text = "Marka İsmi";
            // 
            // lblMarkaId
            // 
            this.lblMarkaId.AutoSize = true;
            this.lblMarkaId.Location = new System.Drawing.Point(44, 42);
            this.lblMarkaId.Name = "lblMarkaId";
            this.lblMarkaId.Size = new System.Drawing.Size(60, 17);
            this.lblMarkaId.TabIndex = 3;
            this.lblMarkaId.Text = "Marka Id";
            // 
            // UrunEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 337);
            this.Controls.Add(this.pnlKisi);
            this.Controls.Add(this.ribbonControl1);
            this.MaximumSize = new System.Drawing.Size(419, 384);
            this.MinimumSize = new System.Drawing.Size(419, 384);
            this.Name = "UrunEkleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UrunEkleForm";
            this.Load += new System.EventHandler(this.UrunEkleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.pnlKisi.ResumeLayout(false);
            this.pnlKisi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarkaId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAdedi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarkaAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunIsmi.Properties)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem barBtnUrunEkle;
        private DevExpress.XtraBars.BarButtonItem barbtnKisi;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private System.Windows.Forms.Panel pnlKisi;
        private Controls.MyTextEdit txtMarkaId;
        private System.Windows.Forms.Label label4;
        private Controls.MyTextEdit txtUrunId;
        private Controls.MyTextEdit txtUrunAdedi;
        private Controls.MyTextEdit txtMarkaAdi;
        private System.Windows.Forms.Label lblUrunAded;
        private System.Windows.Forms.Label lblUrunId;
        private Controls.MyTextEdit txtUrunIsmi;
        private System.Windows.Forms.Label lblMarkaAdı;
        private System.Windows.Forms.Label lblMarkaId;
    }
}