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

namespace StokTakip.BackOffice.Stok
{
    public partial class frmStok : DevExpress.XtraEditors.XtraForm
    {

        StokTakipContext contex = new StokTakipContext();
        StokDAL stokDal = new StokDAL();
        private string secilen;

        public frmStok()
        {
            InitializeComponent();
        }

        private void frmStok_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        public void GetAll()
        {
            gridControl1.DataSource = stokDal.GetAllJoin(contex);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnAra_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            GetAll();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string secilen = gridView1.GetFocusedRowCellValue(colStokKodu).ToString();
                stokDal.Delete(contex, c => c.StokKodu == secilen);
                stokDal.Save(contex);
                GetAll();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmStokIslem form = new frmStokIslem(new Entities.Tables.Stok());
            form.ShowDialog();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            secilen = gridView1.GetFocusedRowCellValue(colStokKodu).ToString();
            frmStokIslem form = new frmStokIslem(stokDal.GetByFilter(contex, c=> c.StokKodu == secilen));
            form.ShowDialog();
        }

        private void btnKopyala_Click(object sender, EventArgs e)
        {
            secilen = gridView1.GetFocusedRowCellValue(colStokKodu).ToString();
            Entities.Tables.Stok stokEntity = new Entities.Tables.Stok();
            stokEntity = stokDal.GetByFilter(contex, c => c.StokKodu == secilen);
            stokEntity.Id = -1;
            stokEntity.StokKodu = null;
            frmStokIslem form = new frmStokIslem(stokEntity);
            form.ShowDialog();
        }

        private void btnStokHareket_Click(object sender, EventArgs e)
        {
            secilen = gridView1.GetFocusedRowCellValue(colStokKodu).ToString();
            string secilenAd = gridView1.GetFocusedRowCellValue(colStokAdi).ToString();
            frmStokHareket form = new frmStokHareket(secilen,secilenAd);
            form.ShowDialog();
        }

        private void filterControl1_Click(object sender, EventArgs e)
        {

        }
    }
}