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
    public partial class frmDepoSec : DevExpress.XtraEditors.XtraForm
    {
        StokTakipContext context = new StokTakipContext();
        DepoDAL depoDal = new DepoDAL();
        public Entities.Tables.Depo entity = new Entities.Tables.Depo();
        private string _stokKodu;

        public frmDepoSec(string stokKodu)
        {
            InitializeComponent();
            _stokKodu = stokKodu;
        }

        private void frmDepoSec_Load(object sender, EventArgs e)
        {
            gridContDepolar.DataSource = depoDal.DepoBazindaStokListele(context, _stokKodu);
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            string depoKodu = gridDepolar.GetFocusedRowCellValue(colDepoKodu).ToString();
            entity = context.Depolar.SingleOrDefault(c => c.DepoKodu == depoKodu);
            this.Close();
        }
    }
}