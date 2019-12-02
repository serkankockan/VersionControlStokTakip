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
    public partial class FrmPersonel : DevExpress.XtraEditors.XtraForm
    {

        StokTakipContext context = new StokTakipContext();
        PersonelDAL personelDal = new PersonelDAL();
        private string _secilen = null;

        public FrmPersonel()
        {
            InitializeComponent();
        }

        void Listele()
        {
            gridContPersonel.DataSource = personelDal.PersonelListesi(context);
        }

        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
        }

        private void btnFiltreKapat_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
        }

        private void btnFiltre_Click(object sender, EventArgs e)
        {
            filterControl1.ApplyFilter();
        }

        private void btnFiltreIptal_Click(object sender, EventArgs e)
        {
            filterControl1.FilterString = null;
            filterControl1.ApplyFilter();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            _secilen = gridPersonel.GetFocusedRowCellValue(colPersonelKodu).ToString();

            if (MessageBox.Show("Seçili olan kaydı silmek istediğinize emin misiniz?","Uyarı",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                personelDal.Delete(context,c=>c.PersonelKodu == _secilen);
                personelDal.Save(context);
                Listele();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmPersonelIslem personelIslem = new FrmPersonelIslem(new Entities.Tables.Personel());
            personelIslem.ShowDialog();
            if (personelIslem.saved)
            {
                Listele();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            _secilen = gridPersonel.GetFocusedRowCellValue(colPersonelKodu).ToString();
            FrmPersonelIslem personelIslem = new FrmPersonelIslem(personelDal.GetByFilter(context,a => a.PersonelKodu == _secilen));
            personelIslem.ShowDialog();
            if (personelIslem.saved)
            {
                Listele();
            }
        }

        private void btnHareket_Click(object sender, EventArgs e)
        {
            _secilen = gridPersonel.GetFocusedRowCellValue(colPersonelKodu).ToString();
            FrmPersonelHareket personelIslem = new FrmPersonelHareket(_secilen,
                gridPersonel.GetFocusedRowCellValue(colPersonelAdi).ToString());
            personelIslem.ShowDialog();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}