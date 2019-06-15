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

namespace StokTakip.BackOffice.Odeme_Turu
{
    public partial class frmOdemeTuru : DevExpress.XtraEditors.XtraForm
    {

        StokTakipContext context = new StokTakipContext();
        OdemeTuruDAL odemeTuruDal = new OdemeTuruDAL();


        public frmOdemeTuru()
        {
            InitializeComponent();
        }

        private void frmOdemeTuru_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            gridContOdemeTuru.DataSource = odemeTuruDal.OdemeTuruListele(context);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
        }

        private void btnFiltre_Click(object sender, EventArgs e)
        {
            filterControl1.ApplyFilter();
        }

        private void btnFiltreIptal_Click(object sender, EventArgs e)
        {
            filterControl1.FilterString = null;
            filterControl1.ApplyFilter();
        }

        private void btnFiltreKapat_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string secilen = gridOdemeTuru.GetFocusedRowCellValue(colOdemeTuruKodu).ToString();
                odemeTuruDal.Delete(context, c => c.OdemeTuruKodu == secilen);
                odemeTuruDal.Save(context);
                Listele();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmOdemeTuruIslem form = new frmOdemeTuruIslem(new OdemeTuru());
            form.ShowDialog();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            string secilen = gridOdemeTuru.GetFocusedRowCellValue(colOdemeTuruKodu).ToString();
            frmOdemeTuruIslem form = new frmOdemeTuruIslem(odemeTuruDal.GetByFilter(context,c=>c.OdemeTuruKodu == secilen));
            form.ShowDialog();
        }
    }
}