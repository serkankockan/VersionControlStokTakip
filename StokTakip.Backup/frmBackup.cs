using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StokTakip.Entities.Context;
using StokTakip.Entities.Tools;

namespace StokTakip.Backup
{
    public partial class frmBackup : DevExpress.XtraEditors.XtraForm
    {

        StokTakipContext context = new StokTakipContext();

        public frmBackup()
        {
            InitializeComponent();
            btnDosyaYolu.Text = SettingsTool.AyarOku(SettingsTool.Ayarlar.VeriTabaniYedekleme_Varsayilan);

        }

        private void btnYedekle_Click(object sender, EventArgs e)
        {


            string tarih = DateTime.Now.ToString("yyyy-MM-dd");
            string sqlCumle = $"USE StokTakip; BACKUP DATABASE StokTakip TO DISK = '{SettingsTool.AyarOku(SettingsTool.Ayarlar.VeriTabaniYedekleme_Varsayilan)}\\{tarih}-Yedek.nsy'";
            // $"USE StokTakip; BACKUP DATABASE StokTakip TO DISK = '{Application.StartupPath + "\\" + tarih + "-Yedek.BAK"}  '"; Son çalışıyor
            context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, sqlCumle);

            MessageBox.Show(tarih + " tarihli yedekleme işleminiz gerçekleştirildi.", "Bilgi", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void buttonEdit1_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FolderBrowserDialog form = new FolderBrowserDialog();
            if (form.ShowDialog()==DialogResult.OK)
            {
                btnDosyaYolu.Text = form.SelectedPath;
            }
        }

        private void btnGeriYukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "StokTakip Yedekleme Dosyası *.nsy|*.nsy";
            if (dialog.ShowDialog()==DialogResult.OK)
            {
                string sqlCumle =
                    $"USE master;ALTER DATABASE StokTakip SET SINGLE_USER WITH ROLLBACK IMMEDIATE;ALTER DATABASE StokTakip SET READ_ONLY; RESTORE DATABASE StokTakip FROM DISK='{dialog.FileName}' WITH REPLACE; ALTER DATABASE StokTakip SET MULTI_USER;";
                context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, sqlCumle);

            }
        }
    }
}
