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
using StokTakip.Entities.Context;
using StokTakip.Entities.Data_Access;

namespace StokTakip.BackOffice.Depo
{
    public partial class frmDepo : DevExpress.XtraEditors.XtraForm
    {
        StokTakipContext context = new StokTakipContext();
        DepoDAL depoDal = new DepoDAL();
        private string secilen = null;

        public frmDepo()
        {
            InitializeComponent();
        }

        private void fmrDepo_Load(object sender, EventArgs e)
        {
            Listele();
        }

        public void Listele()
        {
            gridContDepolar.DataSource = depoDal.GetAll(context);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
        }

        private void btnFiltreKapat_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
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

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string secilen = gridDepolar.GetFocusedRowCellValue(colDepoKodu).ToString();
                depoDal.Delete(context, c => c.DepoKodu == secilen);
                depoDal.Save(context);
                Listele();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmDepoIslem form = new frmDepoIslem(new Entities.Tables.Depo());
            form.ShowDialog();
            if (form.kaydedildi)
            {
                Listele();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            secilen = gridDepolar.GetFocusedRowCellValue(colDepoKodu).ToString();
            frmDepoIslem form = new frmDepoIslem(depoDal.GetByFilter(context, c => c.DepoKodu == secilen));
            form.ShowDialog();
            if (form.kaydedildi)
            {
                Listele();
            }
        }
    }
}