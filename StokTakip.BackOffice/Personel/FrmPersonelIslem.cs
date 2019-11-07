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

namespace StokTakip.BackOffice.Personel
{
    public partial class FrmPersonelIslem : DevExpress.XtraEditors.XtraForm
    {


        private Entities.Tables.Personel _entity;
        private PersonelDAL personelDal = new PersonelDAL();
        private StokTakipContext context = new StokTakipContext();
        public bool saved = false;

        public FrmPersonelIslem(Entities.Tables.Personel entity)
        {
            InitializeComponent();

            _entity = entity;
            toggleDurumu.DataBindings.Add("EditValue", _entity, "Calisisyor", false, DataSourceUpdateMode.OnPropertyChanged);
            txtPersonelKodu.DataBindings.Add("Text", _entity, "PersonelKodu", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtAdi.DataBindings.Add("Text", _entity, "PersonelAdi", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtSoyad.DataBindings.Add("Text", _entity, "PersonelSoyadi", false,
                DataSourceUpdateMode.OnPropertyChanged);
            btnUnvani.DataBindings.Add("Text", _entity, "Unvani", false, DataSourceUpdateMode.OnPropertyChanged);
            cmbIseGirisTarihi.DataBindings.Add("EditValue", _entity, "IseGirisTarihi", true,
                DataSourceUpdateMode.OnPropertyChanged, null, "F");
            cmbIstenCikisTarihi.DataBindings.Add("EditValue", _entity, "IstenCikisTarihi", true,
                DataSourceUpdateMode.OnPropertyChanged, null, "F");
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCepTelefonu.DataBindings.Add("Text", _entity, "CepTelefonu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSabitTelefon.DataBindings.Add("Text", _entity, "Telefon", false, DataSourceUpdateMode.OnPropertyChanged);
            txtEmail.DataBindings.Add("Text", _entity, "Email", false, DataSourceUpdateMode.OnPropertyChanged);
            txtIl.DataBindings.Add("Text", _entity, "Il", false, DataSourceUpdateMode.OnPropertyChanged);
            txtIlce.DataBindings.Add("Text", _entity, "Ilce", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSemt.DataBindings.Add("Text", _entity, "Semt", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAdres.DataBindings.Add("Text", _entity, "Adres", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void FrmPersonelIslem_Load(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (personelDal.AddOrUpdate(context, _entity))
            {
                saved = true;
                personelDal.Save(context);
                this.Close();
            }
        }

        private void btnUnvani_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmTanim form = new frmTanim(frmTanim.TanimTuru.PersonelUnvan);
            form.ShowDialog();
            if (form.secildi)
            {
                btnUnvani.Text = form._entity.Tanimi;
            }
        }
    }
}