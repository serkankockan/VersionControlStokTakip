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

namespace StokTakip.BackOffice.On_Maliyet_Formu
{
    public partial class frmSipFormlari : DevExpress.XtraEditors.XtraForm
    {
        public frmSipFormlari()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmOnMaliyetFormu form = new frmOnMaliyetFormu(new Entities.Tables.OnMaliyetForm());
            form.ShowDialog();
        }
    }
}