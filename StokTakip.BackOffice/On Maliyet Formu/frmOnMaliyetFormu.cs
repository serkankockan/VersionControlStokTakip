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
using StokTakip.BackOffice.Cari;
using StokTakip.BackOffice.Tanim;
using StokTakip.Entities.Context;
using StokTakip.Entities.Data_Access;
using StokTakip.Entities.Tables;

namespace StokTakip.BackOffice.Ön_Maliyet_Formu
{
    public partial class frmOnMaliyetFormu : DevExpress.XtraEditors.XtraForm
    {
        private Entities.Tables.OnMaliyetForm _entity;
        private OnMaliyetFormDAL onMaliyetFormDal = new OnMaliyetFormDAL();
        private StokTakipContext context = new StokTakipContext();
        public bool saved = false;

        //public List<Entities.Tables.Cari> secilen = new List<Entities.Tables.Cari>();

        public frmOnMaliyetFormu(Entities.Tables.OnMaliyetForm entity)
        {
            InitializeComponent();
            _entity = entity;

            toggleDurumu.DataBindings.Add("EditValue", _entity, "Durumu", false, DataSourceUpdateMode.OnPropertyChanged);
            btnMusteriAdi.DataBindings.Add("Text", _entity, "MusteriAdi", false, DataSourceUpdateMode.OnPropertyChanged);
            btnDesenNo.DataBindings.Add("Text", _entity, "DesenNo", false, DataSourceUpdateMode.OnPropertyChanged);
            
            txtSipNo.Text = (Convert.ToInt32(txtSipNo.EditValue) + 1).ToString();
        }

        private void btnMusteriAdi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    frmCariSec form = new frmCariSec();
                    form.ShowDialog();
                    if (form.secildi)
                    {
                        Entities.Tables.Cari entity = form.secilen.FirstOrDefault();
                        btnMusteriAdi.Text = entity.CariAdi;
                    }
                    break;
                case 1:
                    btnMusteriAdi.Text = null;
                    break;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (onMaliyetFormDal.AddOrUpdate(context, _entity))
            {
                onMaliyetFormDal.Save(context);
                saved = true;
                this.Close();
            }
        }


        private void Tanim_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var textBox = (sender as ButtonEdit);
            frmTanim.TanimTuru tanimTuru;
            tanimTuru = (frmTanim.TanimTuru) Enum.Parse(typeof(frmTanim.TanimTuru),textBox.AccessibleName.ToString());

            switch (e.Button.Index)
            {
                case 0:
                    frmTanim form = new frmTanim(tanimTuru);
                    form.ShowDialog();
                    if (form.secildi)
                    {
                        textBox.Text = form._entity.Tanimi;
                    }
                    break;
                case 1:
                    textBox.Text = null;
                    break;
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
};