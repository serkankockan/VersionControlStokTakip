namespace StokTakip.BackOffice.Depo
{
    partial class frmDepoHareket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepoHareket));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridContHareket = new DevExpress.XtraGrid.GridControl();
            this.stokHareketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridHareket = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFisKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHareket = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkodTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIndirimOrani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIndirimTutari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToplamTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepoKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepoAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeriNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridContDepoStok = new DevExpress.XtraGrid.GridControl();
            this.gridDepoStok = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBarkod1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokGiris = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokCikis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMevcutStok = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridContIstatistik = new DevExpress.XtraGrid.GridControl();
            this.gridIstatistik = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBilgi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKayitSayisi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToplam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokHareketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContDepoStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDepoStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContIstatistik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridIstatistik)).BeginInit();
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
            this.splitContainerControl1.Panel1.Controls.Add(this.gridContHareket);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1163, 542);
            this.splitContainerControl1.SplitterPosition = 299;
            this.splitContainerControl1.TabIndex = 7;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gridContHareket
            // 
            this.gridContHareket.DataSource = this.stokHareketBindingSource;
            this.gridContHareket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContHareket.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridContHareket.Location = new System.Drawing.Point(0, 0);
            this.gridContHareket.MainView = this.gridHareket;
            this.gridContHareket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridContHareket.Name = "gridContHareket";
            this.gridContHareket.Size = new System.Drawing.Size(1163, 299);
            this.gridContHareket.TabIndex = 1;
            this.gridContHareket.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridHareket});
            // 
            // stokHareketBindingSource
            // 
            this.stokHareketBindingSource.DataSource = typeof(StokTakip.Entities.Tables.StokHareket);
            // 
            // gridHareket
            // 
            this.gridHareket.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colFisKodu,
            this.colHareket,
            this.colStokKodu,
            this.colStokAdi,
            this.colBarkodTuru,
            this.colBarkod,
            this.colBirimi,
            this.colMiktar,
            this.colKDV,
            this.colBirimFiyat,
            this.colIndirimOrani,
            this.colIndirimTutari,
            this.colToplamTutar,
            this.colDepoKodu,
            this.colDepoAdi,
            this.colSeriNo,
            this.colTarih,
            this.colSaat,
            this.colAciklama});
            this.gridHareket.GridControl = this.gridContHareket;
            this.gridHareket.Name = "gridHareket";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            // 
            // colFisKodu
            // 
            this.colFisKodu.Caption = "Fiş Kodu";
            this.colFisKodu.FieldName = "FisKodu";
            this.colFisKodu.Name = "colFisKodu";
            this.colFisKodu.OptionsColumn.AllowEdit = false;
            this.colFisKodu.Visible = true;
            this.colFisKodu.VisibleIndex = 0;
            // 
            // colHareket
            // 
            this.colHareket.Caption = "Hareket";
            this.colHareket.FieldName = "Hareket";
            this.colHareket.Name = "colHareket";
            this.colHareket.OptionsColumn.AllowEdit = false;
            this.colHareket.Visible = true;
            this.colHareket.VisibleIndex = 1;
            // 
            // colStokKodu
            // 
            this.colStokKodu.FieldName = "StokKodu";
            this.colStokKodu.Name = "colStokKodu";
            this.colStokKodu.OptionsColumn.AllowEdit = false;
            // 
            // colStokAdi
            // 
            this.colStokAdi.FieldName = "StokAdi";
            this.colStokAdi.Name = "colStokAdi";
            this.colStokAdi.OptionsColumn.AllowEdit = false;
            // 
            // colBarkodTuru
            // 
            this.colBarkodTuru.FieldName = "BarkodTuru";
            this.colBarkodTuru.Name = "colBarkodTuru";
            this.colBarkodTuru.OptionsColumn.AllowEdit = false;
            // 
            // colBarkod
            // 
            this.colBarkod.FieldName = "Barkod";
            this.colBarkod.Name = "colBarkod";
            this.colBarkod.OptionsColumn.AllowEdit = false;
            // 
            // colBirimi
            // 
            this.colBirimi.Caption = "Birimi";
            this.colBirimi.FieldName = "Birimi";
            this.colBirimi.Name = "colBirimi";
            this.colBirimi.OptionsColumn.AllowEdit = false;
            this.colBirimi.Visible = true;
            this.colBirimi.VisibleIndex = 2;
            // 
            // colMiktar
            // 
            this.colMiktar.Caption = "Miktar";
            this.colMiktar.FieldName = "Miktar";
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.OptionsColumn.AllowEdit = false;
            this.colMiktar.Visible = true;
            this.colMiktar.VisibleIndex = 7;
            // 
            // colKDV
            // 
            this.colKDV.Caption = "KDV (%)";
            this.colKDV.DisplayFormat.FormatString = "\'%\'0";
            this.colKDV.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKDV.FieldName = "KDV";
            this.colKDV.Name = "colKDV";
            this.colKDV.OptionsColumn.AllowEdit = false;
            this.colKDV.Visible = true;
            this.colKDV.VisibleIndex = 6;
            // 
            // colBirimFiyat
            // 
            this.colBirimFiyat.Caption = "Birim Fiyatı";
            this.colBirimFiyat.DisplayFormat.FormatString = "C2";
            this.colBirimFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBirimFiyat.FieldName = "BirimFiyat";
            this.colBirimFiyat.Name = "colBirimFiyat";
            this.colBirimFiyat.OptionsColumn.AllowEdit = false;
            this.colBirimFiyat.Visible = true;
            this.colBirimFiyat.VisibleIndex = 8;
            // 
            // colIndirimOrani
            // 
            this.colIndirimOrani.Caption = "İnd. Oranı";
            this.colIndirimOrani.DisplayFormat.FormatString = "\'%\'0";
            this.colIndirimOrani.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIndirimOrani.FieldName = "IndirimOrani";
            this.colIndirimOrani.Name = "colIndirimOrani";
            this.colIndirimOrani.OptionsColumn.AllowEdit = false;
            this.colIndirimOrani.Visible = true;
            this.colIndirimOrani.VisibleIndex = 9;
            // 
            // colIndirimTutari
            // 
            this.colIndirimTutari.Caption = "İnd. Tutar";
            this.colIndirimTutari.DisplayFormat.FormatString = "C2";
            this.colIndirimTutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIndirimTutari.FieldName = "IndirimTutari";
            this.colIndirimTutari.Name = "colIndirimTutari";
            this.colIndirimTutari.OptionsColumn.AllowEdit = false;
            this.colIndirimTutari.Visible = true;
            this.colIndirimTutari.VisibleIndex = 10;
            // 
            // colToplamTutar
            // 
            this.colToplamTutar.Caption = "Toplam Tutar";
            this.colToplamTutar.DisplayFormat.FormatString = "C2";
            this.colToplamTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colToplamTutar.FieldName = "ToplamTutar";
            this.colToplamTutar.Name = "colToplamTutar";
            this.colToplamTutar.OptionsColumn.AllowEdit = false;
            this.colToplamTutar.Visible = true;
            this.colToplamTutar.VisibleIndex = 11;
            // 
            // colDepoKodu
            // 
            this.colDepoKodu.FieldName = "DepoKodu";
            this.colDepoKodu.Name = "colDepoKodu";
            this.colDepoKodu.OptionsColumn.AllowEdit = false;
            // 
            // colDepoAdi
            // 
            this.colDepoAdi.FieldName = "DepoAdi";
            this.colDepoAdi.Name = "colDepoAdi";
            this.colDepoAdi.OptionsColumn.AllowEdit = false;
            // 
            // colSeriNo
            // 
            this.colSeriNo.FieldName = "SeriNo";
            this.colSeriNo.Name = "colSeriNo";
            this.colSeriNo.OptionsColumn.AllowEdit = false;
            // 
            // colTarih
            // 
            this.colTarih.DisplayFormat.FormatString = "d";
            this.colTarih.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.OptionsColumn.AllowEdit = false;
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 3;
            // 
            // colSaat
            // 
            this.colSaat.Caption = "Saat";
            this.colSaat.DisplayFormat.FormatString = "t";
            this.colSaat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colSaat.FieldName = "Saat";
            this.colSaat.Name = "colSaat";
            this.colSaat.Visible = true;
            this.colSaat.VisibleIndex = 4;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 5;
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.groupControl2);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(1163, 238);
            this.splitContainerControl2.SplitterPosition = 655;
            this.splitContainerControl2.TabIndex = 0;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridContDepoStok);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(655, 238);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Depodaki Stok Miktarı";
            // 
            // gridContDepoStok
            // 
            this.gridContDepoStok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContDepoStok.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridContDepoStok.Location = new System.Drawing.Point(2, 20);
            this.gridContDepoStok.MainView = this.gridDepoStok;
            this.gridContDepoStok.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridContDepoStok.Name = "gridContDepoStok";
            this.gridContDepoStok.Size = new System.Drawing.Size(651, 216);
            this.gridContDepoStok.TabIndex = 2;
            this.gridContDepoStok.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridDepoStok});
            // 
            // gridDepoStok
            // 
            this.gridDepoStok.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBarkod1,
            this.colUrunAdi,
            this.colStokGiris,
            this.colStokCikis,
            this.colMevcutStok});
            this.gridDepoStok.GridControl = this.gridContDepoStok;
            this.gridDepoStok.Name = "gridDepoStok";
            this.gridDepoStok.OptionsView.ShowGroupPanel = false;
            // 
            // colBarkod1
            // 
            this.colBarkod1.Caption = "Barkod";
            this.colBarkod1.FieldName = "Barkod";
            this.colBarkod1.Name = "colBarkod1";
            this.colBarkod1.Visible = true;
            this.colBarkod1.VisibleIndex = 0;
            // 
            // colUrunAdi
            // 
            this.colUrunAdi.Caption = "Ürün Adı";
            this.colUrunAdi.FieldName = "StokAdi";
            this.colUrunAdi.Name = "colUrunAdi";
            this.colUrunAdi.Visible = true;
            this.colUrunAdi.VisibleIndex = 1;
            // 
            // colStokGiris
            // 
            this.colStokGiris.Caption = "Stok Giriş";
            this.colStokGiris.FieldName = "StokGiris";
            this.colStokGiris.Name = "colStokGiris";
            this.colStokGiris.Visible = true;
            this.colStokGiris.VisibleIndex = 2;
            // 
            // colStokCikis
            // 
            this.colStokCikis.Caption = "Stok Çıkış";
            this.colStokCikis.FieldName = "StokCikis";
            this.colStokCikis.Name = "colStokCikis";
            this.colStokCikis.Visible = true;
            this.colStokCikis.VisibleIndex = 3;
            // 
            // colMevcutStok
            // 
            this.colMevcutStok.Caption = "Mevcut Stok";
            this.colMevcutStok.FieldName = "MevcutStok";
            this.colMevcutStok.Name = "colMevcutStok";
            this.colMevcutStok.Visible = true;
            this.colMevcutStok.VisibleIndex = 4;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridContIstatistik);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(503, 238);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Depo İstatistikleri";
            // 
            // gridContIstatistik
            // 
            this.gridContIstatistik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContIstatistik.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridContIstatistik.Location = new System.Drawing.Point(2, 20);
            this.gridContIstatistik.MainView = this.gridIstatistik;
            this.gridContIstatistik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridContIstatistik.Name = "gridContIstatistik";
            this.gridContIstatistik.Size = new System.Drawing.Size(499, 216);
            this.gridContIstatistik.TabIndex = 2;
            this.gridContIstatistik.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridIstatistik});
            // 
            // gridIstatistik
            // 
            this.gridIstatistik.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBilgi,
            this.colKayitSayisi,
            this.colToplam});
            this.gridIstatistik.GridControl = this.gridContIstatistik;
            this.gridIstatistik.Name = "gridIstatistik";
            this.gridIstatistik.OptionsView.ShowGroupPanel = false;
            // 
            // colBilgi
            // 
            this.colBilgi.Caption = "Bilgi";
            this.colBilgi.FieldName = "Bilgi";
            this.colBilgi.Name = "colBilgi";
            this.colBilgi.Visible = true;
            this.colBilgi.VisibleIndex = 0;
            // 
            // colKayitSayisi
            // 
            this.colKayitSayisi.Caption = "Kayıt Sayısı";
            this.colKayitSayisi.FieldName = "KayitSayisi";
            this.colKayitSayisi.Name = "colKayitSayisi";
            this.colKayitSayisi.Visible = true;
            this.colKayitSayisi.VisibleIndex = 1;
            // 
            // colToplam
            // 
            this.colToplam.Caption = "Toplam";
            this.colToplam.FieldName = "Tutar";
            this.colToplam.Name = "colToplam";
            this.colToplam.Visible = true;
            this.colToplam.VisibleIndex = 2;
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnKapat);
            this.grpMenu.Controls.Add(this.btnAra);
            this.grpMenu.Controls.Add(this.btnGuncelle);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 596);
            this.grpMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(1163, 68);
            this.grpMenu.TabIndex = 6;
            this.grpMenu.Text = "Menü";
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 0;
            this.btnKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnKapat.Location = new System.Drawing.Point(1069, 26);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(83, 35);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "folder_out.png");
            this.ımageList1.Images.SetKeyName(1, "refresh.png");
            this.ımageList1.Images.SetKeyName(2, "view.png");
            // 
            // btnAra
            // 
            this.btnAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAra.ImageOptions.ImageIndex = 2;
            this.btnAra.ImageOptions.ImageList = this.ımageList1;
            this.btnAra.Location = new System.Drawing.Point(93, 26);
            this.btnAra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(83, 35);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuncelle.ImageOptions.ImageIndex = 1;
            this.btnGuncelle.ImageOptions.ImageList = this.ımageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(4, 26);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(83, 35);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
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
            this.lblBaslik.Size = new System.Drawing.Size(1163, 54);
            this.lblBaslik.TabIndex = 5;
            this.lblBaslik.Text = "Depo Hareket";
            // 
            // frmDepoHareket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 664);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.lblBaslik);
            this.Name = "frmDepoHareket";
            this.Text = "Depo Hareketleri";
            this.Load += new System.EventHandler(this.frmDepoHareket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokHareketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContDepoStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDepoStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContIstatistik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridIstatistik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridContHareket;
        private DevExpress.XtraGrid.Views.Grid.GridView gridHareket;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridContDepoStok;
        private DevExpress.XtraGrid.Views.Grid.GridView gridDepoStok;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridContIstatistik;
        private DevExpress.XtraGrid.Views.Grid.GridView gridIstatistik;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.BindingSource stokHareketBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colFisKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colHareket;
        private DevExpress.XtraGrid.Columns.GridColumn colStokKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkodTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimi;
        private DevExpress.XtraGrid.Columns.GridColumn colMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn colKDV;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn colIndirimOrani;
        private DevExpress.XtraGrid.Columns.GridColumn colIndirimTutari;
        private DevExpress.XtraGrid.Columns.GridColumn colToplamTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colDepoKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colDepoAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colSeriNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colSaat;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkod1;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colStokGiris;
        private DevExpress.XtraGrid.Columns.GridColumn colStokCikis;
        private DevExpress.XtraGrid.Columns.GridColumn colMevcutStok;
        private DevExpress.XtraGrid.Columns.GridColumn colBilgi;
        private DevExpress.XtraGrid.Columns.GridColumn colKayitSayisi;
        private DevExpress.XtraGrid.Columns.GridColumn colToplam;
    }
}