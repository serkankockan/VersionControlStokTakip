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

namespace StokTakip.BackOffice.Depo
{
    public partial class frmDepoHareket : DevExpress.XtraEditors.XtraForm
    {
        StokTakipContext context = new StokTakipContext();
        StokHareketDAL stokHareketDal = new StokHareketDAL();
        private string _depoKodu;

        public frmDepoHareket(string depoKodu, string depoAdi)
        {
            InitializeComponent();
            _depoKodu = depoKodu;
            lblBaslik.Text = depoKodu + " - " + depoAdi + " Hareketleri";
        }

        private void frmDepoHareket_Load(object sender, EventArgs e)
        {
            Guncelle();
        }

        public void Guncelle()
        {
            gridContHareket.DataSource = stokHareketDal.GetAll(context, c => c.DepoKodu == _depoKodu);
            gridContDepoStok.DataSource = stokHareketDal.DepoStokListele(context, _depoKodu);
            gridContIstatistik.DataSource = stokHareketDal.DepoIstatistikListele(context, _depoKodu);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (gridHareket.OptionsView.ShowAutoFilterRow == true)
            {
                gridHareket.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                gridHareket.OptionsView.ShowAutoFilterRow = true;
            }
        }
    }
}