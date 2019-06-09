namespace StokTakip.BackOffice.Depo
{
    partial class frmDepoSec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepoSec));
            this.gridContDepolar = new DevExpress.XtraGrid.GridControl();
            this.gridDepolar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnSec = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.depoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepoKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepoAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYetkiliKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYetkiliAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIlce = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSemt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokGiris = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokCikis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMevcutStok = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridContDepolar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDepolar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridContDepolar
            // 
            this.gridContDepolar.DataSource = this.depoBindingSource;
            this.gridContDepolar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContDepolar.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridContDepolar.Location = new System.Drawing.Point(0, 45);
            this.gridContDepolar.MainView = this.gridDepolar;
            this.gridContDepolar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridContDepolar.Name = "gridContDepolar";
            this.gridContDepolar.Size = new System.Drawing.Size(1047, 527);
            this.gridContDepolar.TabIndex = 9;
            this.gridContDepolar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridDepolar});
            // 
            // gridDepolar
            // 
            this.gridDepolar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colDepoKodu,
            this.colDepoAdi,
            this.colYetkiliKodu,
            this.colYetkiliAdi,
            this.colIl,
            this.colIlce,
            this.colSemt,
            this.colAdres,
            this.colTelefon,
            this.colAciklama,
            this.colStokGiris,
            this.colStokCikis,
            this.colMevcutStok});
            this.gridDepolar.GridControl = this.gridContDepolar;
            this.gridDepolar.Name = "gridDepolar";
            this.gridDepolar.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnSec);
            this.grpMenu.Controls.Add(this.btnKapat);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 572);
            this.grpMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(1047, 68);
            this.grpMenu.TabIndex = 8;
            this.grpMenu.Text = "Menü";
            // 
            // btnSec
            // 
            this.btnSec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSec.ImageOptions.Image")));
            this.btnSec.ImageOptions.ImageIndex = 0;
            this.btnSec.Location = new System.Drawing.Point(865, 26);
            this.btnSec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(83, 35);
            this.btnSec.TabIndex = 2;
            this.btnSec.Text = "Seç";
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
            this.btnKapat.ImageOptions.ImageIndex = 1;
            this.btnKapat.Location = new System.Drawing.Point(954, 26);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(83, 35);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
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
            this.lblBaslik.Size = new System.Drawing.Size(1047, 45);
            this.lblBaslik.TabIndex = 7;
            this.lblBaslik.Text = "Depo Seçim Ekranı";
            // 
            // depoBindingSource
            // 
            this.depoBindingSource.DataSource = typeof(StokTakip.Entities.Tables.Depo);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            // 
            // colDepoKodu
            // 
            this.colDepoKodu.Caption = "Depo Kodu";
            this.colDepoKodu.FieldName = "DepoKodu";
            this.colDepoKodu.Name = "colDepoKodu";
            this.colDepoKodu.OptionsColumn.AllowEdit = false;
            this.colDepoKodu.Visible = true;
            this.colDepoKodu.VisibleIndex = 0;
            this.colDepoKodu.Width = 69;
            // 
            // colDepoAdi
            // 
            this.colDepoAdi.Caption = "Depo Adı";
            this.colDepoAdi.FieldName = "DepoAdi";
            this.colDepoAdi.Name = "colDepoAdi";
            this.colDepoAdi.OptionsColumn.AllowEdit = false;
            this.colDepoAdi.Visible = true;
            this.colDepoAdi.VisibleIndex = 1;
            this.colDepoAdi.Width = 104;
            // 
            // colYetkiliKodu
            // 
            this.colYetkiliKodu.Caption = "Yetkili Kodu";
            this.colYetkiliKodu.FieldName = "YetkiliKodu";
            this.colYetkiliKodu.Name = "colYetkiliKodu";
            this.colYetkiliKodu.OptionsColumn.AllowEdit = false;
            this.colYetkiliKodu.Visible = true;
            this.colYetkiliKodu.VisibleIndex = 2;
            this.colYetkiliKodu.Width = 37;
            // 
            // colYetkiliAdi
            // 
            this.colYetkiliAdi.Caption = "Yetkili Adı";
            this.colYetkiliAdi.FieldName = "YetkiliAdi";
            this.colYetkiliAdi.Name = "colYetkiliAdi";
            this.colYetkiliAdi.OptionsColumn.AllowEdit = false;
            this.colYetkiliAdi.Visible = true;
            this.colYetkiliAdi.VisibleIndex = 3;
            this.colYetkiliAdi.Width = 105;
            // 
            // colIl
            // 
            this.colIl.Caption = "İl";
            this.colIl.FieldName = "Il";
            this.colIl.Name = "colIl";
            this.colIl.OptionsColumn.AllowEdit = false;
            this.colIl.Visible = true;
            this.colIl.VisibleIndex = 5;
            this.colIl.Width = 63;
            // 
            // colIlce
            // 
            this.colIlce.Caption = "İlçe";
            this.colIlce.FieldName = "Ilce";
            this.colIlce.Name = "colIlce";
            this.colIlce.OptionsColumn.AllowEdit = false;
            this.colIlce.Visible = true;
            this.colIlce.VisibleIndex = 6;
            this.colIlce.Width = 49;
            // 
            // colSemt
            // 
            this.colSemt.Caption = "Semt";
            this.colSemt.FieldName = "Semt";
            this.colSemt.Name = "colSemt";
            this.colSemt.OptionsColumn.AllowEdit = false;
            this.colSemt.Visible = true;
            this.colSemt.VisibleIndex = 7;
            this.colSemt.Width = 65;
            // 
            // colAdres
            // 
            this.colAdres.Caption = "Adres";
            this.colAdres.FieldName = "Adres";
            this.colAdres.Name = "colAdres";
            this.colAdres.OptionsColumn.AllowEdit = false;
            this.colAdres.Visible = true;
            this.colAdres.VisibleIndex = 8;
            this.colAdres.Width = 140;
            // 
            // colTelefon
            // 
            this.colTelefon.Caption = "Telefon";
            this.colTelefon.FieldName = "Telefon";
            this.colTelefon.Name = "colTelefon";
            this.colTelefon.OptionsColumn.AllowEdit = false;
            this.colTelefon.Visible = true;
            this.colTelefon.VisibleIndex = 4;
            this.colTelefon.Width = 73;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 9;
            this.colAciklama.Width = 112;
            // 
            // colStokGiris
            // 
            this.colStokGiris.Caption = "Stok Giriş";
            this.colStokGiris.FieldName = "StokGiris";
            this.colStokGiris.Name = "colStokGiris";
            this.colStokGiris.Visible = true;
            this.colStokGiris.VisibleIndex = 10;
            this.colStokGiris.Width = 57;
            // 
            // colStokCikis
            // 
            this.colStokCikis.Caption = "Stok Çıkış";
            this.colStokCikis.FieldName = "StokCikis";
            this.colStokCikis.Name = "colStokCikis";
            this.colStokCikis.Visible = true;
            this.colStokCikis.VisibleIndex = 11;
            this.colStokCikis.Width = 57;
            // 
            // colMevcutStok
            // 
            this.colMevcutStok.Caption = "Mevcut Stok";
            this.colMevcutStok.FieldName = "MevcutStok";
            this.colMevcutStok.Name = "colMevcutStok";
            this.colMevcutStok.Visible = true;
            this.colMevcutStok.VisibleIndex = 12;
            this.colMevcutStok.Width = 98;
            // 
            // frmDepoSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 640);
            this.Controls.Add(this.gridContDepolar);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDepoSec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depo Seçim Ekranı";
            this.Load += new System.EventHandler(this.frmDepoSec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridContDepolar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDepolar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.depoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridContDepolar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridDepolar;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.SimpleButton btnSec;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private System.Windows.Forms.BindingSource depoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDepoKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colDepoAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colYetkiliKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colYetkiliAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colIl;
        private DevExpress.XtraGrid.Columns.GridColumn colIlce;
        private DevExpress.XtraGrid.Columns.GridColumn colSemt;
        private DevExpress.XtraGrid.Columns.GridColumn colAdres;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefon;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colStokGiris;
        private DevExpress.XtraGrid.Columns.GridColumn colStokCikis;
        private DevExpress.XtraGrid.Columns.GridColumn colMevcutStok;
    }
}