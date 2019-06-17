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
    public partial class frmStokSec : DevExpress.XtraEditors.XtraForm
    {
        StokDAL stokDal = new StokDAL();
        StokTakipContext context = new StokTakipContext();
        public List<Entities.Tables.Stok> secilen = new List<Entities.Tables.Stok>();
        public bool secildi = false;

        public frmStokSec(bool cokluSecim=false)
        {
            InitializeComponent();
            if (cokluSecim)
            {
                lblUyari.Visible = true;
                gridStoklar.OptionsSelection.MultiSelect = true;
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmStokSec_Load(object sender, EventArgs e)
        {
            gridContStoklar.DataSource = stokDal.GetAllJoin(context);
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (gridStoklar.GetSelectedRows().Length!=0)
            {
                foreach (var row in gridStoklar.GetSelectedRows())
                {
                    string stokkodu = gridStoklar.GetRowCellValue(row, colStokKodu).ToString();
                    secilen.Add(context.Stoklar.SingleOrDefault(c => c.StokKodu == stokkodu));
                }

                secildi = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Seçilen bir ürün bulunamadı");
            }
        }
    }
}