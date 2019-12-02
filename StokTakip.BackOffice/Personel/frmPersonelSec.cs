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

namespace StokTakip.BackOffice.Personel
{
    public partial class frmPersonelSec : DevExpress.XtraEditors.XtraForm
    {

        PersonelDAL personelDal = new PersonelDAL();
        StokTakipContext context = new StokTakipContext();
        public List<Entities.Tables.Personel> secilen = new List<Entities.Tables.Personel>();
        public bool secildi = false;

        public frmPersonelSec()
        {
            InitializeComponent();

            gridControl1.DataSource = personelDal.GetByFilter(context, c => c.Calisisyor == true);

        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (gridView1.GetSelectedRows().Length != 0)
            {
                foreach (var row in gridView1.GetSelectedRows())
                {
                    int Id = Convert.ToInt32(gridView1.GetRowCellValue(row, colid).ToString());
                    secilen.Add(context.Personeller.SingleOrDefault(c => c.id == Id));
                }
                secildi = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Seçinlen personel bulunamadı.");
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}