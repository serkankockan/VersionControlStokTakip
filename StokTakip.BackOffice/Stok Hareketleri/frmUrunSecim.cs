using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using StokTakip.Entities.Context;
using StokTakip.Entities.Data_Access;
using StokTakip.Entities.Tables;

namespace StokTakip.BackOffice.Stok_Hareketleri
{
    public partial class frmUrunSecim : DevExpress.XtraEditors.XtraForm
    {
        public bool secildi = false;
        public List<Entities.Tables.StokHareket> secilen = new List<Entities.Tables.StokHareket>();
        StokHareket _stokHentity = new StokHareket();
        StokTakipContext context = new StokTakipContext();
        StokHareketDAL stokHareketDal = new StokHareketDAL();

        public frmUrunSecim(bool cokluSecim = false)
        {
            InitializeComponent();
            if (cokluSecim)
            {
                lblUyari.Visible = true;
                gridViewUrunSecim.OptionsSelection.MultiSelect = true;
            }
        }

        public frmUrunSecim()
        {
            InitializeComponent();
        }

        private void frmUrunSecim_Load(object sender, EventArgs e)
        {

            gridContUrunSecim.DataSource = stokHareketDal.GetAll(context).Where(x => x.Konum == null || x.Konum == "");
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (gridViewUrunSecim.GetSelectedRows().Length != 0)
            {
                foreach (var row in gridViewUrunSecim.GetSelectedRows())
                {
                    int stokId = Convert.ToInt32(gridViewUrunSecim.GetRowCellValue(row, colId).ToString());
                    _stokHentity.Konum = "2";
                    var find1 = context.StokHareketleri.Find(stokId);
                    context.StokHareketleri.Remove(find1);
                    secilen.Add(context.StokHareketleri.SingleOrDefault(c => c.Id == stokId));
                }

                secildi = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Seçilen bir ürün bulunamadı");
            }

            stokHareketDal.AddOrUpdate(context, _stokHentity);
        }
    }
}