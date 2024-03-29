﻿using System;
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

namespace StokTakip.BackOffice.Depo
{
    public partial class frmDepoIslem : DevExpress.XtraEditors.XtraForm
    {
        private Entities.Tables.Depo _entity;
        private DepoDAL depoDal = new DepoDAL();
        private StokTakipContext context = new StokTakipContext();
        public bool kaydedildi = false;

        public frmDepoIslem(Entities.Tables.Depo entity)
        {
            InitializeComponent();
            _entity = entity;

            toggleSwitch1.DataBindings.Add("EditValue", _entity, "Kat");
            txtDepoKodu.DataBindings.Add("Text", _entity, "DepoKodu");
            txtDepoAdi.DataBindings.Add("Text", _entity, "DepoAdi");
            txtYetkiliKodu.DataBindings.Add("Text", _entity, "YetkiliKodu");
            txtYetkiliAdi.DataBindings.Add("Text", _entity, "YetkiliAdi");
            txtTelefon.DataBindings.Add("Text", _entity, "Telefon");
            txtIl.DataBindings.Add("Text", _entity, "Il");
            txtIlce.DataBindings.Add("Text", _entity, "Ilce");
            txtSemt.DataBindings.Add("Text", _entity, "Semt");
            txtAdres.DataBindings.Add("Text", _entity, "Adres");
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama");
        }

        private void frmDepoIslem_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (depoDal.AddOrUpdate(context,_entity))
            {
                depoDal.Save(context);
                this.Close();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}