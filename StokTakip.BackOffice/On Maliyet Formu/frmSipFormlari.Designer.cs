namespace StokTakip.BackOffice.On_Maliyet_Formu
{
    partial class frmSipFormlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSipFormlari));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.btnFiltreKapat = new DevExpress.XtraEditors.SimpleButton();
            this.imgMenu = new System.Windows.Forms.ImageList(this.components);
            this.btnFiltreIptal = new DevExpress.XtraEditors.SimpleButton();
            this.btnFiltre = new DevExpress.XtraEditors.SimpleButton();
            this.filterControl1 = new DevExpress.XtraEditors.FilterControl();
            this.gridContFormlar = new DevExpress.XtraGrid.GridControl();
            this.gridFormlar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSiparisNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurumu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMusteriAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesenNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMakina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBoyaGideri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProfil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKumasCinsiVeEni = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassSayisi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBaskiEni = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKagitCinsi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEni = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransferHizi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSiparisTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransferDerecesi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsTipi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSiparisMiktari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPazarlamaci = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesinator = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnIslemler = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnKopyala = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContFormlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFormlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 63);
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.btnFiltreKapat);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnFiltreIptal);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnFiltre);
            this.splitContainerControl1.Panel1.Controls.Add(this.filterControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridContFormlar);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1218, 543);
            this.splitContainerControl1.SplitterPosition = 78;
            this.splitContainerControl1.TabIndex = 9;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // btnFiltreKapat
            // 
            this.btnFiltreKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltreKapat.ImageOptions.ImageIndex = 6;
            this.btnFiltreKapat.ImageOptions.ImageList = this.imgMenu;
            this.btnFiltreKapat.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnFiltreKapat.Location = new System.Drawing.Point(1148, 21);
            this.btnFiltreKapat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFiltreKapat.Name = "btnFiltreKapat";
            this.btnFiltreKapat.Size = new System.Drawing.Size(58, 47);
            this.btnFiltreKapat.TabIndex = 2;
            this.btnFiltreKapat.Click += new System.EventHandler(this.btnFiltreKapat_Click);
            // 
            // imgMenu
            // 
            this.imgMenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgMenu.ImageStream")));
            this.imgMenu.TransparentColor = System.Drawing.Color.Transparent;
            this.imgMenu.Images.SetKeyName(0, "Cari Bilgi.png");
            this.imgMenu.Images.SetKeyName(1, "Cari Düzenle.png");
            this.imgMenu.Images.SetKeyName(2, "Cari Ekle.png");
            this.imgMenu.Images.SetKeyName(3, "Cari Hareket.png");
            this.imgMenu.Images.SetKeyName(4, "cari kpyala.png");
            this.imgMenu.Images.SetKeyName(5, "Cari Sil.png");
            this.imgMenu.Images.SetKeyName(6, "folder_out.png");
            this.imgMenu.Images.SetKeyName(7, "funnel.png");
            this.imgMenu.Images.SetKeyName(8, "funnel_delete.png");
            this.imgMenu.Images.SetKeyName(9, "refresh.png");
            this.imgMenu.Images.SetKeyName(10, "user.png");
            this.imgMenu.Images.SetKeyName(11, "view.png");
            // 
            // btnFiltreIptal
            // 
            this.btnFiltreIptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltreIptal.ImageOptions.ImageIndex = 8;
            this.btnFiltreIptal.ImageOptions.ImageList = this.imgMenu;
            this.btnFiltreIptal.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnFiltreIptal.Location = new System.Drawing.Point(1085, 21);
            this.btnFiltreIptal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFiltreIptal.Name = "btnFiltreIptal";
            this.btnFiltreIptal.Size = new System.Drawing.Size(58, 47);
            this.btnFiltreIptal.TabIndex = 2;
            this.btnFiltreIptal.Click += new System.EventHandler(this.btnFiltreIptal_Click);
            // 
            // btnFiltre
            // 
            this.btnFiltre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltre.ImageOptions.ImageIndex = 7;
            this.btnFiltre.ImageOptions.ImageList = this.imgMenu;
            this.btnFiltre.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnFiltre.Location = new System.Drawing.Point(1021, 21);
            this.btnFiltre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFiltre.Name = "btnFiltre";
            this.btnFiltre.Size = new System.Drawing.Size(58, 47);
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
            this.filterControl1.Size = new System.Drawing.Size(1218, 78);
            this.filterControl1.SortFilterColumns = false;
            this.filterControl1.SourceControl = this.gridContFormlar;
            this.filterControl1.TabIndex = 0;
            this.filterControl1.Text = "filterControl1";
            // 
            // gridContFormlar
            // 
            this.gridContFormlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContFormlar.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridContFormlar.Location = new System.Drawing.Point(0, 0);
            this.gridContFormlar.MainView = this.gridFormlar;
            this.gridContFormlar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridContFormlar.Name = "gridContFormlar";
            this.gridContFormlar.Size = new System.Drawing.Size(1218, 459);
            this.gridContFormlar.TabIndex = 0;
            this.gridContFormlar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridFormlar});
            this.gridContFormlar.DoubleClick += new System.EventHandler(this.gridContFormlar_DoubleClick);
            // 
            // gridFormlar
            // 
            this.gridFormlar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colSiparisNo,
            this.colDurumu,
            this.colMusteriAdi,
            this.colDesenNo,
            this.colMakina,
            this.colBoyaGideri,
            this.colProfil,
            this.colKumasCinsiVeEni,
            this.colPassSayisi,
            this.colBaskiEni,
            this.colKagitCinsi,
            this.colEni,
            this.colTransferHizi,
            this.colSiparisTarihi,
            this.colTransferDerecesi,
            this.colIsTipi,
            this.colSiparisMiktari,
            this.colPazarlamaci,
            this.colDesinator});
            this.gridFormlar.GridControl = this.gridContFormlar;
            this.gridFormlar.Name = "gridFormlar";
            this.gridFormlar.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.Caption = "Sipariş No";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ReadOnly = true;
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 69;
            // 
            // colSiparisNo
            // 
            this.colSiparisNo.FieldName = "SiparisNo";
            this.colSiparisNo.Name = "colSiparisNo";
            this.colSiparisNo.OptionsColumn.AllowEdit = false;
            this.colSiparisNo.Visible = true;
            this.colSiparisNo.VisibleIndex = 19;
            this.colSiparisNo.Width = 64;
            // 
            // colDurumu
            // 
            this.colDurumu.FieldName = "Durumu";
            this.colDurumu.Name = "colDurumu";
            this.colDurumu.OptionsColumn.AllowEdit = false;
            this.colDurumu.Visible = true;
            this.colDurumu.VisibleIndex = 1;
            this.colDurumu.Width = 42;
            // 
            // colMusteriAdi
            // 
            this.colMusteriAdi.FieldName = "MusteriAdi";
            this.colMusteriAdi.Name = "colMusteriAdi";
            this.colMusteriAdi.OptionsColumn.AllowEdit = false;
            this.colMusteriAdi.Visible = true;
            this.colMusteriAdi.VisibleIndex = 2;
            this.colMusteriAdi.Width = 64;
            // 
            // colDesenNo
            // 
            this.colDesenNo.FieldName = "DesenNo";
            this.colDesenNo.Name = "colDesenNo";
            this.colDesenNo.OptionsColumn.AllowEdit = false;
            this.colDesenNo.Visible = true;
            this.colDesenNo.VisibleIndex = 3;
            this.colDesenNo.Width = 64;
            // 
            // colMakina
            // 
            this.colMakina.FieldName = "Makina";
            this.colMakina.Name = "colMakina";
            this.colMakina.OptionsColumn.AllowEdit = false;
            this.colMakina.Visible = true;
            this.colMakina.VisibleIndex = 4;
            this.colMakina.Width = 64;
            // 
            // colBoyaGideri
            // 
            this.colBoyaGideri.FieldName = "BoyaGideri";
            this.colBoyaGideri.Name = "colBoyaGideri";
            this.colBoyaGideri.OptionsColumn.AllowEdit = false;
            this.colBoyaGideri.Visible = true;
            this.colBoyaGideri.VisibleIndex = 5;
            this.colBoyaGideri.Width = 64;
            // 
            // colProfil
            // 
            this.colProfil.FieldName = "Profil";
            this.colProfil.Name = "colProfil";
            this.colProfil.OptionsColumn.AllowEdit = false;
            this.colProfil.Visible = true;
            this.colProfil.VisibleIndex = 6;
            this.colProfil.Width = 64;
            // 
            // colKumasCinsiVeEni
            // 
            this.colKumasCinsiVeEni.FieldName = "KumasCinsiVeEni";
            this.colKumasCinsiVeEni.Name = "colKumasCinsiVeEni";
            this.colKumasCinsiVeEni.OptionsColumn.AllowEdit = false;
            this.colKumasCinsiVeEni.Visible = true;
            this.colKumasCinsiVeEni.VisibleIndex = 7;
            this.colKumasCinsiVeEni.Width = 64;
            // 
            // colPassSayisi
            // 
            this.colPassSayisi.FieldName = "PassSayisi";
            this.colPassSayisi.Name = "colPassSayisi";
            this.colPassSayisi.OptionsColumn.AllowEdit = false;
            this.colPassSayisi.Visible = true;
            this.colPassSayisi.VisibleIndex = 8;
            this.colPassSayisi.Width = 64;
            // 
            // colBaskiEni
            // 
            this.colBaskiEni.FieldName = "BaskiEni";
            this.colBaskiEni.Name = "colBaskiEni";
            this.colBaskiEni.OptionsColumn.AllowEdit = false;
            this.colBaskiEni.Visible = true;
            this.colBaskiEni.VisibleIndex = 9;
            this.colBaskiEni.Width = 64;
            // 
            // colKagitCinsi
            // 
            this.colKagitCinsi.FieldName = "KagitCinsi";
            this.colKagitCinsi.Name = "colKagitCinsi";
            this.colKagitCinsi.OptionsColumn.AllowEdit = false;
            this.colKagitCinsi.Visible = true;
            this.colKagitCinsi.VisibleIndex = 10;
            this.colKagitCinsi.Width = 64;
            // 
            // colEni
            // 
            this.colEni.FieldName = "Eni";
            this.colEni.Name = "colEni";
            this.colEni.OptionsColumn.AllowEdit = false;
            this.colEni.Visible = true;
            this.colEni.VisibleIndex = 11;
            this.colEni.Width = 64;
            // 
            // colTransferHizi
            // 
            this.colTransferHizi.FieldName = "TransferHizi";
            this.colTransferHizi.Name = "colTransferHizi";
            this.colTransferHizi.OptionsColumn.AllowEdit = false;
            this.colTransferHizi.Visible = true;
            this.colTransferHizi.VisibleIndex = 12;
            this.colTransferHizi.Width = 64;
            // 
            // colSiparisTarihi
            // 
            this.colSiparisTarihi.FieldName = "SiparisTarihi";
            this.colSiparisTarihi.Name = "colSiparisTarihi";
            this.colSiparisTarihi.OptionsColumn.AllowEdit = false;
            this.colSiparisTarihi.Visible = true;
            this.colSiparisTarihi.VisibleIndex = 13;
            this.colSiparisTarihi.Width = 64;
            // 
            // colTransferDerecesi
            // 
            this.colTransferDerecesi.FieldName = "TransferDerecesi";
            this.colTransferDerecesi.Name = "colTransferDerecesi";
            this.colTransferDerecesi.OptionsColumn.AllowEdit = false;
            this.colTransferDerecesi.Visible = true;
            this.colTransferDerecesi.VisibleIndex = 14;
            this.colTransferDerecesi.Width = 64;
            // 
            // colIsTipi
            // 
            this.colIsTipi.FieldName = "IsTipi";
            this.colIsTipi.Name = "colIsTipi";
            this.colIsTipi.OptionsColumn.AllowEdit = false;
            this.colIsTipi.Visible = true;
            this.colIsTipi.VisibleIndex = 15;
            this.colIsTipi.Width = 64;
            // 
            // colSiparisMiktari
            // 
            this.colSiparisMiktari.FieldName = "SiparisMiktari";
            this.colSiparisMiktari.Name = "colSiparisMiktari";
            this.colSiparisMiktari.OptionsColumn.AllowEdit = false;
            this.colSiparisMiktari.Visible = true;
            this.colSiparisMiktari.VisibleIndex = 16;
            this.colSiparisMiktari.Width = 64;
            // 
            // colPazarlamaci
            // 
            this.colPazarlamaci.FieldName = "Pazarlamaci";
            this.colPazarlamaci.Name = "colPazarlamaci";
            this.colPazarlamaci.OptionsColumn.AllowEdit = false;
            this.colPazarlamaci.Visible = true;
            this.colPazarlamaci.VisibleIndex = 17;
            this.colPazarlamaci.Width = 64;
            // 
            // colDesinator
            // 
            this.colDesinator.FieldName = "Desinator";
            this.colDesinator.Name = "colDesinator";
            this.colDesinator.OptionsColumn.AllowEdit = false;
            this.colDesinator.Visible = true;
            this.colDesinator.VisibleIndex = 18;
            this.colDesinator.Width = 68;
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnIslemler);
            this.grpMenu.Controls.Add(this.btnKapat);
            this.grpMenu.Controls.Add(this.btnAra);
            this.grpMenu.Controls.Add(this.btnGuncelle);
            this.grpMenu.Controls.Add(this.btnKopyala);
            this.grpMenu.Controls.Add(this.btnSil);
            this.grpMenu.Controls.Add(this.btnDuzenle);
            this.grpMenu.Controls.Add(this.btnEkle);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 606);
            this.grpMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(1218, 84);
            this.grpMenu.TabIndex = 8;
            this.grpMenu.Text = "Menü";
            // 
            // btnIslemler
            // 
            this.btnIslemler.ImageOptions.ImageIndex = 5;
            this.btnIslemler.ImageOptions.ImageList = this.imgMenu;
            this.btnIslemler.Location = new System.Drawing.Point(321, 32);
            this.btnIslemler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIslemler.Name = "btnIslemler";
            this.btnIslemler.Size = new System.Drawing.Size(97, 43);
            this.btnIslemler.TabIndex = 3;
            this.btnIslemler.Text = "İşlemler";
            this.btnIslemler.Click += new System.EventHandler(this.btnIslemler_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 6;
            this.btnKapat.ImageOptions.ImageList = this.imgMenu;
            this.btnKapat.Location = new System.Drawing.Point(1108, 32);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(97, 43);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnAra
            // 
            this.btnAra.ImageOptions.ImageIndex = 5;
            this.btnAra.ImageOptions.ImageList = this.imgMenu;
            this.btnAra.Location = new System.Drawing.Point(528, 32);
            this.btnAra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(97, 43);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageOptions.ImageIndex = 9;
            this.btnGuncelle.ImageOptions.ImageList = this.imgMenu;
            this.btnGuncelle.Location = new System.Drawing.Point(425, 32);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(97, 43);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKopyala
            // 
            this.btnKopyala.ImageOptions.ImageIndex = 4;
            this.btnKopyala.ImageOptions.ImageList = this.imgMenu;
            this.btnKopyala.Location = new System.Drawing.Point(631, 32);
            this.btnKopyala.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKopyala.Name = "btnKopyala";
            this.btnKopyala.Size = new System.Drawing.Size(97, 43);
            this.btnKopyala.TabIndex = 1;
            this.btnKopyala.Text = "Kopyala";
            this.btnKopyala.Visible = false;
            this.btnKopyala.Click += new System.EventHandler(this.btnKopyala_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.ImageIndex = 5;
            this.btnSil.ImageOptions.ImageList = this.imgMenu;
            this.btnSil.Location = new System.Drawing.Point(218, 32);
            this.btnSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(97, 43);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.ImageOptions.ImageIndex = 1;
            this.btnDuzenle.ImageOptions.ImageList = this.imgMenu;
            this.btnDuzenle.Location = new System.Drawing.Point(115, 32);
            this.btnDuzenle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(97, 43);
            this.btnDuzenle.TabIndex = 0;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.ImageOptions.ImageIndex = 2;
            this.btnEkle.ImageOptions.ImageList = this.imgMenu;
            this.btnEkle.Location = new System.Drawing.Point(12, 32);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(97, 43);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
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
            this.lblBaslik.Size = new System.Drawing.Size(1218, 63);
            this.lblBaslik.TabIndex = 7;
            this.lblBaslik.Text = "Formlar";
            // 
            // frmSipFormlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 690);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.lblBaslik);
            this.Name = "frmSipFormlari";
            this.Text = "Sipariş Formları";
            this.Load += new System.EventHandler(this.frmSipFormlari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContFormlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFormlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SimpleButton btnFiltreKapat;
        private DevExpress.XtraEditors.SimpleButton btnFiltreIptal;
        private DevExpress.XtraEditors.SimpleButton btnFiltre;
        private DevExpress.XtraEditors.FilterControl filterControl1;
        private DevExpress.XtraGrid.GridControl gridContFormlar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridFormlar;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnKopyala;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private System.Windows.Forms.ImageList imgMenu;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDurumu;
        private DevExpress.XtraGrid.Columns.GridColumn colMusteriAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colDesenNo;
        private DevExpress.XtraGrid.Columns.GridColumn colMakina;
        private DevExpress.XtraGrid.Columns.GridColumn colSiparisNo;
        private DevExpress.XtraGrid.Columns.GridColumn colBoyaGideri;
        private DevExpress.XtraGrid.Columns.GridColumn colProfil;
        private DevExpress.XtraGrid.Columns.GridColumn colKumasCinsiVeEni;
        private DevExpress.XtraGrid.Columns.GridColumn colPassSayisi;
        private DevExpress.XtraGrid.Columns.GridColumn colBaskiEni;
        private DevExpress.XtraGrid.Columns.GridColumn colKagitCinsi;
        private DevExpress.XtraGrid.Columns.GridColumn colEni;
        private DevExpress.XtraGrid.Columns.GridColumn colTransferHizi;
        private DevExpress.XtraGrid.Columns.GridColumn colSiparisTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colTransferDerecesi;
        private DevExpress.XtraGrid.Columns.GridColumn colIsTipi;
        private DevExpress.XtraGrid.Columns.GridColumn colSiparisMiktari;
        private DevExpress.XtraGrid.Columns.GridColumn colPazarlamaci;
        private DevExpress.XtraGrid.Columns.GridColumn colDesinator;
        private DevExpress.XtraEditors.SimpleButton btnIslemler;
    }
}