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

namespace StokTakip.BackOffice.Kasa
{
    public partial class frmKasaSec : DevExpress.XtraEditors.XtraForm
    {
        KasaDAL kasaDal = new KasaDAL();
        StokTakipContext context = new StokTakipContext();
        public Entities.Tables.Kasa entity = new Entities.Tables.Kasa();

        public frmKasaSec()
        {
            InitializeComponent();
        }

        private void fmrKasaSec_Load(object sender, EventArgs e)
        {
            gridContSecim.DataSource = kasaDal.KasaListele(context);
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            string kasakodu = gridSecim.GetFocusedRowCellValue(colKasaKodu).ToString();
            entity = context.Kasalar.SingleOrDefault(c => c.KasaKodu == kasakodu);
            this.Close();
        }
    }
}