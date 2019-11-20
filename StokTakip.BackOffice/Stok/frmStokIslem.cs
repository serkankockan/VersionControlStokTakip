﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using StokTakip.BackOffice.Tanim;
using StokTakip.Entities.Context;
using StokTakip.Entities.Data_Access;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using StokTakip.BackOffice.Tanim;
using StokTakip.Entities.Context;
using StokTakip.Entities.Data_Access;

namespace StokTakip.BackOffice.Stok
{
    public partial class frmStokIslem : Form
    {
        private Entities.Tables.Stok _entity;
        private StokDAL stokDal = new StokDAL();
        private StokTakipContext context = new StokTakipContext();
        public bool saved = false;

        public frmStokIslem(Entities.Tables.Stok entity)
        {
            InitializeComponent();

            _entity = entity;

            toggleDurumu.DataBindings.Add("EditValue", _entity, "Durumu");
            txtStokKodu.DataBindings.Add("Text", _entity, "StokKodu");
            txtBarkod.DataBindings.Add("Text", _entity, "Barkod");
            cmbBarkodTuru.DataBindings.Add("Text", _entity, "BarkodTuru");
            txtStokAdi.DataBindings.Add("Text", _entity, "StokAdi");
            cmbBirimi.DataBindings.Add("Text", _entity, "Birimi");
            txtUreticiKodu.DataBindings.Add("Text", _entity, "UreticiKodu");
            txtGarantiSuresi.DataBindings.Add("Text", _entity, "GarantiSuresi");

            calcMaxStokMiktari.DataBindings.Add("Text", _entity, "MaxStokMiktari");
            calcMaxStokMiktari.DataBindings[0].FormattingEnabled = true;
            calcMaxStokMiktari.DataBindings[0].FormatString = "N3";

            calcMinStokMiktari.DataBindings.Add("Text", _entity, "MinStokMiktari");
            calcMinStokMiktari.DataBindings[0].FormattingEnabled = true;
            calcMinStokMiktari.DataBindings[0].FormatString = "N3";

            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama");
            btnStokGurubu.DataBindings.Add("Text", _entity, "StokGrubu");
            btnStokAltGrubu.DataBindings.Add("Text", _entity, "StokAltGrubu");
            btnMarka.DataBindings.Add("Text", _entity, "Marka");
            btnModel.DataBindings.Add("Text", _entity, "Modeli");
            btnOzelKod1.DataBindings.Add("Text", _entity, "OzelKod1");
            btnOzelKod2.DataBindings.Add("Text", _entity, "OzelKod2");
            btnOzelKod3.DataBindings.Add("Text", _entity, "OzelKod3");
            btnOzelKod4.DataBindings.Add("Text", _entity, "OzelKod4");

            calcAlisKdv.DataBindings.Add("Text", _entity, "AlisKdv");
            calcAlisKdv.DataBindings[0].FormattingEnabled = true;
            calcAlisKdv.DataBindings[0].FormatString = "'%'0";
            calcAlisKdv.DataBindings[0].DataSourceNullValue = "0";

            calcSatisKdv.DataBindings.Add("Text", _entity, "SatisKdv");
            calcSatisKdv.DataBindings[0].FormattingEnabled = true;
            calcSatisKdv.DataBindings[0].FormatString = "'%'0";
            calcSatisKdv.DataBindings[0].DataSourceNullValue = "0";

            calcAlisFiyati1.DataBindings.Add("Text", _entity, "AlisFiyati1");
            calcAlisFiyati1.DataBindings[0].FormattingEnabled = true;
            calcAlisFiyati1.DataBindings[0].FormatString = "C2";

            calcAlisFiyati2.DataBindings.Add("Text", _entity, "AlisFiyati2");
            calcAlisFiyati2.DataBindings[0].FormattingEnabled = true;
            calcAlisFiyati2.DataBindings[0].FormatString = "C2";

            calcAlisFiyati3.DataBindings.Add("Text", _entity, "AlisFiyati3");
            calcAlisFiyati3.DataBindings[0].FormattingEnabled = true;
            calcAlisFiyati3.DataBindings[0].FormatString = "C2";

            calcSatisFiyati1.DataBindings.Add("Text", _entity, "SatisFiyati1");
            calcSatisFiyati1.DataBindings[0].FormattingEnabled = true;
            calcSatisFiyati1.DataBindings[0].FormatString = "C2";

            calcSatisFiyati2.DataBindings.Add("Text", _entity, "SatisFiyati2");
            calcSatisFiyati2.DataBindings[0].FormattingEnabled = true;
            calcSatisFiyati2.DataBindings[0].FormatString = "C2";

            calcSatisFiyati3.DataBindings.Add("Text", _entity, "SatisFiyati3");
            calcSatisFiyati3.DataBindings[0].FormattingEnabled = true;
            calcSatisFiyati3.DataBindings[0].FormatString = "C2";

            if (_entity.Gorsel!= null)
            {
                ımageSlider1.Images.Add(Image.FromStream(stokDal.ResimGetir(context, _entity.StokKodu)));
            }

        }

        private void frmStokIslem_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (stokDal.AddOrUpdate(context, _entity))
            {
                ResimKaydet();
                stokDal.Save(context);
                saved = true;
                this.Close();

            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtGorsel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtGorsel.Text = open.FileName;
                ımageSlider1.Images.Add(Image.FromFile(open.FileName));
            }
            else
            {

            }



        }

        void ResimKaydet()
        {
            if (txtGorsel.Text != null && txtGorsel.Text != "")
            {
                string image = txtGorsel.Text;
                Bitmap bmp = new Bitmap(image);
                FileStream fs = new FileStream(image, FileMode.Open, FileAccess.Read);
                byte[] bimage = new byte[fs.Length];
                fs.Read(bimage, 0, Convert.ToInt32(fs.Length));

                _entity.Gorsel = bimage;

            }
        }

        private void txtGorsel_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void Tanim_DoubleClick(object sender, EventArgs e)
        {
            var textBox = (sender as ButtonEdit);
            frmTanim.TanimTuru tanimTuru;
            tanimTuru = (frmTanim.TanimTuru)Enum.Parse(typeof(frmTanim.TanimTuru), textBox.AccessibleName.ToString());

            frmTanim form = new frmTanim(tanimTuru);
            form.ShowDialog();
            if (form.secildi)
            {
                textBox.Text = form._entity.Tanimi;
            }
        }

        private void Tanim_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            var textBox = (sender as ButtonEdit);
            frmTanim.TanimTuru tanimTuru;
            tanimTuru = (frmTanim.TanimTuru)Enum.Parse(typeof(frmTanim.TanimTuru), textBox.AccessibleName.ToString());

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
    }
}