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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.grpAraclar = new DevExpress.XtraEditors.GroupControl();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelKat = new DevExpress.XtraEditors.PanelControl();
            this.lblY = new DevExpress.XtraEditors.LabelControl();
            this.lblX = new DevExpress.XtraEditors.LabelControl();
            this.btnKonumEkle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpAraclar)).BeginInit();
            this.grpAraclar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelKat)).BeginInit();
            this.PanelKat.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.simpleButton1);
            this.grpMenu.Controls.Add(this.btnKonumEkle);
            this.grpMenu.Controls.Add(this.btnDuzenle);
            this.grpMenu.Controls.Add(this.btnEkle);
            this.grpMenu.Controls.Add(this.btnKapat);
            this.grpMenu.Controls.Add(this.btnKaydet);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 826);
            this.grpMenu.Margin = new System.Windows.Forms.Padding(2);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.ShowCaption = false;
            this.grpMenu.Size = new System.Drawing.Size(1303, 60);
            this.grpMenu.TabIndex = 7;
            this.grpMenu.Text = "Menü";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(1027, 18);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            // btnEkle
            // 
            this.btnEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnKapat.Location = new System.Drawing.Point(1215, 8);
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
            this.btnKaydet.Location = new System.Drawing.Point(1107, 8);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(103, 43);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "checkbox.png");
            this.ımageList2.Images.SetKeyName(1, "delete.png");
            // 
            // grpAraclar
            // 
            this.grpAraclar.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.grpAraclar.Controls.Add(this.flowLayoutPanel1);
            this.grpAraclar.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpAraclar.Location = new System.Drawing.Point(0, 0);
            this.grpAraclar.Name = "grpAraclar";
            this.grpAraclar.Size = new System.Drawing.Size(155, 826);
            this.grpAraclar.TabIndex = 8;
            this.grpAraclar.Text = "Araçlar";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 25);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(151, 799);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // PanelKat
            // 
            this.PanelKat.Controls.Add(this.lblY);
            this.PanelKat.Controls.Add(this.lblX);
            this.PanelKat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelKat.Location = new System.Drawing.Point(155, 0);
            this.PanelKat.Name = "PanelKat";
            this.PanelKat.Size = new System.Drawing.Size(1148, 826);
            this.PanelKat.TabIndex = 9;
            // 
            // lblY
            // 
            this.lblY.Location = new System.Drawing.Point(1025, 34);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(75, 16);
            this.lblY.TabIndex = 2;
            this.lblY.Text = "labelControl2";
            // 
            // lblX
            // 
            this.lblX.Location = new System.Drawing.Point(1025, 12);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(75, 16);
            this.lblX.TabIndex = 1;
            this.lblX.Text = "labelControl1";
            // 
            // btnKonumEkle
            // 
            this.btnKonumEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            // frmKonumDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 886);
            this.Controls.Add(this.PanelKat);
            this.Controls.Add(this.grpAraclar);
            this.Controls.Add(this.grpMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmKonumDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Konum Düzenle";
            this.Load += new System.EventHandler(this.frmKonumDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpAraclar)).EndInit();
            this.grpAraclar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelKat)).EndInit();
            this.PanelKat.ResumeLayout(false);
            this.PanelKat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ImageList ımageList2;
        private DevExpress.XtraEditors.GroupControl grpAraclar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.PanelControl PanelKat;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl lblY;
        private DevExpress.XtraEditors.LabelControl lblX;
        private DevExpress.XtraEditors.SimpleButton btnKonumEkle;
    }
}