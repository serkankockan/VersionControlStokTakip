namespace StokTakip.BackOffice.Cari
{
    partial class frmCariHareket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCariHareket));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridContStokHareket = new DevExpress.XtraGrid.GridControl();
            this.gridStokHareket = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridContDepoStok = new DevExpress.XtraGrid.GridControl();
            this.gridDepoStok = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDepolarDepoKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepolarDepoAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepolarStokGiris = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepolarStokCikis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepolarMevcutStok = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridContGenelStok = new DevExpress.XtraGrid.GridControl();
            this.gridGenelStok = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGenelBilgi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGenelKayitSayisi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGenelToplam = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContStokHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStokHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContDepoStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDepoStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContGenelStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGenelStok)).BeginInit();
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
            this.lblBaslik.Size = new System.Drawing.Size(1067, 55);
            this.lblBaslik.TabIndex = 2;
            this.lblBaslik.Text = "Cari Hareketleri";
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnKapat);
            this.grpMenu.Controls.Add(this.btnAra);
            this.grpMenu.Controls.Add(this.btnGuncelle);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 636);
            this.grpMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(1067, 84);
            this.grpMenu.TabIndex = 3;
            this.grpMenu.Text = "Menü";
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 0;
            this.btnKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnKapat.Location = new System.Drawing.Point(958, 32);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(97, 43);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
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
            this.btnAra.Location = new System.Drawing.Point(108, 32);
            this.btnAra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(97, 43);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuncelle.ImageOptions.ImageIndex = 1;
            this.btnGuncelle.ImageOptions.ImageList = this.ımageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(5, 32);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(97, 43);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Güncelle";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 55);
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridContStokHareket);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1067, 581);
            this.splitContainerControl1.SplitterPosition = 349;
            this.splitContainerControl1.TabIndex = 4;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gridContStokHareket
            // 
            this.gridContStokHareket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContStokHareket.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridContStokHareket.Location = new System.Drawing.Point(0, 0);
            this.gridContStokHareket.MainView = this.gridStokHareket;
            this.gridContStokHareket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridContStokHareket.Name = "gridContStokHareket";
            this.gridContStokHareket.Size = new System.Drawing.Size(1067, 349);
            this.gridContStokHareket.TabIndex = 1;
            this.gridContStokHareket.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridStokHareket});
            // 
            // gridStokHareket
            // 
            this.gridStokHareket.GridControl = this.gridContStokHareket;
            this.gridStokHareket.Name = "gridStokHareket";
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
            this.splitContainerControl2.Size = new System.Drawing.Size(1067, 226);
            this.splitContainerControl2.SplitterPosition = 567;
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
            this.groupControl1.Size = new System.Drawing.Size(567, 226);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Fiş Türüne Göre Toplamlar";
            // 
            // gridContDepoStok
            // 
            this.gridContDepoStok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContDepoStok.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridContDepoStok.Location = new System.Drawing.Point(2, 25);
            this.gridContDepoStok.MainView = this.gridDepoStok;
            this.gridContDepoStok.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridContDepoStok.Name = "gridContDepoStok";
            this.gridContDepoStok.Size = new System.Drawing.Size(563, 199);
            this.gridContDepoStok.TabIndex = 2;
            this.gridContDepoStok.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridDepoStok});
            // 
            // gridDepoStok
            // 
            this.gridDepoStok.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDepolarDepoKodu,
            this.colDepolarDepoAdi,
            this.colDepolarStokGiris,
            this.colDepolarStokCikis,
            this.colDepolarMevcutStok});
            this.gridDepoStok.GridControl = this.gridContDepoStok;
            this.gridDepoStok.Name = "gridDepoStok";
            this.gridDepoStok.OptionsView.ShowGroupPanel = false;
            // 
            // colDepolarDepoKodu
            // 
            this.colDepolarDepoKodu.Caption = "Depo Kodu";
            this.colDepolarDepoKodu.FieldName = "DepoKodu";
            this.colDepolarDepoKodu.Name = "colDepolarDepoKodu";
            this.colDepolarDepoKodu.OptionsColumn.AllowEdit = false;
            this.colDepolarDepoKodu.Visible = true;
            this.colDepolarDepoKodu.VisibleIndex = 0;
            this.colDepolarDepoKodu.Width = 82;
            // 
            // colDepolarDepoAdi
            // 
            this.colDepolarDepoAdi.Caption = "Depo Adı";
            this.colDepolarDepoAdi.FieldName = "DepoAdi";
            this.colDepolarDepoAdi.Name = "colDepolarDepoAdi";
            this.colDepolarDepoAdi.OptionsColumn.AllowEdit = false;
            this.colDepolarDepoAdi.Visible = true;
            this.colDepolarDepoAdi.VisibleIndex = 1;
            this.colDepolarDepoAdi.Width = 149;
            // 
            // colDepolarStokGiris
            // 
            this.colDepolarStokGiris.Caption = "Stok Giriş";
            this.colDepolarStokGiris.FieldName = "StokGiris";
            this.colDepolarStokGiris.Name = "colDepolarStokGiris";
            this.colDepolarStokGiris.OptionsColumn.AllowEdit = false;
            this.colDepolarStokGiris.Visible = true;
            this.colDepolarStokGiris.VisibleIndex = 2;
            this.colDepolarStokGiris.Width = 81;
            // 
            // colDepolarStokCikis
            // 
            this.colDepolarStokCikis.Caption = "Stok Çıkış";
            this.colDepolarStokCikis.FieldName = "StokCikis";
            this.colDepolarStokCikis.Name = "colDepolarStokCikis";
            this.colDepolarStokCikis.OptionsColumn.AllowEdit = false;
            this.colDepolarStokCikis.Visible = true;
            this.colDepolarStokCikis.VisibleIndex = 3;
            this.colDepolarStokCikis.Width = 85;
            // 
            // colDepolarMevcutStok
            // 
            this.colDepolarMevcutStok.Caption = "Mevcut Stok";
            this.colDepolarMevcutStok.FieldName = "MevcutStok";
            this.colDepolarMevcutStok.Name = "colDepolarMevcutStok";
            this.colDepolarMevcutStok.OptionsColumn.AllowEdit = false;
            this.colDepolarMevcutStok.Visible = true;
            this.colDepolarMevcutStok.VisibleIndex = 4;
            this.colDepolarMevcutStok.Width = 71;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridContGenelStok);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(494, 226);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Cari Ekstresi";
            // 
            // gridContGenelStok
            // 
            this.gridContGenelStok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContGenelStok.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridContGenelStok.Location = new System.Drawing.Point(2, 25);
            this.gridContGenelStok.MainView = this.gridGenelStok;
            this.gridContGenelStok.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridContGenelStok.Name = "gridContGenelStok";
            this.gridContGenelStok.Size = new System.Drawing.Size(490, 199);
            this.gridContGenelStok.TabIndex = 2;
            this.gridContGenelStok.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridGenelStok});
            // 
            // gridGenelStok
            // 
            this.gridGenelStok.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGenelBilgi,
            this.colGenelKayitSayisi,
            this.colGenelToplam});
            this.gridGenelStok.GridControl = this.gridContGenelStok;
            this.gridGenelStok.Name = "gridGenelStok";
            this.gridGenelStok.OptionsView.ShowGroupPanel = false;
            // 
            // colGenelBilgi
            // 
            this.colGenelBilgi.Caption = "Bilgi";
            this.colGenelBilgi.FieldName = "Bilgi";
            this.colGenelBilgi.Name = "colGenelBilgi";
            this.colGenelBilgi.OptionsColumn.AllowEdit = false;
            this.colGenelBilgi.Visible = true;
            this.colGenelBilgi.VisibleIndex = 0;
            this.colGenelBilgi.Width = 258;
            // 
            // colGenelKayitSayisi
            // 
            this.colGenelKayitSayisi.Caption = "Kayıt Sayısı";
            this.colGenelKayitSayisi.FieldName = "KayitSayisi";
            this.colGenelKayitSayisi.Name = "colGenelKayitSayisi";
            this.colGenelKayitSayisi.OptionsColumn.AllowEdit = false;
            this.colGenelKayitSayisi.Visible = true;
            this.colGenelKayitSayisi.VisibleIndex = 1;
            this.colGenelKayitSayisi.Width = 135;
            // 
            // colGenelToplam
            // 
            this.colGenelToplam.Caption = "Toplam";
            this.colGenelToplam.FieldName = "Toplam";
            this.colGenelToplam.Name = "colGenelToplam";
            this.colGenelToplam.OptionsColumn.AllowEdit = false;
            this.colGenelToplam.Visible = true;
            this.colGenelToplam.VisibleIndex = 2;
            this.colGenelToplam.Width = 71;
            // 
            // frmCariHareket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 720);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.lblBaslik);
            this.Name = "frmCariHareket";
            this.Text = "frmCariHareket";
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContStokHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStokHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContDepoStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDepoStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContGenelStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGenelStok)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridContStokHareket;
        private DevExpress.XtraGrid.Views.Grid.GridView gridStokHareket;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridContDepoStok;
        private DevExpress.XtraGrid.Views.Grid.GridView gridDepoStok;
        private DevExpress.XtraGrid.Columns.GridColumn colDepolarDepoKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colDepolarDepoAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colDepolarStokGiris;
        private DevExpress.XtraGrid.Columns.GridColumn colDepolarStokCikis;
        private DevExpress.XtraGrid.Columns.GridColumn colDepolarMevcutStok;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridContGenelStok;
        private DevExpress.XtraGrid.Views.Grid.GridView gridGenelStok;
        private DevExpress.XtraGrid.Columns.GridColumn colGenelBilgi;
        private DevExpress.XtraGrid.Columns.GridColumn colGenelKayitSayisi;
        private DevExpress.XtraGrid.Columns.GridColumn colGenelToplam;
    }
}