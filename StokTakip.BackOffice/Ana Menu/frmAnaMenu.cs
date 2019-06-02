using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StokTakip.BackOffice.Stok;
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
            //StokTakipContext context = new StokTakipContext();
            //CariDAL cariDal = new CariDAL();
            //Cari entity = new Cari()
            //{
            //    CariKodu = "12345678",
            //    CariAdi = "Serkan Koçkan",
            //    YetkiliKisi = "Serkan",
            //    FaturaUnvani = "Koçkan aş"
            //};
            //cariDal.AddOrUpdate(context,entity);
            //cariDal.Save(context);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmStok form = new frmStok();
            form.MdiParent = this;
            form.Show();
        }
    }
}
