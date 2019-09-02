using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using StokTakip.Entities.Context;
using StokTakip.Entities.Data_Access;
using StokTakip.Entities.Tools;

namespace StokTakip.BackOffice.Ayarlar
{
    public partial class frmAyarlar : DevExpress.XtraEditors.XtraForm
    {
        StokTakipContext context = new StokTakipContext();
        DepoDAL depoDal = new DepoDAL();

        public frmAyarlar()
        {
            InitializeComponent();

            lookUpDepo.Properties.DataSource = depoDal.GetAll(context);
            lookUpDepo.EditValue = SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanDepo);
            toggleSwitch1.IsOn = Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.SesAyari_Varsayilan));
            btnDosyaSecimi.Text = SettingsTool.AyarOku(SettingsTool.Ayarlar.VeriTabaniYedekleme_Varsayilan);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SesAyari_Varsayilan, toggleSwitch1.EditValue.ToString());
            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanDepo,lookUpDepo.EditValue.ToString());
            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.VeriTabaniYedekleme_Varsayilan, btnDosyaSecimi.Text);
            SettingsTool.Save();

            MessageBox.Show("Yapılan değişiklikler kaydedilmiştir.", "Bilgi", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEdit1_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            btnDosyaSecimi.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btnVarsayilan_Click(object sender, EventArgs e)
        {
            string path = @"C:\Db_Yedek";

            try
            {
                // Determine whether the directory exists.
                if (Directory.Exists(path))
                {
                    MessageBox.Show("Dosyası c:\\Db_Yedek dosyası zaten var.");
                    btnDosyaSecimi.Text = path;
                    return;
                }

                // Try to create the directory.
                Directory.CreateDirectory(path);
                MessageBox.Show("Dosya başarıyla oluturuldu " + Directory.GetCreationTime(path));
                btnDosyaSecimi.Text = path;
                // Delete the directory.
                //di.Delete();
                //Console.WriteLine("The directory was deleted successfully.");
            }
            catch
            {
                MessageBox.Show("Dosya oluşturma/okuma işlemi başarısız oldu");
            }
            finally { }
        }
    }
}