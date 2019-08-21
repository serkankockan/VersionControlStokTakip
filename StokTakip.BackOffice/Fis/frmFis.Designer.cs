namespace StokTakip.BackOffice.Fis
{
    partial class frmFis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFis));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.btnFiltreKapat = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnFiltreIptal = new DevExpress.XtraEditors.SimpleButton();
            this.btnFiltre = new DevExpress.XtraEditors.SimpleButton();
            this.filterControl1 = new DevExpress.XtraEditors.FilterControl();
            this.gridContFis = new DevExpress.XtraGrid.GridControl();
            this.gridFis = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFisKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFisTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBelgeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlasiyerKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlasiyerAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIskontoOrani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIskontoTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToplamTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.dropDownButton1 = new DevExpress.XtraEditors.DropDownButton();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barSatisFisi = new DevExpress.XtraBars.BarButtonItem();
            this.colToptanSatisFaturasi = new DevExpress.XtraBars.BarButtonItem();
            this.barAlisFisi = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.barSatisIadeFaturasi = new DevExpress.XtraBars.BarButtonItem();
            this.barAlisIadeFaturasi = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
            this.barTahsilatFisi = new DevExpress.XtraBars.BarButtonItem();
            this.varOdemeFisi = new DevExpress.XtraBars.BarButtonItem();
            this.barCariDevirFisi = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem4 = new DevExpress.XtraBars.BarSubItem();
            this.barSayimFazlasiFisi = new DevExpress.XtraBars.BarButtonItem();
            this.barSayimEksigiFisi = new DevExpress.XtraBars.BarButtonItem();
            this.barStokDevirFisi = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barAndDockingController1 = new DevExpress.XtraBars.BarAndDockingController(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContFis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 55);
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.btnFiltreKapat);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnFiltreIptal);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnFiltre);
            this.splitContainerControl1.Panel1.Controls.Add(this.filterControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridContFis);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1327, 577);
            this.splitContainerControl1.SplitterPosition = 187;
            this.splitContainerControl1.TabIndex = 7;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // btnFiltreKapat
            // 
            this.btnFiltreKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltreKapat.ImageOptions.ImageIndex = 0;
            this.btnFiltreKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnFiltreKapat.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnFiltreKapat.Location = new System.Drawing.Point(1267, 141);
            this.btnFiltreKapat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFiltreKapat.Name = "btnFiltreKapat";
            this.btnFiltreKapat.Size = new System.Drawing.Size(50, 38);
            this.btnFiltreKapat.TabIndex = 2;
            this.btnFiltreKapat.Click += new System.EventHandler(this.btnFiltreKapat_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "folder_out.png");
            this.ımageList1.Images.SetKeyName(1, "note.png");
            this.ımageList1.Images.SetKeyName(2, "note_add.png");
            this.ımageList1.Images.SetKeyName(3, "note_delete.png");
            this.ımageList1.Images.SetKeyName(4, "note_edit.png");
            this.ımageList1.Images.SetKeyName(5, "note_information.png");
            this.ımageList1.Images.SetKeyName(6, "note_ok.png");
            this.ımageList1.Images.SetKeyName(7, "refresh.png");
            this.ımageList1.Images.SetKeyName(8, "view.png");
            this.ımageList1.Images.SetKeyName(9, "funnel.png");
            this.ımageList1.Images.SetKeyName(10, "funnel_delete.png");
            // 
            // btnFiltreIptal
            // 
            this.btnFiltreIptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltreIptal.ImageOptions.ImageIndex = 10;
            this.btnFiltreIptal.ImageOptions.ImageList = this.ımageList1;
            this.btnFiltreIptal.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnFiltreIptal.Location = new System.Drawing.Point(1213, 141);
            this.btnFiltreIptal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFiltreIptal.Name = "btnFiltreIptal";
            this.btnFiltreIptal.Size = new System.Drawing.Size(50, 38);
            this.btnFiltreIptal.TabIndex = 2;
            this.btnFiltreIptal.Click += new System.EventHandler(this.btnFiltreIptal_Click);
            // 
            // btnFiltre
            // 
            this.btnFiltre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltre.ImageOptions.ImageIndex = 9;
            this.btnFiltre.ImageOptions.ImageList = this.ımageList1;
            this.btnFiltre.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnFiltre.Location = new System.Drawing.Point(1158, 141);
            this.btnFiltre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFiltre.Name = "btnFiltre";
            this.btnFiltre.Size = new System.Drawing.Size(50, 38);
            this.btnFiltre.TabIndex = 2;
            this.btnFiltre.Click += new System.EventHandler(this.btnFiltre_Click);
            // 
            // filterControl1
            // 
            this.filterControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.filterControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterControl1.Location = new System.Drawing.Point(0, 0);
            this.filterControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterControl1.Name = "filterControl1";
            this.filterControl1.Size = new System.Drawing.Size(1327, 187);
            this.filterControl1.SortFilterColumns = false;
            this.filterControl1.SourceControl = this.gridContFis;
            this.filterControl1.TabIndex = 0;
            this.filterControl1.Text = "filterControl1";
            // 
            // gridContFis
            // 
            this.gridContFis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContFis.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridContFis.Location = new System.Drawing.Point(0, 0);
            this.gridContFis.MainView = this.gridFis;
            this.gridContFis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridContFis.Name = "gridContFis";
            this.gridContFis.Size = new System.Drawing.Size(1327, 385);
            this.gridContFis.TabIndex = 0;
            this.gridContFis.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridFis});
            // 
            // gridFis
            // 
            this.gridFis.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colFisKodu,
            this.colFisTuru,
            this.colCariTuru,
            this.colCariKodu,
            this.colCariAdi,
            this.colBelgeNo,
            this.colTarih,
            this.colSaat,
            this.colPlasiyerKodu,
            this.colPlasiyerAdi,
            this.colAciklama,
            this.colIskontoOrani,
            this.colIskontoTutar,
            this.colToplamTutar});
            this.gridFis.GridControl = this.gridContFis;
            this.gridFis.Name = "gridFis";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colFisKodu
            // 
            this.colFisKodu.Caption = "Fiş Kodu";
            this.colFisKodu.FieldName = "FisKodu";
            this.colFisKodu.Name = "colFisKodu";
            this.colFisKodu.Visible = true;
            this.colFisKodu.VisibleIndex = 0;
            this.colFisKodu.Width = 109;
            // 
            // colFisTuru
            // 
            this.colFisTuru.Caption = "Fiş Türü";
            this.colFisTuru.FieldName = "FisTuru";
            this.colFisTuru.Name = "colFisTuru";
            this.colFisTuru.Visible = true;
            this.colFisTuru.VisibleIndex = 1;
            this.colFisTuru.Width = 109;
            // 
            // colCariTuru
            // 
            this.colCariTuru.Caption = "Cari Türü";
            this.colCariTuru.FieldName = "CariTuru";
            this.colCariTuru.Name = "colCariTuru";
            // 
            // colCariKodu
            // 
            this.colCariKodu.Caption = "Cari Kodu";
            this.colCariKodu.FieldName = "CariKodu";
            this.colCariKodu.Name = "colCariKodu";
            this.colCariKodu.Visible = true;
            this.colCariKodu.VisibleIndex = 2;
            this.colCariKodu.Width = 109;
            // 
            // colCariAdi
            // 
            this.colCariAdi.Caption = "Cari Adı";
            this.colCariAdi.FieldName = "CariAdi";
            this.colCariAdi.Name = "colCariAdi";
            this.colCariAdi.Visible = true;
            this.colCariAdi.VisibleIndex = 3;
            this.colCariAdi.Width = 109;
            // 
            // colBelgeNo
            // 
            this.colBelgeNo.Caption = "Belge No";
            this.colBelgeNo.FieldName = "BelgeNo";
            this.colBelgeNo.Name = "colBelgeNo";
            this.colBelgeNo.Visible = true;
            this.colBelgeNo.VisibleIndex = 4;
            this.colBelgeNo.Width = 109;
            // 
            // colTarih
            // 
            this.colTarih.Caption = "Tarih";
            this.colTarih.DisplayFormat.FormatString = "d";
            this.colTarih.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 5;
            this.colTarih.Width = 109;
            // 
            // colSaat
            // 
            this.colSaat.Caption = "Saat";
            this.colSaat.DisplayFormat.FormatString = "t";
            this.colSaat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colSaat.FieldName = "Tarih";
            this.colSaat.Name = "colSaat";
            this.colSaat.Visible = true;
            this.colSaat.VisibleIndex = 6;
            this.colSaat.Width = 109;
            // 
            // colPlasiyerKodu
            // 
            this.colPlasiyerKodu.FieldName = "PlasiyerKodu";
            this.colPlasiyerKodu.Name = "colPlasiyerKodu";
            // 
            // colPlasiyerAdi
            // 
            this.colPlasiyerAdi.Caption = "Plasiyer Adı";
            this.colPlasiyerAdi.FieldName = "PlasiyerAdi";
            this.colPlasiyerAdi.Name = "colPlasiyerAdi";
            this.colPlasiyerAdi.Visible = true;
            this.colPlasiyerAdi.VisibleIndex = 7;
            this.colPlasiyerAdi.Width = 109;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 8;
            this.colAciklama.Width = 147;
            // 
            // colIskontoOrani
            // 
            this.colIskontoOrani.FieldName = "IskontoOrani";
            this.colIskontoOrani.Name = "colIskontoOrani";
            this.colIskontoOrani.Visible = true;
            this.colIskontoOrani.VisibleIndex = 9;
            this.colIskontoOrani.Width = 73;
            // 
            // colIskontoTutar
            // 
            this.colIskontoTutar.FieldName = "IskontoTutar";
            this.colIskontoTutar.Name = "colIskontoTutar";
            this.colIskontoTutar.Visible = true;
            this.colIskontoTutar.VisibleIndex = 10;
            this.colIskontoTutar.Width = 95;
            // 
            // colToplamTutar
            // 
            this.colToplamTutar.FieldName = "ToplamTutar";
            this.colToplamTutar.Name = "colToplamTutar";
            this.colToplamTutar.Visible = true;
            this.colToplamTutar.VisibleIndex = 11;
            this.colToplamTutar.Width = 122;
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.dropDownButton1);
            this.grpMenu.Controls.Add(this.btnKapat);
            this.grpMenu.Controls.Add(this.btnAra);
            this.grpMenu.Controls.Add(this.btnGuncelle);
            this.grpMenu.Controls.Add(this.btnSil);
            this.grpMenu.Controls.Add(this.btnDuzenle);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 632);
            this.grpMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(1327, 68);
            this.grpMenu.TabIndex = 6;
            this.grpMenu.Text = "Menü";
            // 
            // dropDownButton1
            // 
            this.dropDownButton1.DropDownControl = this.popupMenu1;
            this.dropDownButton1.ImageOptions.ImageIndex = 2;
            this.dropDownButton1.ImageOptions.ImageList = this.ımageList1;
            this.dropDownButton1.Location = new System.Drawing.Point(10, 26);
            this.dropDownButton1.Name = "dropDownButton1";
            this.dropDownButton1.Size = new System.Drawing.Size(83, 35);
            this.dropDownButton1.TabIndex = 3;
            this.dropDownButton1.Text = "Ekle";
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem3, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem4, true)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Faturalar";
            this.barSubItem1.Id = 11;
            this.barSubItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSubItem1.ImageOptions.Image")));
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSatisFisi),
            new DevExpress.XtraBars.LinkPersistInfo(this.colToptanSatisFaturasi),
            new DevExpress.XtraBars.LinkPersistInfo(this.barAlisFisi, true)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barSatisFisi
            // 
            this.barSatisFisi.Caption = "Perakende Satış Faturası";
            this.barSatisFisi.Id = 1;
            this.barSatisFisi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSatisFisi.ImageOptions.Image")));
            this.barSatisFisi.Name = "barSatisFisi";
            this.barSatisFisi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FisIslem_Click);
            // 
            // colToptanSatisFaturasi
            // 
            this.colToptanSatisFaturasi.Caption = "Toptan Satış Faturası";
            this.colToptanSatisFaturasi.Id = 2;
            this.colToptanSatisFaturasi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colToptanSatisFaturasi.ImageOptions.Image")));
            this.colToptanSatisFaturasi.Name = "colToptanSatisFaturasi";
            this.colToptanSatisFaturasi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FisIslem_Click);
            // 
            // barAlisFisi
            // 
            this.barAlisFisi.Caption = "Alış Faturası";
            this.barAlisFisi.Id = 0;
            this.barAlisFisi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barAlisFisi.ImageOptions.Image")));
            this.barAlisFisi.Name = "barAlisFisi";
            this.barAlisFisi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FisIslem_Click);
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "İade Faturaları";
            this.barSubItem2.Id = 12;
            this.barSubItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSubItem2.ImageOptions.Image")));
            this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSatisIadeFaturasi),
            new DevExpress.XtraBars.LinkPersistInfo(this.barAlisIadeFaturasi, true)});
            this.barSubItem2.Name = "barSubItem2";
            // 
            // barSatisIadeFaturasi
            // 
            this.barSatisIadeFaturasi.Caption = "Satış İade Faturası";
            this.barSatisIadeFaturasi.Id = 4;
            this.barSatisIadeFaturasi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSatisIadeFaturasi.ImageOptions.Image")));
            this.barSatisIadeFaturasi.Name = "barSatisIadeFaturasi";
            this.barSatisIadeFaturasi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FisIslem_Click);
            // 
            // barAlisIadeFaturasi
            // 
            this.barAlisIadeFaturasi.Caption = "Alış İade Faturası";
            this.barAlisIadeFaturasi.Id = 3;
            this.barAlisIadeFaturasi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barAlisIadeFaturasi.ImageOptions.Image")));
            this.barAlisIadeFaturasi.Name = "barAlisIadeFaturasi";
            this.barAlisIadeFaturasi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FisIslem_Click);
            // 
            // barSubItem3
            // 
            this.barSubItem3.Caption = "Kasa Fişleri";
            this.barSubItem3.Id = 13;
            this.barSubItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSubItem3.ImageOptions.Image")));
            this.barSubItem3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barTahsilatFisi),
            new DevExpress.XtraBars.LinkPersistInfo(this.varOdemeFisi),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCariDevirFisi)});
            this.barSubItem3.Name = "barSubItem3";
            // 
            // barTahsilatFisi
            // 
            this.barTahsilatFisi.Caption = "Tahsilat Fişi";
            this.barTahsilatFisi.Id = 5;
            this.barTahsilatFisi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barTahsilatFisi.ImageOptions.Image")));
            this.barTahsilatFisi.Name = "barTahsilatFisi";
            // 
            // varOdemeFisi
            // 
            this.varOdemeFisi.Caption = "Ödeme Fişi";
            this.varOdemeFisi.Id = 6;
            this.varOdemeFisi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("varOdemeFisi.ImageOptions.Image")));
            this.varOdemeFisi.Name = "varOdemeFisi";
            // 
            // barCariDevirFisi
            // 
            this.barCariDevirFisi.Caption = "Cari Devir Fişi";
            this.barCariDevirFisi.Id = 7;
            this.barCariDevirFisi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barCariDevirFisi.ImageOptions.Image")));
            this.barCariDevirFisi.Name = "barCariDevirFisi";
            // 
            // barSubItem4
            // 
            this.barSubItem4.Caption = "Stok Fişleri";
            this.barSubItem4.Id = 14;
            this.barSubItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSubItem4.ImageOptions.Image")));
            this.barSubItem4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSayimFazlasiFisi),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSayimEksigiFisi),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStokDevirFisi)});
            this.barSubItem4.Name = "barSubItem4";
            // 
            // barSayimFazlasiFisi
            // 
            this.barSayimFazlasiFisi.Caption = "Sayım Fazlası Fişi";
            this.barSayimFazlasiFisi.Id = 8;
            this.barSayimFazlasiFisi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSayimFazlasiFisi.ImageOptions.Image")));
            this.barSayimFazlasiFisi.Name = "barSayimFazlasiFisi";
            this.barSayimFazlasiFisi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FisIslem_Click);
            // 
            // barSayimEksigiFisi
            // 
            this.barSayimEksigiFisi.Caption = "Sayım Eksiği Fişi";
            this.barSayimEksigiFisi.Id = 9;
            this.barSayimEksigiFisi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSayimEksigiFisi.ImageOptions.Image")));
            this.barSayimEksigiFisi.Name = "barSayimEksigiFisi";
            this.barSayimEksigiFisi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FisIslem_Click);
            // 
            // barStokDevirFisi
            // 
            this.barStokDevirFisi.Caption = "Stok Devir Fişi";
            this.barStokDevirFisi.Id = 10;
            this.barStokDevirFisi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barStokDevirFisi.ImageOptions.Image")));
            this.barStokDevirFisi.Name = "barStokDevirFisi";
            this.barStokDevirFisi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FisIslem_Click);
            // 
            // barManager1
            // 
            this.barManager1.Controller = this.barAndDockingController1;
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barAlisFisi,
            this.barSatisFisi,
            this.colToptanSatisFaturasi,
            this.barAlisIadeFaturasi,
            this.barSatisIadeFaturasi,
            this.barTahsilatFisi,
            this.varOdemeFisi,
            this.barCariDevirFisi,
            this.barSayimFazlasiFisi,
            this.barSayimEksigiFisi,
            this.barStokDevirFisi,
            this.barSubItem1,
            this.barSubItem2,
            this.barSubItem3,
            this.barSubItem4});
            this.barManager1.MaxItemId = 15;
            this.barManager1.PopupMenuAlignment = DevExpress.XtraBars.PopupMenuAlignment.Right;
            // 
            // barAndDockingController1
            // 
            this.barAndDockingController1.PaintStyleName = "Office2000";
            this.barAndDockingController1.PropertiesBar.AllowLinkLighting = false;
            this.barAndDockingController1.PropertiesBar.DefaultGlyphSize = new System.Drawing.Size(16, 16);
            this.barAndDockingController1.PropertiesBar.DefaultLargeGlyphSize = new System.Drawing.Size(32, 32);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1327, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 700);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1327, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 700);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1327, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 700);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 0;
            this.btnKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnKapat.Location = new System.Drawing.Point(1233, 26);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(83, 35);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnAra
            // 
            this.btnAra.ImageOptions.ImageIndex = 8;
            this.btnAra.ImageOptions.ImageList = this.ımageList1;
            this.btnAra.Location = new System.Drawing.Point(365, 26);
            this.btnAra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(83, 35);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageOptions.ImageIndex = 7;
            this.btnGuncelle.ImageOptions.ImageList = this.ımageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(276, 26);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(83, 35);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.ImageIndex = 3;
            this.btnSil.ImageOptions.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(187, 26);
            this.btnSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(83, 35);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.ImageOptions.ImageIndex = 4;
            this.btnDuzenle.ImageOptions.ImageList = this.ımageList1;
            this.btnDuzenle.Location = new System.Drawing.Point(99, 26);
            this.btnDuzenle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(83, 35);
            this.btnDuzenle.TabIndex = 0;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
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
            this.lblBaslik.Size = new System.Drawing.Size(1327, 55);
            this.lblBaslik.TabIndex = 5;
            this.lblBaslik.Text = "Fiş ve Faturalar";
            // 
            // frmFis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 700);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmFis";
            this.Text = "Fiş ve Faturalar";
            this.Load += new System.EventHandler(this.frmFis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContFis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SimpleButton btnFiltreKapat;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.SimpleButton btnFiltreIptal;
        private DevExpress.XtraEditors.SimpleButton btnFiltre;
        private DevExpress.XtraEditors.FilterControl filterControl1;
        private DevExpress.XtraGrid.GridControl gridContFis;
        private DevExpress.XtraGrid.Views.Grid.GridView gridFis;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colFisKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colFisTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colCariTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colCariKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colCariAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colBelgeNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colSaat;
        private DevExpress.XtraGrid.Columns.GridColumn colPlasiyerKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colPlasiyerAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colIskontoOrani;
        private DevExpress.XtraGrid.Columns.GridColumn colIskontoTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colToplamTutar;
        private DevExpress.XtraEditors.DropDownButton dropDownButton1;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem barAlisFisi;
        private DevExpress.XtraBars.BarButtonItem barSatisFisi;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem colToptanSatisFaturasi;
        private DevExpress.XtraBars.BarButtonItem barAlisIadeFaturasi;
        private DevExpress.XtraBars.BarButtonItem barSatisIadeFaturasi;
        private DevExpress.XtraBars.BarButtonItem barTahsilatFisi;
        private DevExpress.XtraBars.BarButtonItem varOdemeFisi;
        private DevExpress.XtraBars.BarButtonItem barCariDevirFisi;
        private DevExpress.XtraBars.BarButtonItem barSayimFazlasiFisi;
        private DevExpress.XtraBars.BarButtonItem barSayimEksigiFisi;
        private DevExpress.XtraBars.BarButtonItem barStokDevirFisi;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarSubItem barSubItem3;
        private DevExpress.XtraBars.BarSubItem barSubItem4;
        private DevExpress.XtraBars.BarAndDockingController barAndDockingController1;
    }
}