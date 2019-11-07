namespace StokTakip.BackOffice.Konumlar
{
    partial class frmSecimEkranı
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
            this.btnGoruntule = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnGoruntule
            // 
            this.btnGoruntule.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoruntule.Appearance.Options.UseFont = true;
            this.btnGoruntule.Location = new System.Drawing.Point(114, 46);
            this.btnGoruntule.Name = "btnGoruntule";
            this.btnGoruntule.Size = new System.Drawing.Size(303, 62);
            this.btnGoruntule.TabIndex = 0;
            this.btnGoruntule.Text = "Görüntüle";
            this.btnGoruntule.Click += new System.EventHandler(this.btnGoruntule_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.btnDuzenle.Appearance.Options.UseFont = true;
            this.btnDuzenle.Location = new System.Drawing.Point(114, 132);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(303, 62);
            this.btnDuzenle.TabIndex = 0;
            this.btnDuzenle.Text = "Düzenle";
            // 
            // frmSecimEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 249);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnGoruntule);
            this.Name = "frmSecimEkranı";
            this.Text = "Düzenle / Görüntüle";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnGoruntule;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
    }
}