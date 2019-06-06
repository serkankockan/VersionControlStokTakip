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

namespace StokTakip.BackOffice.Cari
{
    public partial class frmCariHareket : DevExpress.XtraEditors.XtraForm
    {
        CariDAL cariDal = new CariDAL();
        StokTakipContext context = new StokTakipContext();
        private string _cariKodu = null;

        public frmCariHareket(string cariKodu, string cariAdi)
        {
            InitializeComponent();
            _cariKodu = cariKodu;
            lblBaslik.Text = _cariKodu + " - " + cariAdi + " Hareketleri";
        }

        private void frmCariHareket_Load(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void Guncelle()
        {
            gridContFisToplam.DataSource = cariDal.CariFisGenelToplam(context, _cariKodu);
            gridContBakiye.DataSource = cariDal.CariGenelToplam(context, _cariKodu);
            gridContCariHareket.DataSource = cariDal.CariFisAyrinti(context, _cariKodu);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (gridCariHareket.OptionsView.ShowAutoFilterRow == true)
            {
                gridCariHareket.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                gridCariHareket.OptionsView.ShowAutoFilterRow = true;
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}