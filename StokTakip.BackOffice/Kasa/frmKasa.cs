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

namespace StokTakip.BackOffice.Kasa
{
    public partial class frmKasa : DevExpress.XtraEditors.XtraForm
    {
        KasaDAL kasaDal = new KasaDAL();
        StokTakipContext context = new StokTakipContext();
        private string secilen = null;


        public frmKasa()
        {
            InitializeComponent();
        }

        public void Guncelle()
        {
            gridContKasalar.DataSource = kasaDal.KasaListele(context);
        }

        private void frmKasa_Load(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
            Guncelle();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmKasaIslem form = new frmKasaIslem(new Entities.Tables.Kasa());
            form.ShowDialog();
            if (form.Kaydedildi)
            {
                Guncelle();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            secilen = layoutView1.GetFocusedRowCellValue(colKasaKodu).ToString();
            frmKasaIslem form = new frmKasaIslem(kasaDal.GetByFilter(context, c => c.KasaKodu == secilen));
            form.ShowDialog();
            if (form.Kaydedildi)
            {
                Guncelle();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string secilen = layoutView1.GetFocusedRowCellValue(colKasaKodu).ToString();
                kasaDal.Delete(context, c => c.KasaKodu == secilen);
                kasaDal.Save(context);
                Guncelle();
            }
        }

        private void btnKasaHareket_Click(object sender, EventArgs e)
        {
            string kasaKodu = layoutView1.GetFocusedRowCellValue(colKasaKodu).ToString();
            string kasaAdi = layoutView1.GetFocusedRowCellValue(colKasaAdi).ToString();
            frmKasaHareket form = new frmKasaHareket(kasaKodu,kasaAdi);
            form.ShowDialog();
        }
    }
}