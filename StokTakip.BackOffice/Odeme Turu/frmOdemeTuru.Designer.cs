namespace StokTakip.BackOffice.Odeme_Turu
{
    partial class frmOdemeTuru
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOdemeTuru));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.btnFiltreKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnFiltreIptal = new DevExpress.XtraEditors.SimpleButton();
            this.btnFiltre = new DevExpress.XtraEditors.SimpleButton();
            this.filterControl1 = new DevExpress.XtraEditors.FilterControl();
            this.gridContDepolar = new DevExpress.XtraGrid.GridControl();
            this.gridDepolar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnStokHareketleri = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdemeTuruKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdemeTuruAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKasaGiris = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKasaCikis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBakiye = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContDepolar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDepolar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 54);
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.btnFiltreKapat);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnFiltreIptal);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnFiltre);
            this.splitContainerControl1.Panel1.Controls.Add(this.filterControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridContDepolar);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1158, 526);
            this.splitContainerControl1.SplitterPosition = 189;
            this.splitContainerControl1.TabIndex = 7;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // btnFiltreKapat
            // 
            this.btnFiltreKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltreKapat.ImageOptions.ImageIndex = 9;
            this.btnFiltreKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnFiltreKapat.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnFiltreKapat.Location = new System.Drawing.Point(1098, 143);
            this.btnFiltreKapat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFiltreKapat.Name = "btnFiltreKapat";
            this.btnFiltreKapat.Size = new System.Drawing.Size(50, 38);
            this.btnFiltreKapat.TabIndex = 2;
            // 
            // btnFiltreIptal
            // 
            this.btnFiltreIptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltreIptal.ImageOptions.ImageIndex = 11;
            this.btnFiltreIptal.ImageOptions.ImageList = this.ımageList1;
            this.btnFiltreIptal.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnFiltreIptal.Location = new System.Drawing.Point(1044, 143);
            this.btnFiltreIptal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFiltreIptal.Name = "btnFiltreIptal";
            this.btnFiltreIptal.Size = new System.Drawing.Size(50, 38);
            this.btnFiltreIptal.TabIndex = 2;
            // 
            // btnFiltre
            // 
            this.btnFiltre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltre.ImageOptions.ImageIndex = 10;
            this.btnFiltre.ImageOptions.ImageList = this.ımageList1;
            this.btnFiltre.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnFiltre.Location = new System.Drawing.Point(989, 143);
            this.btnFiltre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFiltre.Name = "btnFiltre";
            this.btnFiltre.Size = new System.Drawing.Size(50, 38);
            this.btnFiltre.TabIndex = 2;
            // 
            // filterControl1
            // 
            this.filterControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.filterControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterControl1.Location = new System.Drawing.Point(0, 0);
            this.filterControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterControl1.Name = "filterControl1";
            this.filterControl1.Size = new System.Drawing.Size(1158, 189);
            this.filterControl1.SortFilterColumns = false;
            this.filterControl1.SourceControl = this.gridContDepolar;
            this.filterControl1.TabIndex = 0;
            this.filterControl1.Text = "filterControl1";
            // 
            // gridContDepolar
            // 
            this.gridContDepolar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContDepolar.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridContDepolar.Location = new System.Drawing.Point(0, 0);
            this.gridContDepolar.MainView = this.gridDepolar;
            this.gridContDepolar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridContDepolar.Name = "gridContDepolar";
            this.gridContDepolar.Size = new System.Drawing.Size(1158, 332);
            this.gridContDepolar.TabIndex = 0;
            this.gridContDepolar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridDepolar});
            // 
            // gridDepolar
            // 
            this.gridDepolar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colOdemeTuruKodu,
            this.colOdemeTuruAdi,
            this.colAciklama,
            this.colKasaGiris,
            this.colKasaCikis,
            this.colBakiye});
            this.gridDepolar.GridControl = this.gridContDepolar;
            this.gridDepolar.Name = "gridDepolar";
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnKapat);
            this.grpMenu.Controls.Add(this.btnAra);
            this.grpMenu.Controls.Add(this.btnGuncelle);
            this.grpMenu.Controls.Add(this.btnStokHareketleri);
            this.grpMenu.Controls.Add(this.btnSil);
            this.grpMenu.Controls.Add(this.btnDuzenle);
            this.grpMenu.Controls.Add(this.btnEkle);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 580);
            this.grpMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(1158, 68);
            this.grpMenu.TabIndex = 6;
            this.grpMenu.Text = "Menü";
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 9;
            this.btnKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnKapat.Location = new System.Drawing.Point(1064, 26);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(83, 35);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            // 
            // btnAra
            // 
            this.btnAra.ImageOptions.ImageIndex = 6;
            this.btnAra.ImageOptions.ImageList = this.ımageList1;
            this.btnAra.Location = new System.Drawing.Point(453, 26);
            this.btnAra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(83, 35);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageOptions.ImageIndex = 8;
            this.btnGuncelle.ImageOptions.ImageList = this.ımageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(364, 26);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(83, 35);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Güncelle";
            // 
            // btnStokHareketleri
            // 
            this.btnStokHareketleri.ImageOptions.ImageIndex = 0;
            this.btnStokHareketleri.ImageOptions.ImageList = this.ımageList1;
            this.btnStokHareketleri.Location = new System.Drawing.Point(275, 26);
            this.btnStokHareketleri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStokHareketleri.Name = "btnStokHareketleri";
            this.btnStokHareketleri.Size = new System.Drawing.Size(83, 35);
            this.btnStokHareketleri.TabIndex = 1;
            this.btnStokHareketleri.Text = "Stok\r\nHareketleri";
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.ImageIndex = 4;
            this.btnSil.ImageOptions.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(187, 26);
            this.btnSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(83, 35);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "Sil";
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.ImageOptions.ImageIndex = 5;
            this.btnDuzenle.ImageOptions.ImageList = this.ımageList1;
            this.btnDuzenle.Location = new System.Drawing.Point(99, 26);
            this.btnDuzenle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(83, 35);
            this.btnDuzenle.TabIndex = 0;
            this.btnDuzenle.Text = "Düzenle";
            // 
            // btnEkle
            // 
            this.btnEkle.ImageOptions.ImageIndex = 3;
            this.btnEkle.ImageOptions.ImageList = this.ımageList1;
            this.btnEkle.Location = new System.Drawing.Point(10, 26);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(83, 35);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            // 
            // lblBaslik
            // 
            this.lblBaslik.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaslik.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("lblBaslik.Appearance.Image")));
            this.lblBaslik.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBaslik.Appearance.Options.UseFont = true;
            this.lblBaslik.Appearance.Options.UseImage = true;
            this.lblBaslik.Appearance.Options.UseImageAlign = true;
            this.lblBaslik.Appearance.Options.UseTextOptions = true;
            this.lblBaslik.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblBaslik.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBaslik.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(1158, 54);
            this.lblBaslik.TabIndex = 5;
            this.lblBaslik.Text = "Ödeme Kartları";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Hareketler.png");
            this.ımageList1.Images.SetKeyName(1, "replace2.png");
            this.ımageList1.Images.SetKeyName(2, "wallet_closed.png");
            this.ımageList1.Images.SetKeyName(3, "wallet_closed_add.png");
            this.ımageList1.Images.SetKeyName(4, "wallet_closed_delete.png");
            this.ımageList1.Images.SetKeyName(5, "wallet_closed_edit.png");
            this.ımageList1.Images.SetKeyName(6, "view.png");
            this.ımageList1.Images.SetKeyName(7, "folder_out.png");
            this.ımageList1.Images.SetKeyName(8, "refresh.png");
            this.ımageList1.Images.SetKeyName(9, "folder_out.png");
            this.ımageList1.Images.SetKeyName(10, "funnel.png");
            this.ımageList1.Images.SetKeyName(11, "funnel_delete.png");
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colOdemeTuruKodu
            // 
            this.colOdemeTuruKodu.Caption = "Ödeme Türü Kodu";
            this.colOdemeTuruKodu.FieldName = "OdemeTuruKodu";
            this.colOdemeTuruKodu.Name = "colOdemeTuruKodu";
            this.colOdemeTuruKodu.Visible = true;
            this.colOdemeTuruKodu.VisibleIndex = 0;
            this.colOdemeTuruKodu.Width = 97;
            // 
            // colOdemeTuruAdi
            // 
            this.colOdemeTuruAdi.Caption = "Ödeme Türü Adı";
            this.colOdemeTuruAdi.FieldName = "OdemeTuruAdi";
            this.colOdemeTuruAdi.Name = "colOdemeTuruAdi";
            this.colOdemeTuruAdi.Visible = true;
            this.colOdemeTuruAdi.VisibleIndex = 1;
            this.colOdemeTuruAdi.Width = 185;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 2;
            this.colAciklama.Width = 460;
            // 
            // colKasaGiris
            // 
            this.colKasaGiris.Caption = "Kasa Giriş";
            this.colKasaGiris.FieldName = "KasaGiris";
            this.colKasaGiris.Name = "colKasaGiris";
            this.colKasaGiris.Visible = true;
            this.colKasaGiris.VisibleIndex = 3;
            this.colKasaGiris.Width = 130;
            // 
            // colKasaCikis
            // 
            this.colKasaCikis.Caption = "Kasa Çıkış";
            this.colKasaCikis.FieldName = "KasaCikis";
            this.colKasaCikis.Name = "colKasaCikis";
            this.colKasaCikis.Visible = true;
            this.colKasaCikis.VisibleIndex = 4;
            this.colKasaCikis.Width = 130;
            // 
            // colBakiye
            // 
            this.colBakiye.Caption = "Bakiye";
            this.colBakiye.FieldName = "Bakiye";
            this.colBakiye.Name = "colBakiye";
            this.colBakiye.Visible = true;
            this.colBakiye.VisibleIndex = 5;
            this.colBakiye.Width = 138;
            // 
            // frmOdemeTuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 648);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.lblBaslik);
            this.Name = "frmOdemeTuru";
            this.Text = "Ödeme Türleri";
            this.TransparencyKey = System.Drawing.Color.White;
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContDepolar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDepolar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SimpleButton btnFiltreKapat;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.SimpleButton btnFiltreIptal;
        private DevExpress.XtraEditors.SimpleButton btnFiltre;
        private DevExpress.XtraEditors.FilterControl filterControl1;
        private DevExpress.XtraGrid.GridControl gridContDepolar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridDepolar;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colOdemeTuruKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colOdemeTuruAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colKasaGiris;
        private DevExpress.XtraGrid.Columns.GridColumn colKasaCikis;
        private DevExpress.XtraGrid.Columns.GridColumn colBakiye;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnStokHareketleri;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.LabelControl lblBaslik;
    }
}