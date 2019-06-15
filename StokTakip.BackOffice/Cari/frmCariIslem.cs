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
using StokTakip.BackOffice.Tanim;
using StokTakip.Entities.Context;
using StokTakip.Entities.Data_Access;

namespace StokTakip.BackOffice.Cari
{
    public partial class frmCariIslem : DevExpress.XtraEditors.XtraForm
    {
        private Entities.Tables.Cari _entity;
        private CariDAL cariDal = new CariDAL();
        private StokTakipContext context = new StokTakipContext();
        public bool saved = false;

        public frmCariIslem(Entities.Tables.Cari entity)
        {
            InitializeComponent();
            _entity = entity;
            toggleDurumu.DataBindings.Add("EditValue", _entity, "Durumu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCariKodu.DataBindings.Add("Text", _entity, "CariKodu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCariAdi.DataBindings.Add("Text", _entity, "CariAdi", false, DataSourceUpdateMode.OnPropertyChanged);
            cmbCariTuru.DataBindings.Add("Text", _entity, "CariTuru");
            txtYetkiliKisi.DataBindings.Add("Text", _entity, "YetkiliKisi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtFaturaUnvani.DataBindings.Add("Text", _entity, "FaturaUnvani", false, DataSourceUpdateMode.OnPropertyChanged);
            txtVergiDairesi.DataBindings.Add("Text", _entity, "VergiDairesi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtVergiNo.DataBindings.Add("Text", _entity, "VergiNo", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCepTelefonu.DataBindings.Add("Text", _entity, "CepTelefonu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSabitTelefon.DataBindings.Add("Text", _entity, "Telefon", false, DataSourceUpdateMode.OnPropertyChanged);
            txtfax.DataBindings.Add("Text", _entity, "Fax", false, DataSourceUpdateMode.OnPropertyChanged);
            txtEmail.DataBindings.Add("Text", _entity, "Email", false, DataSourceUpdateMode.OnPropertyChanged);
            txtWeb.DataBindings.Add("Text", _entity, "Web", false, DataSourceUpdateMode.OnPropertyChanged);
            txtIl.DataBindings.Add("Text", _entity, "Il", false, DataSourceUpdateMode.OnPropertyChanged);
            txtIlce.DataBindings.Add("Text", _entity, "Ilce", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSemt.DataBindings.Add("Text", _entity, "Semt", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAdres.DataBindings.Add("Text", _entity, "Adres", false, DataSourceUpdateMode.OnPropertyChanged);
            btnCariGrubu.DataBindings.Add("Text", _entity, "CariGrubu", false, DataSourceUpdateMode.OnPropertyChanged);
            btnCariAltGrubu.DataBindings.Add("Text", _entity, "CariAltGrubu", false, DataSourceUpdateMode.OnPropertyChanged);
            btnOzelKod1.DataBindings.Add("Text", _entity, "OzelKod1", false, DataSourceUpdateMode.OnPropertyChanged);
            btnOzelKod2.DataBindings.Add("Text", _entity, "OzelKod2", false, DataSourceUpdateMode.OnPropertyChanged);
            btnOzelKod3.DataBindings.Add("Text", _entity, "OzelKod3", false, DataSourceUpdateMode.OnPropertyChanged);
            btnOzelKod4.DataBindings.Add("Text", _entity, "OzelKod4", false, DataSourceUpdateMode.OnPropertyChanged);
            cmbAlisOzelFiyat.DataBindings.Add("Text", _entity, "AlisOzelFiyati", false, DataSourceUpdateMode.OnPropertyChanged);
            cmbSatisOzelFiyat.DataBindings.Add("Text", _entity, "SatisOzelFiyati", false, DataSourceUpdateMode.OnPropertyChanged);
            //txtIskontoOrani.DataBindings.Add("EditValue", _entity, "IskontoOrani", true, DataSourceUpdateMode.OnPropertyChanged, 0, "'%'0");
            //txtRiskLimiti.DataBindings.Add("EditValue", _entity, "RiskLimiti", true, DataSourceUpdateMode.OnPropertyChanged, 0, "C2");

            txtIskontoOrani.DataBindings.Add("Text", _entity, "IskontoOrani");
            txtIskontoOrani.DataBindings[0].FormattingEnabled = true;
            txtIskontoOrani.DataBindings[0].FormatString = "'%'0";
            txtIskontoOrani.DataBindings[0].DataSourceNullValue = "0";

            txtRiskLimiti.DataBindings.Add("Text", _entity, "RiskLimiti");
            txtRiskLimiti.DataBindings[0].FormattingEnabled = true;
            txtRiskLimiti.DataBindings[0].FormatString = "C2";
            txtRiskLimiti.DataBindings[0].DataSourceNullValue = "0"; 



        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cariDal.AddOrUpdate(context,_entity))
            {
                cariDal.Save(context);
                saved = true;
                this.Close();
            }
        }

        private void frmCariIslem_Load(object sender, EventArgs e)
        {

        }

        private void btnCariGrubu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0: 
                    frmTanim form = new frmTanim(frmTanim.TanimTuru.CariGrubu);
                    form.ShowDialog();
                    if (form.secildi)
                    {
                        btnCariGrubu.Text = form._entity.Tanimi;
                    }
                    break;
                case 1:
                    btnCariGrubu.Text = null;
                    break;
            }
        }

        private void btnOzelKod1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    frmTanim form = new frmTanim(frmTanim.TanimTuru.CariOzelKod1);
                    form.ShowDialog();
                    if (form.secildi)
                    {
                        btnOzelKod1.Text = form._entity.Tanimi;
                    }
                    break;
                case 1:
                    btnOzelKod1.Text = null;
                    break;
            }
        }
    }
}