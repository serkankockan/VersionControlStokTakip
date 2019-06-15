using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;


namespace StokTakip.BackOffice.Fis
{
    public partial class frmFisIslem : DevExpress.XtraEditors.XtraForm
    {
        
        
        public frmFisIslem()
        {
            InitializeComponent();

            
        }

        private void frmFisIslem_Load(object sender, EventArgs e)
        {

            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("C:\\Users\\Admin\\Downloads\\ds_digital\\DS-DIGI.TTF");
            txtOdenenTutar.Font = new Font(pfc.Families[0], 17, FontStyle.Bold);
            txtOdenecekTutar.Font = new Font(pfc.Families[0], 17, FontStyle.Bold);
            txtAcikHesapBakiyesi.Font = new Font(pfc.Families[0], 27, FontStyle.Bold);

            txtIndirimToplam.Font = new Font(pfc.Families[0], 17, FontStyle.Bold);
            txtIskontoOrani.Font = new Font(pfc.Families[0], 17, FontStyle.Bold);
            txtIskontoTutar.Font = new Font(pfc.Families[0], 17, FontStyle.Bold);

            txtKdvToplam.Font = new Font(pfc.Families[0], 33, FontStyle.Bold);
            txtGenelToplam.Font = new Font(pfc.Families[0], 33, FontStyle.Bold);
        }
    }
}