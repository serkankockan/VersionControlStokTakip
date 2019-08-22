using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StokTakip.BackOffice.Ana_Menu;
using StokTakip.BackOffice.Cari;
using StokTakip.BackOffice.Fis;
using StokTakip.BackOffice.Kasa_Hareketleri;
using StokTakip.BackOffice.Personel;
using StokTakip.BackOffice.Stok;
using StokTakip.BackOffice.Stok_Hareketleri;
using StokTakip.BackOffice.Tanim;
using StokTakip.Entities.Context;
using StokTakip.Entities.Data_Access;
using StokTakip.Entities.Tables;

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

    }
}
