namespace StokTakip.BackOffice.Stok_Hareketleri
{
    partial class frmStokDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStokDuzenle));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.gridContStoklar = new DevExpress.XtraGrid.GridControl();
            this.gridViewStoklar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridContUrunler = new DevExpress.XtraGrid.GridControl();
            this.gridViewUrunler = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkodTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeriNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKonum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKonumKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGorsel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnGeriAl = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.colId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFisKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHareket = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokKodu1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAdi1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkodTuru1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkod1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimi1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiktar1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDovizCinsi = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContStoklar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStoklar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridContUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
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
            this.lblBaslik.Size = new System.Drawing.Size(1360, 53);
            this.lblBaslik.TabIndex = 5;
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnKaydet);
            this.grpMenu.Controls.Add(this.btnKapat);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 761);
            this.grpMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.ShowCaption = false;
            this.grpMenu.Size = new System.Drawing.Size(1360, 60);
            this.grpMenu.TabIndex = 7;
            this.grpMenu.Text = "Menü";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.ImageOptions.ImageIndex = 0;
            this.btnKaydet.ImageOptions.ImageList = this.ımageList1;
            this.btnKaydet.Location = new System.Drawing.Point(1149, 8);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(97, 43);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "folder_out.png");
            this.ımageList1.Images.SetKeyName(1, "refresh.png");
            this.ımageList1.Images.SetKeyName(2, "floppy_disk.png");
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 2;
            this.btnKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnKapat.Location = new System.Drawing.Point(1252, 8);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(97, 43);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            // 
            // gridContStoklar
            // 
            this.gridContStoklar.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gridContStoklar.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridContStoklar.Location = new System.Drawing.Point(0, 0);
            this.gridContStoklar.MainView = this.gridViewStoklar;
            this.gridContStoklar.Name = "gridContStoklar";
            this.gridContStoklar.Size = new System.Drawing.Size(613, 708);
            this.gridContStoklar.TabIndex = 0;
            this.gridContStoklar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewStoklar});
            // 
            // gridViewStoklar
            // 
            this.gridViewStoklar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId1,
            this.colFisKodu,
            this.colHareket,
            this.colStokKodu1,
            this.colStokAdi1,
            this.colBarkodTuru1,
            this.colBarkod1,
            this.colBirimi1,
            this.colMiktar1,
            this.colDovizCinsi});
            this.gridViewStoklar.GridControl = this.gridContStoklar;
            this.gridViewStoklar.Name = "gridViewStoklar";
            this.gridViewStoklar.OptionsView.ShowGroupPanel = false;
            // 
            // gridContUrunler
            // 
            this.gridContUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode2.RelationName = "Level1";
            this.gridContUrunler.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.gridContUrunler.Location = new System.Drawing.Point(0, 0);
            this.gridContUrunler.MainView = this.gridViewUrunler;
            this.gridContUrunler.Name = "gridContUrunler";
            this.gridContUrunler.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageEdit1});
            this.gridContUrunler.Size = new System.Drawing.Size(580, 708);
            this.gridContUrunler.TabIndex = 0;
            this.gridContUrunler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewUrunler});
            // 
            // gridViewUrunler
            // 
            this.gridViewUrunler.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colStokKodu,
            this.colStokAdi,
            this.colBarkodTuru,
            this.colBarkod,
            this.colBirimi,
            this.colMiktar,
            this.colSeriNo,
            this.colKonum,
            this.colKonumKodu,
            this.colGorsel});
            this.gridViewUrunler.GridControl = this.gridContUrunler;
            this.gridViewUrunler.Name = "gridViewUrunler";
            this.gridViewUrunler.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ReadOnly = true;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colStokKodu
            // 
            this.colStokKodu.FieldName = "StokKodu";
            this.colStokKodu.Name = "colStokKodu";
            this.colStokKodu.OptionsColumn.AllowEdit = false;
            this.colStokKodu.OptionsColumn.ReadOnly = true;
            // 
            // colStokAdi
            // 
            this.colStokAdi.FieldName = "StokAdi";
            this.colStokAdi.Name = "colStokAdi";
            this.colStokAdi.OptionsColumn.AllowEdit = false;
            this.colStokAdi.OptionsColumn.ReadOnly = true;
            this.colStokAdi.Visible = true;
            this.colStokAdi.VisibleIndex = 1;
            this.colStokAdi.Width = 135;
            // 
            // colBarkodTuru
            // 
            this.colBarkodTuru.FieldName = "BarkodTuru";
            this.colBarkodTuru.Name = "colBarkodTuru";
            this.colBarkodTuru.OptionsColumn.AllowEdit = false;
            this.colBarkodTuru.OptionsColumn.ReadOnly = true;
            // 
            // colBarkod
            // 
            this.colBarkod.FieldName = "Barkod";
            this.colBarkod.Name = "colBarkod";
            this.colBarkod.OptionsColumn.AllowEdit = false;
            this.colBarkod.OptionsColumn.ReadOnly = true;
            // 
            // colBirimi
            // 
            this.colBirimi.FieldName = "Birimi";
            this.colBirimi.Name = "colBirimi";
            this.colBirimi.OptionsColumn.AllowEdit = false;
            this.colBirimi.OptionsColumn.ReadOnly = true;
            this.colBirimi.Visible = true;
            this.colBirimi.VisibleIndex = 3;
            this.colBirimi.Width = 65;
            // 
            // colMiktar
            // 
            this.colMiktar.FieldName = "Miktar";
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.OptionsColumn.AllowEdit = false;
            this.colMiktar.OptionsColumn.ReadOnly = true;
            this.colMiktar.Visible = true;
            this.colMiktar.VisibleIndex = 4;
            this.colMiktar.Width = 72;
            // 
            // colSeriNo
            // 
            this.colSeriNo.FieldName = "SeriNo";
            this.colSeriNo.Name = "colSeriNo";
            this.colSeriNo.OptionsColumn.AllowEdit = false;
            this.colSeriNo.OptionsColumn.ReadOnly = true;
            this.colSeriNo.Visible = true;
            this.colSeriNo.VisibleIndex = 2;
            this.colSeriNo.Width = 224;
            // 
            // colKonum
            // 
            this.colKonum.FieldName = "Konum";
            this.colKonum.Name = "colKonum";
            this.colKonum.OptionsColumn.AllowEdit = false;
            this.colKonum.OptionsColumn.ReadOnly = true;
            // 
            // colKonumKodu
            // 
            this.colKonumKodu.FieldName = "KonumKodu";
            this.colKonumKodu.Name = "colKonumKodu";
            this.colKonumKodu.OptionsColumn.AllowEdit = false;
            this.colKonumKodu.OptionsColumn.ReadOnly = true;
            // 
            // colGorsel
            // 
            this.colGorsel.Caption = "Fotoğraf";
            this.colGorsel.ColumnEdit = this.repositoryItemImageEdit1;
            this.colGorsel.FieldName = "Gorsel";
            this.colGorsel.Name = "colGorsel";
            this.colGorsel.Visible = true;
            this.colGorsel.VisibleIndex = 0;
            this.colGorsel.Width = 64;
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(14, 275);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(140, 44);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle >>";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(14, 331);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(140, 44);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "<< Çıkart";
            // 
            // btnGeriAl
            // 
            this.btnGeriAl.Location = new System.Drawing.Point(14, 387);
            this.btnGeriAl.Name = "btnGeriAl";
            this.btnGeriAl.Size = new System.Drawing.Size(140, 44);
            this.btnGeriAl.TabIndex = 5;
            this.btnGeriAl.Text = "Geri Al";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 53);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.splitterControl1);
            this.splitContainerControl1.Panel1.Controls.Add(this.gridContStoklar);
            this.splitContainerControl1.Panel1.Controls.Add(this.panelControl3);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridContUrunler);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1360, 708);
            this.splitContainerControl1.SplitterPosition = 774;
            this.splitContainerControl1.TabIndex = 12;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // splitterControl1
            // 
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitterControl1.Location = new System.Drawing.Point(607, 0);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(6, 708);
            this.splitterControl1.TabIndex = 1;
            this.splitterControl1.TabStop = false;
            // 
            // panelControl3
            // 
            this.panelControl3.AutoSize = true;
            this.panelControl3.Controls.Add(this.simpleButton1);
            this.panelControl3.Controls.Add(this.btnGeriAl);
            this.panelControl3.Controls.Add(this.btnEkle);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl3.Location = new System.Drawing.Point(613, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(161, 708);
            this.panelControl3.TabIndex = 0;
            // 
            // colId1
            // 
            this.colId1.FieldName = "Id";
            this.colId1.Name = "colId1";
            this.colId1.Visible = true;
            this.colId1.VisibleIndex = 0;
            // 
            // colFisKodu
            // 
            this.colFisKodu.FieldName = "FisKodu";
            this.colFisKodu.Name = "colFisKodu";
            this.colFisKodu.Visible = true;
            this.colFisKodu.VisibleIndex = 1;
            // 
            // colHareket
            // 
            this.colHareket.FieldName = "Hareket";
            this.colHareket.Name = "colHareket";
            this.colHareket.Visible = true;
            this.colHareket.VisibleIndex = 2;
            // 
            // colStokKodu1
            // 
            this.colStokKodu1.FieldName = "StokKodu";
            this.colStokKodu1.Name = "colStokKodu1";
            this.colStokKodu1.Visible = true;
            this.colStokKodu1.VisibleIndex = 3;
            // 
            // colStokAdi1
            // 
            this.colStokAdi1.FieldName = "StokAdi";
            this.colStokAdi1.Name = "colStokAdi1";
            this.colStokAdi1.Visible = true;
            this.colStokAdi1.VisibleIndex = 4;
            // 
            // colBarkodTuru1
            // 
            this.colBarkodTuru1.FieldName = "BarkodTuru";
            this.colBarkodTuru1.Name = "colBarkodTuru1";
            this.colBarkodTuru1.Visible = true;
            this.colBarkodTuru1.VisibleIndex = 5;
            // 
            // colBarkod1
            // 
            this.colBarkod1.FieldName = "Barkod";
            this.colBarkod1.Name = "colBarkod1";
            this.colBarkod1.Visible = true;
            this.colBarkod1.VisibleIndex = 6;
            // 
            // colBirimi1
            // 
            this.colBirimi1.FieldName = "Birimi";
            this.colBirimi1.Name = "colBirimi1";
            this.colBirimi1.Visible = true;
            this.colBirimi1.VisibleIndex = 7;
            // 
            // colMiktar1
            // 
            this.colMiktar1.FieldName = "Miktar";
            this.colMiktar1.Name = "colMiktar1";
            this.colMiktar1.Visible = true;
            this.colMiktar1.VisibleIndex = 8;
            // 
            // colDovizCinsi
            // 
            this.colDovizCinsi.FieldName = "DovizCinsi";
            this.colDovizCinsi.Name = "colDovizCinsi";
            this.colDovizCinsi.Visible = true;
            this.colDovizCinsi.VisibleIndex = 9;
            // 
            // frmStokDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 821);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.lblBaslik);
            this.Name = "frmStokDuzenle";
            this.Text = "Konum Düzenle";
            this.Load += new System.EventHandler(this.frmStokDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContStoklar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStoklar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridContUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraGrid.GridControl gridContStoklar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewStoklar;
        private DevExpress.XtraGrid.GridControl gridContUrunler;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUrunler;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnGeriAl;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colStokKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkodTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimi;
        private DevExpress.XtraGrid.Columns.GridColumn colMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn colSeriNo;
        private DevExpress.XtraGrid.Columns.GridColumn colKonum;
        private DevExpress.XtraGrid.Columns.GridColumn colKonumKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colGorsel;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colId1;
        private DevExpress.XtraGrid.Columns.GridColumn colFisKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colHareket;
        private DevExpress.XtraGrid.Columns.GridColumn colStokKodu1;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAdi1;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkodTuru1;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkod1;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimi1;
        private DevExpress.XtraGrid.Columns.GridColumn colMiktar1;
        private DevExpress.XtraGrid.Columns.GridColumn colDovizCinsi;
    }
}