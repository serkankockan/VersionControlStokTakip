namespace StokTakip.BackOffice.Döviz_Kurları
{
    partial class frmDovizKurlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDovizKurlari));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnGüncelle = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIsim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSembol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colForexBuying = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colForexSelling = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBanknoteBuying = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBanknoteSelling = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSira = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblUyari = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaslik.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBaslik.Appearance.ImageIndex = 2;
            this.lblBaslik.Appearance.ImageList = this.ımageList1;
            this.lblBaslik.Appearance.Options.UseFont = true;
            this.lblBaslik.Appearance.Options.UseImageAlign = true;
            this.lblBaslik.Appearance.Options.UseImageIndex = true;
            this.lblBaslik.Appearance.Options.UseImageList = true;
            this.lblBaslik.Appearance.Options.UseTextOptions = true;
            this.lblBaslik.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblBaslik.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBaslik.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Margin = new System.Windows.Forms.Padding(2);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(850, 43);
            this.lblBaslik.TabIndex = 3;
            this.lblBaslik.Text = "Döviz Kurları";
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.lblUyari);
            this.grpMenu.Controls.Add(this.btnKapat);
            this.grpMenu.Controls.Add(this.btnGüncelle);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 520);
            this.grpMenu.Margin = new System.Windows.Forms.Padding(2);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(850, 68);
            this.grpMenu.TabIndex = 7;
            this.grpMenu.Text = "Menü";
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 1;
            this.btnKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnKapat.Location = new System.Drawing.Point(774, 26);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(2);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(73, 35);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "floppy_disk.png");
            this.ımageList1.Images.SetKeyName(1, "folder_out.png");
            this.ımageList1.Images.SetKeyName(2, "tcmb_logo.png");
            this.ımageList1.Images.SetKeyName(3, "refresh.png");
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGüncelle.ImageOptions.ImageIndex = 3;
            this.btnGüncelle.ImageOptions.ImageList = this.ımageList1;
            this.btnGüncelle.Location = new System.Drawing.Point(682, 26);
            this.btnGüncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(88, 35);
            this.btnGüncelle.TabIndex = 2;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 43);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(850, 477);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSira,
            this.colIsim,
            this.colSembol,
            this.colForexBuying,
            this.colForexSelling,
            this.colBanknoteBuying,
            this.colBanknoteSelling});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIsim
            // 
            this.colIsim.Caption = "İsim";
            this.colIsim.FieldName = "Isim";
            this.colIsim.Name = "colIsim";
            this.colIsim.Visible = true;
            this.colIsim.VisibleIndex = 0;
            this.colIsim.Width = 161;
            // 
            // colSembol
            // 
            this.colSembol.Caption = "Sembol";
            this.colSembol.FieldName = "Sembol";
            this.colSembol.Name = "colSembol";
            this.colSembol.Visible = true;
            this.colSembol.VisibleIndex = 1;
            this.colSembol.Width = 69;
            // 
            // colForexBuying
            // 
            this.colForexBuying.Caption = "Forex Alış";
            this.colForexBuying.FieldName = "ForexBuying";
            this.colForexBuying.Name = "colForexBuying";
            this.colForexBuying.Visible = true;
            this.colForexBuying.VisibleIndex = 2;
            this.colForexBuying.Width = 148;
            // 
            // colForexSelling
            // 
            this.colForexSelling.Caption = "Forex Satış";
            this.colForexSelling.FieldName = "ForexSelling";
            this.colForexSelling.Name = "colForexSelling";
            this.colForexSelling.Visible = true;
            this.colForexSelling.VisibleIndex = 3;
            this.colForexSelling.Width = 148;
            // 
            // colBanknoteBuying
            // 
            this.colBanknoteBuying.Caption = "Banknot Alış";
            this.colBanknoteBuying.FieldName = "BanknoteBuying";
            this.colBanknoteBuying.Name = "colBanknoteBuying";
            this.colBanknoteBuying.Visible = true;
            this.colBanknoteBuying.VisibleIndex = 4;
            this.colBanknoteBuying.Width = 148;
            // 
            // colBanknoteSelling
            // 
            this.colBanknoteSelling.Caption = "Banknote Satış";
            this.colBanknoteSelling.FieldName = "BanknoteSelling";
            this.colBanknoteSelling.Name = "colBanknoteSelling";
            this.colBanknoteSelling.Visible = true;
            this.colBanknoteSelling.VisibleIndex = 5;
            this.colBanknoteSelling.Width = 158;
            // 
            // colSira
            // 
            this.colSira.Caption = "Sıra";
            this.colSira.FieldName = "Sira";
            this.colSira.Name = "colSira";
            // 
            // lblUyari
            // 
            this.lblUyari.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblUyari.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("lblUyari.Appearance.Image")));
            this.lblUyari.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUyari.Appearance.Options.UseFont = true;
            this.lblUyari.Appearance.Options.UseImage = true;
            this.lblUyari.Appearance.Options.UseImageAlign = true;
            this.lblUyari.Appearance.Options.UseTextOptions = true;
            this.lblUyari.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblUyari.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblUyari.Location = new System.Drawing.Point(5, 25);
            this.lblUyari.Name = "lblUyari";
            this.lblUyari.Size = new System.Drawing.Size(386, 37);
            this.lblUyari.TabIndex = 4;
            this.lblUyari.Text = " ";
            // 
            // frmDovizKurlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 588);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDovizKurlari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "T.C. Merkez Bankası Döviz Kurları";
            this.Load += new System.EventHandler(this.frmDovizKurlari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.SimpleButton btnGüncelle;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIsim;
        private DevExpress.XtraGrid.Columns.GridColumn colSembol;
        private DevExpress.XtraGrid.Columns.GridColumn colForexBuying;
        private DevExpress.XtraGrid.Columns.GridColumn colForexSelling;
        private DevExpress.XtraGrid.Columns.GridColumn colBanknoteBuying;
        private DevExpress.XtraGrid.Columns.GridColumn colBanknoteSelling;
        private DevExpress.XtraGrid.Columns.GridColumn colSira;
        private DevExpress.XtraEditors.LabelControl lblUyari;
    }
}