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
using StokTakip.Entities.Tables;

namespace StokTakip.BackOffice.Cari
{
    public partial class frmCariSec : DevExpress.XtraEditors.XtraForm
    {

        CariDAL cariDal = new CariDAL();
        StokTakipContext context = new StokTakipContext();
        public List<Entities.Tables.Cari> secilen = new List<Entities.Tables.Cari>();
        public bool secildi = false;

        public frmCariSec(bool cokluSecim = false)
        {
            InitializeComponent();
            if (cokluSecim)
            {
                lblUyari.Visible = true;
                gridView1.OptionsSelection.MultiSelect = true;
            }

        }

        private void frmCariSec_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = cariDal.GetCariler(context);
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (gridView1.GetSelectedRows().Length != 0)
            {
                foreach (var row in gridView1.GetSelectedRows())
                {
                    string carikodu = gridView1.GetRowCellValue(row, colCariKodu).ToString();
                    secilen.Add(context.Cariler.SingleOrDefault(c => c.CariKodu == carikodu));

                }

                secildi = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Seçinlen bir cari bulunamadı.");
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}