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

namespace StokTakip.BackOffice.Personel
{
    public partial class FrmPersonelHareket : DevExpress.XtraEditors.XtraForm
    {

        StokTakipContext context = new StokTakipContext();
        PersonelDAL personelDal = new PersonelDAL();
        FisDAL fisDal = new FisDAL();
        private string _personelKodu;

        public FrmPersonelHareket(string personelKodu, string personelAdi)
        {
            InitializeComponent();

            _personelKodu = personelKodu;
            lblBaslik.Text = personelKodu + " - " + personelAdi;

        }

        private void FrmPersonelHareket_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            gridContPersonelHareket.DataSource = fisDal.GetAll(context, c => c.PlasiyerKodu == _personelKodu);
            gridContFisToplam.DataSource = personelDal.PersonelFisToplam(context, _personelKodu);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            gridPersonelHareket.OptionsView.ShowAutoFilterRow = true ? gridPersonelHareket.OptionsView.ShowAutoFilterRow==false : gridPersonelHareket.OptionsView.ShowAutoFilterRow==true;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}