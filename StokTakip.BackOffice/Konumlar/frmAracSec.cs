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

namespace StokTakip.BackOffice.Konumlar
{
    public partial class frmAracSec : DevExpress.XtraEditors.XtraForm
    {
        StokTakipContext context = new StokTakipContext();
        ButonTanimDAL butonTanimDal = new ButonTanimDAL();
        int secilen;
        public bool secildi = false;
        public bool duzenleme = false;


        public frmAracSec()
        {
            InitializeComponent();
        }

        private void frmAracSec_Load(object sender, EventArgs e)
        {
            Listele();
            
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colid).ToString());
            frmAracEkle form = new frmAracEkle(butonTanimDal.GetByFilter(context, c => c.Id == secilen),true);
            form.lblBaslik.Text = "Araç Düzenle - " + gridView1.GetFocusedRowCellValue(colButonIsimleri).ToString();
            form.ShowDialog();
            if (form.kaydedildi)
            {
                secildi = true;
                Listele();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Listele()
        {
            gridControl1.DataSource = butonTanimDal.AraclarButonlari(context);
        }
    }
}