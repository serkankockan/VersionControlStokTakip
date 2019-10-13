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
using StokTakip.BackOffice.On_Maliyet_Formu;
using StokTakip.Entities.Context;
using StokTakip.Entities.Data_Access;
using StokTakip.BackOffice.Ana_Menu;

namespace StokTakip.BackOffice.Ana_Menu
{
    public partial class frmAnaMenuBilgi : DevExpress.XtraEditors.XtraForm
    {
        StokTakipContext context = new StokTakipContext();
        OnMaliyetFormDAL onMaliyetFormDal = new OnMaliyetFormDAL();

        public frmAnaMenuBilgi()
        {
            InitializeComponent();
        }

        private void frmAnaMenuBilgi_Load(object sender, EventArgs e)
        {
            int onayBekleyenAdet = 0;
            onayBekleyenAdet = onMaliyetFormDal.OnayBekleyenler(context);

            tileMaliyetForm.Text = "Onay Bekleyen Form Adedi :" + onayBekleyenAdet;

        }

        private void tileMaliyetForm_ItemClick(object sender, TileItemEventArgs e)
        {
            frmSipFormlari form = new frmSipFormlari();
            form.MdiParent = Form1.ActiveForm;
            form.Show();
        }
    }
}