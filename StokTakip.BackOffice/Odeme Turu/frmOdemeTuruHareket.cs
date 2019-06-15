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

namespace StokTakip.BackOffice.Odeme_Turu
{
    public partial class frmOdemeTuruHareket : DevExpress.XtraEditors.XtraForm
    {

        StokTakipContext context = new StokTakipContext();
        OdemeTuruDAL odemeTuruDal = new OdemeTuruDAL();
        private string _odemeTuruKodu;

        public frmOdemeTuruHareket(string odemeTuruKodu, string odemeTuruAdi)
        {
            InitializeComponent();
            _odemeTuruKodu = odemeTuruKodu;
            lblBaslik.Text = odemeTuruKodu + " - " + odemeTuruAdi + " Hareketleri";
        }

        private void frmOdemeTuruHareket_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            gridContKasaHareket.DataSource = odemeTuruDal.GetAll(context, c => c.OdemeTuruKodu == _odemeTuruKodu);
            gridContKasaBakiye.DataSource = odemeTuruDal.KasaToplamListele(context, _odemeTuruKodu);
            gridContGenelToplam.DataSource = odemeTuruDal.GenelToplamListele(context, _odemeTuruKodu);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            gridKasaHareket.OptionsView.ShowAutoFilterRow = false ? true : false;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}