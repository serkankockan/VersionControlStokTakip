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
            txtSipNo.DataBindings.Add("Text", _entity, "SiparisNo", false, DataSourceUpdateMode.OnPropertyChanged);

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
                    MessageBox.Show("İkinci butona basıldı");
                    break;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
        }
    }
};