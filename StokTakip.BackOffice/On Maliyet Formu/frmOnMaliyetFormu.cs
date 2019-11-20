using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
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
        public bool onayFormu = false;
        public bool onaydDurumu;

        //public List<Entities.Tables.Cari> secilen = new List<Entities.Tables.Cari>();

        public frmOnMaliyetFormu(Entities.Tables.OnMaliyetForm entity)
        {
            InitializeComponent();
            _entity = entity;

            toggleDurumu.DataBindings.Add("EditValue", _entity, "Durumu", false,
                DataSourceUpdateMode.OnPropertyChanged);
            btnMusteriAdi.DataBindings.Add("Text", _entity, "MusteriAdi", false,
                DataSourceUpdateMode.OnPropertyChanged);
            btnDesenNo.DataBindings.Add("Text", _entity, "DesenNo", false, DataSourceUpdateMode.OnPropertyChanged);
            btnMakina.DataBindings.Add("Text", _entity, "Makina", false, DataSourceUpdateMode.OnPropertyChanged);
            btnBoyaGideri.DataBindings.Add("Text", _entity, "BoyaGideri", false,
                DataSourceUpdateMode.OnPropertyChanged);
            btnProfil.DataBindings.Add("Text", _entity, "Profil", false, DataSourceUpdateMode.OnPropertyChanged);
            btnKumasCinsiveEni.DataBindings.Add("Text", _entity, "KumasCinsiVeEni", false,
                DataSourceUpdateMode.OnPropertyChanged);
            btnPassSayisi.DataBindings.Add("Text", _entity, "PassSayisi", false,
                DataSourceUpdateMode.OnPropertyChanged);
            btnBaskiEni.DataBindings.Add("Text", _entity, "BaskiEni", false, DataSourceUpdateMode.OnPropertyChanged);
            btnKagitCinsi.DataBindings.Add("Text", _entity, "KagitCinsi", false,
                DataSourceUpdateMode.OnPropertyChanged);
            btnSiparisEni.DataBindings.Add("Text", _entity, "Eni", false, DataSourceUpdateMode.OnPropertyChanged);
            btnTansferHizi.DataBindings.Add("Text", _entity, "TransferHizi", false,
                DataSourceUpdateMode.OnPropertyChanged);
            cmbTarih.DataBindings.Add("EditValue", _entity, "Tarih", false,
                DataSourceUpdateMode.OnPropertyChanged, DateTime.Now);
            btnTransferDerecesi.DataBindings.Add("Text", _entity, "TransferDerecesi", false,
                DataSourceUpdateMode.OnPropertyChanged);
            btnSatisFason.DataBindings.Add("Text", _entity, "IsTipi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSipMiktar.DataBindings.Add("Text", _entity, "SiparisMiktari", false,
                DataSourceUpdateMode.OnPropertyChanged);
            btnPazarlamaci.DataBindings.Add("Text", _entity, "Pazarlamaci", false,
                DataSourceUpdateMode.OnPropertyChanged);
            btnDesinator.DataBindings.Add("Text", _entity, "Desinator", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSipNo.DataBindings.Add("Text", _entity, "Id", false, DataSourceUpdateMode.Never);

            if (_entity.DesenNo != null)
            {
                ımageSlider1.Images.Add(Image.FromStream(onMaliyetFormDal.ResimGetir(context, _entity.DesenNo)));
            }

            if (_entity.onayDurumu == "Onaylandı")
            {
                lblDurum.Text = "Onaylandı";
                lblDurum.ForeColor = Color.FromArgb(150, Color.PaleGreen);
            }
            else if (_entity.onayDurumu == "Bekliyor")
            {
                lblDurum.Text = "Bekliyor";
                lblDurum.ForeColor = Color.FromArgb(150, Color.Orange);
            }
            else if (_entity.onayDurumu == "Reddedildi")
            {
                lblDurum.Text = "Reddedildi";
                lblDurum.ForeColor = Color.FromArgb(150, Color.Salmon);
            }
            else
            {
                groupControl1.Visible = false;
            }
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

                var entry = context.Entry(_entity);

                if (entry.State == EntityState.Added)
                {
                    _entity.onayDurumu = "Bekliyor";
                    MessageBox.Show("Sipariş talep formu oluşturulmuştur", "Bilgi", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                onMaliyetFormDal.Save(context);
                saved = true;
                this.Close();
                this.Close();
            }
        }


        private void Tanim_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var textBox = (sender as ButtonEdit);
            frmTanim.TanimTuru tanimTuru;
            tanimTuru = (frmTanim.TanimTuru) Enum.Parse(typeof(frmTanim.TanimTuru), textBox.AccessibleName.ToString());

            switch (e.Button.Index)
            {
                case 0:
                    frmTanim form = new frmTanim(tanimTuru);
                    form.ShowDialog();
                    if (form.secildi)
                    {
                        textBox.Text = form._entity.Tanimi;

                        ımageSlider1.Images.Clear();
                        ımageSlider1.Images.Add(Image.FromStream(onMaliyetFormDal.ResimGetir(context, _entity.DesenNo)));
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

        private void Tanim_DoubleClick(object sender, EventArgs e)
        {
            var textBox = (sender as ButtonEdit);
            frmTanim.TanimTuru tanimTuru;
            tanimTuru = (frmTanim.TanimTuru) Enum.Parse(typeof(frmTanim.TanimTuru), textBox.AccessibleName.ToString());

            frmTanim form = new frmTanim(tanimTuru);
            form.ShowDialog();
            if (form.secildi)
            {
                textBox.Text = form._entity.Tanimi;

                ımageSlider1.Images.Clear();
                ımageSlider1.Images.Add(Image.FromStream(onMaliyetFormDal.ResimGetir(context, _entity.DesenNo)));
            }
        }

        private void frmOnMaliyetFormu_Load(object sender, EventArgs e)
        {
            if (onayFormu)
            {
                splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel1;
            }
            else
            {
                splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
            }
        }

        private void Islemler_ButtonClick(object sender, EventArgs e)
        {
            string durum;
            var button = sender as SimpleButton;
            durum = button.AccessibleName.ToString();

            switch (durum)
            {
                case "Onay":

                    if (MessageBox.Show("Onaylamak istediğinize emin misiniz?", "Bilgi", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _entity.onayDurumu = "Onaylandı";

                        if (onMaliyetFormDal.AddOrUpdate(context, _entity))
                        {
                            onMaliyetFormDal.Save(context);
                            this.Close();
                        }
                    }
                    else
                    {
                        return;
                    }
                    break;

                case "Reddet":

                    if (MessageBox.Show("Reddetmek istediğinize emin misiniz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _entity.onayDurumu = "Reddedildi";

                        if (onMaliyetFormDal.AddOrUpdate(context, _entity))
                        {
                            onMaliyetFormDal.Save(context);
                            this.Close();
                        }
                    }
                    else
                    {
                        return;
                    }

                    break;
            }
        }

        private void btnMusteriAdi_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}