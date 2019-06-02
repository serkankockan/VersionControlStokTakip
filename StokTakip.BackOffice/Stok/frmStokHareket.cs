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

namespace StokTakip.BackOffice.Stok
{
    public partial class frmStokHareket : DevExpress.XtraEditors.XtraForm
    {
        StokTakipContext context = new StokTakipContext();
        StokHareketDAL stokHareketDal = new StokHareketDAL();
        private string _stokKodu;

        public frmStokHareket(string stokKodu, string stokAdi)
        {
            InitializeComponent();
            _stokKodu = stokKodu;
            lblBaslik.Text = _stokKodu + " - " + stokAdi + " Hareketleri";
        }

        private void frmStokHareket_Load(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void Guncelle()
        {
            gridContStokHareket.DataSource = stokHareketDal.GetAll(context, c => c.StokKodu == _stokKodu);
            gridContGenelStok.DataSource = stokHareketDal.GetGenelStok(context, _stokKodu);
            gridContDepoStok.DataSource = stokHareketDal.GetDepoStok(context, _stokKodu);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (gridStokHareket.OptionsView.ShowAutoFilterRow == true)
            {
                gridStokHareket.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                gridStokHareket.OptionsView.ShowAutoFilterRow = true;
            }
        }
    }
}