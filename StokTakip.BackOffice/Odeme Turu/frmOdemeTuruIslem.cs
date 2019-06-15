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
using StokTakip.Entities.Tables;

namespace StokTakip.BackOffice.Odeme_Turu
{
    public partial class frmOdemeTuruIslem : DevExpress.XtraEditors.XtraForm
    {
        StokTakipContext context = new StokTakipContext();
        OdemeTuruDAL odemeTuruDal = new OdemeTuruDAL();
        private OdemeTuru _entity;

        public frmOdemeTuruIslem(OdemeTuru entity)
        {
            InitializeComponent();
            _entity = entity;
            txtOdemeKodu.DataBindings.Add("Text", _entity, "OdemeTuruKodu");
            txtOdemeAdi.DataBindings.Add("Text", _entity, "OdemeTuruAdi");
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama");

        }

        private void frmOdemeTuruIslem_Load(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (odemeTuruDal.AddOrUpdate(context,_entity))
            {
                odemeTuruDal.Save(context);
                this.Close();
            }
        }
    }
}