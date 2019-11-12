using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using StokTakip.Entities.Context;
using StokTakip.Entities.Data_Access;
using StokTakip.Entities.Tables;
using StokTakip.Entities.Tools;

namespace StokTakip.BackOffice.Stok_Hareketleri
{
    public partial class frmStokDuzenle : DevExpress.XtraEditors.XtraForm
    {
        StokTakipContext context = new StokTakipContext();
        StokHareketDAL stokHareketDal = new StokHareketDAL();
        private Entities.Tables.StokHareket stokHareket;

        ObservableCollection<MyClass> myClasses = new ObservableCollection<MyClass>();

        public frmStokDuzenle(string konumKodu)
        {
            InitializeComponent();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
        }

        private void frmStokDuzenle_Load(object sender, EventArgs e)
        {

        }

        public class MyClass
        {
            public string Adi { get; set; }
            public string SoyadAdi { get; set; }
        }
    }
}