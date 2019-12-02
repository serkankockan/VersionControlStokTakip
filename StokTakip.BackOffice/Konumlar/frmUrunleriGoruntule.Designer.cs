namespace StokTakip.BackOffice.Konumlar
{
    partial class frmUrunleriGoruntule
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
            this.xtraScrollableControl3 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.SuspendLayout();
            // 
            // xtraScrollableControl3
            // 
            this.xtraScrollableControl3.Location = new System.Drawing.Point(109, 39);
            this.xtraScrollableControl3.Name = "xtraScrollableControl3";
            this.xtraScrollableControl3.Size = new System.Drawing.Size(757, 658);
            this.xtraScrollableControl3.TabIndex = 3;
            this.xtraScrollableControl3.Click += new System.EventHandler(this.xtraScrollableControl3_Click);
            // 
            // frmUrunleriGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 815);
            this.Controls.Add(this.xtraScrollableControl3);
            this.Name = "frmUrunleriGoruntule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urunler";
            this.Load += new System.EventHandler(this.frmUrunleriGoruntule_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl3;
    }
}