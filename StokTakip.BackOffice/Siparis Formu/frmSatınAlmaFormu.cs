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
using StokTakip.BackOffice.Personel;
using StokTakip.Entities.Context;
using StokTakip.Entities.Data_Access;
using StokTakip.Entities.Tables;

namespace StokTakip.BackOffice.Siparis_Formu
{
    public partial class frmSatınAlmaFormu : DevExpress.XtraEditors.XtraForm
    {
        StokTakipContext context = new StokTakipContext();
        Entities.Tables.Personel PersonelEntity = new Entities.Tables.Personel();
        FormFirmaBilgiDAL formFirmaBilgiDal = new FormFirmaBilgiDAL();
        public SatinAlmaTalepForm _satinAlmaEntity;
        public FormUrunBilgi _formUrunEntity;
        public FormFirmaBilgi _formFirmaEntity;


        PersonelDAL personelDal = new PersonelDAL();
        private int personelNo = 1;
        private int personelId;
        private int personelId2;
        

        public frmSatınAlmaFormu(SatinAlmaTalepForm satinAlma, FormUrunBilgi formUrun, FormFirmaBilgi firmaBilgi)
        {
            InitializeComponent();

            _satinAlmaEntity = satinAlma;
            _formUrunEntity = formUrun;
            _formFirmaEntity = firmaBilgi;


            PersonelEntity = personelDal.GetByFilter(context, c => c.id == personelNo);

            txtAdi.DataBindings.Add("Text", PersonelEntity, "PersonelAdi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtBolumu.DataBindings.Add("Text", PersonelEntity, "Bolumu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtGorevi.DataBindings.Add("Text", PersonelEntity, "Unvani", false, DataSourceUpdateMode.OnPropertyChanged);

            personelId = PersonelEntity.id;

            gridControlFirmalar.DataSource = formFirmaBilgiDal.GetAll(context);
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            frmPersonelSec form = new frmPersonelSec();
            form.ShowDialog();
            if (form.secildi)
            {
                Entities.Tables.Personel entity = form.secilen.FirstOrDefault();

                txtAdi2.Text = entity.PersonelAdi;
                txtBolumu2.Text = entity.Bolumu;
                txtGorevi2.Text = entity.Unvani;
            }
        }

        private void btnKopyala_Click(object sender, EventArgs e)
        {
            txtAdi2.Text = txtAdi.Text;
            txtBolumu2.Text = txtBolumu.Text;
            txtGorevi2.Text = txtGorevi.Text;
            personelId2 = personelId;
        }
    }
}