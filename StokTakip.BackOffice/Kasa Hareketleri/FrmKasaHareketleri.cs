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

namespace StokTakip.BackOffice.Kasa_Hareketleri
{
    public partial class FrmKasaHareketleri : DevExpress.XtraEditors.XtraForm
    {
        StokTakipContext context = new StokTakipContext();
        KasaHareketDAL kasaHareketDal = new KasaHareketDAL();

        public FrmKasaHareketleri()
        {
            InitializeComponent();
        }

        private void Listele()
        {
            gridContKasaHareket.DataSource = kasaHareketDal.GetAll(context);
        }

        private void FrmKasaHareketleri_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnDetayGor_Click(object sender, EventArgs e)
        {
            frmFisIslem fisIslem = new frmFisIslem(gridKasaHareket.GetFocusedRowCellValue(colFisKodu).ToString());
            fisIslem.ShowDialog();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
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
    }
}