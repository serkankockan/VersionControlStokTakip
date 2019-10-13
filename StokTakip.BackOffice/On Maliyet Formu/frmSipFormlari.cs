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
using StokTakip.BackOffice.Ön_Maliyet_Formu;
using StokTakip.BackOffice.Siparis_Formu;
using StokTakip.Entities.Context;
using StokTakip.Entities.Data_Access;

namespace StokTakip.BackOffice.On_Maliyet_Formu
{
    public partial class frmSipFormlari : DevExpress.XtraEditors.XtraForm
    {
        StokTakipContext context = new StokTakipContext();
        OnMaliyetFormDAL onMaliyetFormDal = new OnMaliyetFormDAL();

        private int secilen;


        public frmSipFormlari()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmOnMaliyetFormu form = new frmOnMaliyetFormu(new Entities.Tables.OnMaliyetForm());
            form.ShowDialog();
        }

        private void frmSipFormlari_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        void GetAll()
        {
            gridContFormlar.DataSource = onMaliyetFormDal.TumOnMaliyetler(context);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            GetAll();
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

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
           duzenle();
        }

        private void gridContFormlar_DoubleClick(object sender, EventArgs e)
        {
            duzenle();
        }

        void duzenle()
        {
            secilen = Convert.ToInt32(gridFormlar.GetFocusedRowCellValue(colId));
            frmOnMaliyetFormu form = new frmOnMaliyetFormu(onMaliyetFormDal.GetByFilter(context, c => c.Id == secilen));
            form.ShowDialog();
            if (form.saved)
            {
                GetAll();
            }
        }

        private void btnKopyala_Click(object sender, EventArgs e)
        {
            //secilen = Convert.ToInt32(gridFormlar.GetFocusedRowCellValue(colId));
            //Entities.Tables.OnMaliyetForm onmaliyetEntity = new Entities.Tables.OnMaliyetForm();
            //onmaliyetEntity = onMaliyetFormDal.GetByFilter(context, c => c.Id == secilen);
            //onmaliyetEntity.Id = -1;
            //onmaliyetEntity.SiparisMiktari = null;
            //frmOnMaliyetFormu form = new frmOnMaliyetFormu(onmaliyetEntity);
            //form.ShowDialog();
            //if (form.saved)
            //{
            //    GetAll();
            //}
        }

        private void btnIslemler_Click(object sender, EventArgs e)
        {
            secilen = Convert.ToInt32(gridFormlar.GetFocusedRowCellValue(colId));
            Entities.Tables.OnMaliyetForm onMaliyetEntites = new Entities.Tables.OnMaliyetForm();
            onMaliyetEntites = onMaliyetFormDal.GetByFilter(context, c => c.Id == secilen);
            frmOnMaliyetFormu form =new frmOnMaliyetFormu(onMaliyetEntites);
            form.onayFormu = true;
            form.ShowDialog();
            if (form.saved)
            {
                GetAll();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                secilen = Convert.ToInt32(gridFormlar.GetFocusedRowCellValue(colId));
                onMaliyetFormDal.Delete(context, c => c.Id == secilen);
                onMaliyetFormDal.Save(context);
                GetAll();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}