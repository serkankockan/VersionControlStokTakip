namespace StokTakip.BackOffice.Konumlar
{
    partial class frmKonumDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKonumDuzenle));
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnKonumEkle = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.PanelKat = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelKat)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnKonumEkle);
            this.grpMenu.Controls.Add(this.btnDuzenle);
            this.grpMenu.Controls.Add(this.btnEkle);
            this.grpMenu.Controls.Add(this.btnKapat);
            this.grpMenu.Controls.Add(this.btnKaydet);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 579);
            this.grpMenu.Margin = new System.Windows.Forms.Padding(2);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.ShowCaption = false;
            this.grpMenu.Size = new System.Drawing.Size(1278, 60);
            this.grpMenu.TabIndex = 7;
            this.grpMenu.Text = "Menü";
            // 
            // btnKonumEkle
            // 
            this.btnKonumEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnKonumEkle.ImageOptions.ImageIndex = 4;
            this.btnKonumEkle.ImageOptions.ImageList = this.ımageList1;
            this.btnKonumEkle.Location = new System.Drawing.Point(284, 8);
            this.btnKonumEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnKonumEkle.Name = "btnKonumEkle";
            this.btnKonumEkle.Size = new System.Drawing.Size(125, 43);
            this.btnKonumEkle.TabIndex = 3;
            this.btnKonumEkle.Text = "Konum Ekle";
            this.btnKonumEkle.Click += new System.EventHandler(this.btnKonumEkle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "floppy_disk.png");
            this.ımageList1.Images.SetKeyName(1, "folder_out.png");
            this.ımageList1.Images.SetKeyName(2, "note_add.png");
            this.ımageList1.Images.SetKeyName(3, "note_edit.png");
            this.ımageList1.Images.SetKeyName(4, "add-location-10-614632.png");
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDuzenle.ImageOptions.ImageIndex = 3;
            this.btnDuzenle.ImageOptions.ImageList = this.ımageList1;
            this.btnDuzenle.Location = new System.Drawing.Point(155, 8);
            this.btnDuzenle.Margin = new System.Windows.Forms.Padding(2);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(125, 43);
            this.btnDuzenle.TabIndex = 3;
            this.btnDuzenle.Text = "Araç Düzenle";
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEkle.ImageOptions.ImageIndex = 2;
            this.btnEkle.ImageOptions.ImageList = this.ımageList1;
            this.btnEkle.Location = new System.Drawing.Point(11, 8);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(140, 43);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Yeni Araç Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkleDuzenle_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 1;
            this.btnKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnKapat.Location = new System.Drawing.Point(1190, 8);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(2);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(85, 43);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.ImageOptions.ImageIndex = 0;
            this.btnKaydet.ImageOptions.ImageList = this.ımageList1;
            this.btnKaydet.Location = new System.Drawing.Point(1082, 8);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(103, 43);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "checkbox.png");
            this.ımageList2.Images.SetKeyName(1, "delete.png");
            // 
            // PanelKat
            // 
            this.PanelKat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelKat.Location = new System.Drawing.Point(0, 0);
            this.PanelKat.Name = "PanelKat";
            this.PanelKat.Size = new System.Drawing.Size(1278, 579);
            this.PanelKat.TabIndex = 9;
            // 
            // frmKonumDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 639);
            this.Controls.Add(this.PanelKat);
            this.Controls.Add(this.grpMenu);
            this.Name = "frmKonumDuzenle";
            this.Text = "Konum Düzenle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmKonumDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelKat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ImageList ımageList2;
        private DevExpress.XtraEditors.PanelControl PanelKat;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnKonumEkle;
    }
}