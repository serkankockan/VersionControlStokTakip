using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using StokTakip.Entities.Context;
using StokTakip.Entities.Data_Access;
using StokTakip.Entities.Tables;

namespace StokTakip.BackOffice.Konumlar
{
    public partial class frmUrunleriGoruntule : DevExpress.XtraEditors.XtraForm
    {
        private string _konumAdi;
        StokHareketDAL stokHareketDal = new StokHareketDAL();
        StokTakipContext context = new StokTakipContext();
        StokHareket stokHareket = new StokHareket();
        StokDAL stok = new StokDAL();

        public frmUrunleriGoruntule(string konumKodu)
        {

            _konumAdi = konumKodu;
            InitializeComponent();

        }

        private void frmUrunleriGoruntule_Load(object sender, EventArgs e)
        {

            var liste = stokHareketDal.GetAll(context, c=> c.Konum == _konumAdi);
            var ozellikler = stok.GetAll(context);

            foreach (var itemHareket in liste)
            {
                


            }

            //FlowLayoutPanel groupControl = new FlowLayoutPanel();
            //groupControl.Name = liste.Id.ToString();
            //groupControl.Text = liste.Id.ToString();
            //groupControl.Height = butonTanimlari.GroupHeight.Value;
            //groupControl.Width = butonTanimlari.GroupWidth.Value;
            //groupControl.Location = new Point(liste.X.Value, liste.Y.Value);
            //groupControl.AllowDrop = true;
            //flowAnaKapsayici.Controls.Add(groupControl);
        }
    }
}