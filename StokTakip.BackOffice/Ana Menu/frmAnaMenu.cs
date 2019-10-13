using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using StokTakip.BackOffice.Ajanda;
using StokTakip.BackOffice.Ana_Menu;
using StokTakip.BackOffice.Ayarlar;
using StokTakip.BackOffice.Cari;
using StokTakip.BackOffice.Depo;
using StokTakip.BackOffice.Döviz_Kurları;
using StokTakip.BackOffice.Fis;
using StokTakip.BackOffice.Fiyat_Değiştir;
using StokTakip.BackOffice.Kasa;
using StokTakip.BackOffice.Kasa_Hareketleri;
using StokTakip.BackOffice.Odeme_Turu;
using StokTakip.BackOffice.Personel;
using StokTakip.BackOffice.Stok;
using StokTakip.BackOffice.Stok_Hareketleri;
using StokTakip.BackOffice.Tanim;
using StokTakip.Backup;
using StokTakip.Entities.Context;
using StokTakip.Entities.Data_Access;
using StokTakip.Entities.Tables;
using StokTakip.BackOffice.Ön_Maliyet_Formu;
using StokTakip.BackOffice.On_Maliyet_Formu;
using StokTakip.Entities.Tools;

namespace StokTakip.BackOffice 
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
            using (var context = new StokTakipContext())
            {
                context.Database.CreateIfNotExists();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frmAnaMenuBilgi form = new frmAnaMenuBilgi();
            form.MdiParent = this;
            form.Show();

            
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmStok form = new frmStok();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCari form = new frmCari();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmFis form = new frmFis();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmStokHareketleri form = new frmStokHareketleri();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmKasaHareketleri kasaHareketleri = new FrmKasaHareketleri();
            kasaHareketleri.MdiParent = this;
            kasaHareketleri.Show();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmPersonel personel = new FrmPersonel();
            personel.MdiParent = this;
            personel.Show();
        }

        private void FisIslemClick_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmFisIslem form = new frmFisIslem(null,e.Item.Caption);
            form.ShowDialog();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTopluFiyat personel = new frmTopluFiyat();
            personel.MdiParent = this;
            personel.Show();
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDepo form = new frmDepo();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmOdemeTuru form = new frmOdemeTuru();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKasa form = new frmKasa();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAjanda form = new frmAjanda();
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void barButtonItem31_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDovizKurlari form = new frmDovizKurlari();
            form.ShowDialog();
        }

        private void barButtonItem32_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAyarlar form = new frmAyarlar();
            form.ShowDialog();
        }

        private void barButtonItem33_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBackup form = new frmBackup();
            form.ShowDialog();
        }

        private void barButtonItem34_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WebClient indir = new WebClient();
            string programVersiyon = Assembly.Load("StokTakip.BackOffice").GetName().Version.ToString();
            string guncelVersiyon = indir.DownloadString("http://mutludusunceler.com/versiyonlar/text.txt")
                .Replace("\n", "");

            if (programVersiyon != guncelVersiyon)
            {
                Process.Start($"{Application.StartupPath}\\StokTakip.Update.exe");
            }
            else
            {
                MessageBox.Show("Programınız Güncel.");
            }

            
        }

        private void barButtonItem39_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSipFormlari form = new frmSipFormlari();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem40_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAnaMenuBilgi form = new frmAnaMenuBilgi();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem38_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            string link = SettingsTool.AyarOku(SettingsTool.Ayarlar.WebSitesi_URL);
            if (link!="")
            {
                System.Diagnostics.Process.Start(link);

            }
            else
            {
                System.Diagnostics.Process.Start("www.google.com");
            }
        }
    }
}

