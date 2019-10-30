using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using StokTakip.BackOffice.Ön_Maliyet_Formu;
using StokTakip.Entities.Context;
using StokTakip.Entities.Data_Access;
using StokTakip.Entities.Tables;

namespace StokTakip.BackOffice.Tanim
{
    public partial class frmTanim : DevExpress.XtraEditors.XtraForm
    {
        StokTakipContext context = new StokTakipContext();
        TanimDAL tanimDal = new TanimDAL();
        private TanimTuru _tanimTuru;
        public Entities.Tables.Tanim _entity;
        public bool secildi = false;
        

        public frmTanim(TanimTuru tanimTuru)
        {
            InitializeComponent();
            _tanimTuru = tanimTuru;

            if (tanimTuru == TanimTuru.DesenNo)
            {
                groupControl3.Visible = true;
            }
        }

        public enum TanimTuru
        {
            CariGrubu,
            CariAltGrubu,
            CariOzelKod1,
            CariOzelKod2,
            CariOzelKod3,
            CariOzelKod4,
            PersonelUnvan,
            KumasCinsiVeEni,
            BaskiEni,
            PassSayisi,
            SiparisEni,
            KagitCinsi,
            TransferHizi,
            TransferDerecesi,
            SatisFason,
            DesenNo,
            Makine,
            Pazarlamaci,
            Desinator,
            
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            int secim = Convert.ToInt32(gridTanim.GetFocusedRowCellValue(colId));
            _entity = context.Tanimlar.Where(c => c.Id == secim).SingleOrDefault();
            secildi = true;
            this.Close();
        }

        private void frmTanim_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void KayitAc()
        {
            btnSec.Enabled = false;
            btnEkle.Enabled = false;
            btnDuzenle.Enabled = false;
            btnSil.Enabled = false;
            btnKaydet.Enabled = true;
            btnVazgec.Enabled = true;
            navigationFrame1.SelectedPage = navigationPage1;

            txtTanim.DataBindings.Add("Text", _entity, "Tanimi");
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama");

            //txtGorsel.DataBindings.Add("Text", _entity, "Gorsel");
        }

        void KayitKapat()
        {
            btnSec.Enabled = true;
            btnEkle.Enabled = true;
            btnDuzenle.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
            btnVazgec.Enabled = false;
            navigationFrame1.SelectedPage = navigationPage2;
            txtTanim.DataBindings.Clear();
            txtAciklama.DataBindings.Clear();
        }

        void Listele()
        {
            gridContTanim.DataSource = tanimDal.GetAll(context,c=>c.Turu == _tanimTuru.ToString());
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            _entity = new Entities.Tables.Tanim();
            KayitAc();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            int secim = Convert.ToInt32(gridTanim.GetFocusedRowCellValue(colId));
            _entity = context.Tanimlar.Where(c => c.Id == secim).SingleOrDefault();
            KayitAc();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int secilen = Convert.ToInt32(gridTanim.GetFocusedRowCellValue(colId));
                tanimDal.Delete(context, c => c.Id == secilen);
                tanimDal.Save(context);
                Listele();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            _entity.Turu = _tanimTuru.ToString();
            if (tanimDal.AddOrUpdate(context,_entity))
            {
                tanimDal.Save(context);
                ResimKaydet();
                KayitKapat();
                Listele();
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            KayitKapat();
        }

        private void txtGorsel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtGorsel.Text = open.FileName;
            }
            else
            {
                
            }
        }

        void ResimKaydet()
        {
            if (txtGorsel.Text!=null && txtGorsel.Text !="")
            {
                string image = txtGorsel.Text;
                Bitmap bmp = new Bitmap(image);
                FileStream fs = new FileStream(image, FileMode.Open, FileAccess.Read);
                byte[] bimage = new byte[fs.Length];
                fs.Read(bimage, 0, Convert.ToInt32(fs.Length));

                _entity.Gorsel = bimage;

                if (tanimDal.AddOrUpdate(context, _entity))
                {
                    tanimDal.Save(context);
                }

                
            }
        }
    }
}