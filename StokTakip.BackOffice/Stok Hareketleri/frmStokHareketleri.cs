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
using StokTakip.BackOffice.Fis;
using StokTakip.Entities.Context;
using StokTakip.Entities.Data_Access;

namespace StokTakip.BackOffice.Stok_Hareketleri
{
    public partial class frmStokHareketleri : DevExpress.XtraEditors.XtraForm
    {
        StokTakipContext context = new StokTakipContext();
        StokHareketDAL stokHareketDal = new StokHareketDAL();

        public frmStokHareketleri()
        {
            InitializeComponent();
        }

        private void Listele()
        {
            gridContStokHareket.DataSource = stokHareketDal.GetAll(context);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnFiltre_Click(object sender, EventArgs e)
        {
            filterControl1.ApplyFilter();
        }

        private void frmStokHareketleri_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiltreKapat_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
        }

        private void btnFiltreIptal_Click(object sender, EventArgs e)
        {
            filterControl1.FilterString = null;
            filterControl1.ApplyFilter();
        }

        private void repoSeriNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string veri = Convert.ToString(gridStokHareket.GetFocusedRowCellValue(colSeriNo));
            fmrSeriNo form = new fmrSeriNo(veri);
            form.Kilitli = true;
            form.ShowDialog();
            
        }

        private void btnDetayGor_Click(object sender, EventArgs e)
        {
            frmFisIslem fisIslem = new frmFisIslem(gridStokHareket.GetFocusedRowCellValue(colFisKodu).ToString());
            fisIslem.ShowDialog();
        }
    }
}