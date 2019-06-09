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

namespace StokTakip.BackOffice.Kasa
{
    public partial class frmKasaHareket : DevExpress.XtraEditors.XtraForm
    {
        KasaDAL kasaDal = new KasaDAL();
        StokTakipContext context = new StokTakipContext();
        private string _kasaKodu;

        public frmKasaHareket(string kasaKodu, string kasaAdi)
        {
            InitializeComponent();
            _kasaKodu = kasaKodu;
            lblBaslik.Text = kasaKodu + " - " + kasaAdi + " Hareketleri";
        }

        private void frmKasaHareket_Load(object sender, EventArgs e)
        {

        }

        public void Guncelle()
        {
            gridContKasaHareket.DataSource = kasaDal.GetAll(context, c => c.KasaKodu == _kasaKodu);
            gridContOdemeTuruToplam.DataSource = kasaDal.OdemeTuruToplamListele(context, _kasaKodu);
            gridContGenelToplam.DataSource = kasaDal.GenelToplamListele(context, _kasaKodu);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (gridKasaHareket.OptionsView.ShowAutoFilterRow == true)
            {
                gridKasaHareket.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                gridKasaHareket.OptionsView.ShowAutoFilterRow = true;
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}