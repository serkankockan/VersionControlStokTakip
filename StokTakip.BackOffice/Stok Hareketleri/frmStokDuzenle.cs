using System;
using System.Collections;
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
using DevExpress.Data.Filtering.Helpers;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting.Native;
using StokTakip.BackOffice.Stok;
using StokTakip.Entities.Context;
using StokTakip.Entities.Data_Access;
using StokTakip.Entities.Tables;
using StokTakip.Entities.Tables.Other_Tables;
using StokTakip.Entities.Tools;

namespace StokTakip.BackOffice.Stok_Hareketleri
{
    public partial class frmStokDuzenle : DevExpress.XtraEditors.XtraForm
    {
        StokTakipContext context = new StokTakipContext();
        StokHareketDAL stokHareketDal = new StokHareketDAL();
        private ButonKonum _butonKonumEntity;
        private StokHareket _entity;
        private string _konumKodu;
        List<StokHareket> stokHarekets = new List<StokHareket>();
        private TableTools tableTools;
        List<Entities.Tables.Stok> stoks = new List<Entities.Tables.Stok>();
        StokDAL stokDal = new StokDAL();
        private bool islem = false;
        ButonKonumDAL butonButonKonumDal = new ButonKonumDAL();

        public frmStokDuzenle(string konumKodu,ButonKonum butonKonumEntity)
        {
            InitializeComponent();

            _butonKonumEntity = butonKonumEntity;

            _konumKodu = konumKodu;

            gridViewSol.OptionsSelection.MultiSelect = true;
            gridViewSag.OptionsSelection.MultiSelect = true;

            txtKonumAdi.DataBindings.Add("Text", _butonKonumEntity, "KonumAdi", false, DataSourceUpdateMode.OnPropertyChanged);

            lblBaslik.Text = "Konum Kodu :" + _konumKodu;

            stoks = context.Stoklar.ToList();
            stokHarekets = context.StokHareketleri.ToList();

            foreach (var stokHareket in stokHarekets) // Görselleeri doldurur
            {
                var stokGorsel = stoks.Single(c => c.StokKodu == stokHareket.StokKodu);
                if (stokGorsel != null)
                    if (stokGorsel.Gorsel != null)
                        stokHareket.Resim = stokGorsel.Gorsel;
            }

            UpdateGrids();
        }

        void UpdateGrids()
        {
            if (gridContSol != null) gridContSol.DataSource = stokHarekets.Where(c => string.IsNullOrEmpty(c.Konum));
            if (gridContSag != null)
                gridContSag.DataSource = stokHarekets.Where(c => _konumKodu != null && c.Konum == _konumKodu);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (islem)
            {
                foreach (var item in stokHarekets.Where(c => c.Flag))
                {
                    _entity = stokHareketDal.GetByFilter(context, c => c.Id == item.Id);
                    _entity.Konum = item.Konum;
                    if (stokHareketDal.AddOrUpdate(context, _entity))
                    {
                        stokHareketDal.Save(context);
                    }
                }

                DialogResult result = MessageBox.Show(
                    "Kayıt İşlemi Tamamlandı! Konum düzenlemeye devam etmek istiyor musunuz?", "Bilgi Penceresi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    
                }
                else if (result == DialogResult.No)
                {
                    this.Close();
                }
            }

            if (butonButonKonumDal.AddOrUpdate(context, _butonKonumEntity))
            {
                butonButonKonumDal.Save(context);
            }
        }

        private void frmStokDuzenle_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            
            if (gridViewSol.GetSelectedRows().Length != 0)
            {
                foreach (var row in gridViewSol.GetSelectedRows())
                {
                    int stokId = Convert.ToInt32(gridViewSol.GetRowCellValue(row, colId).ToString());

                    var stok = stokHarekets.FirstOrDefault(s => s.Id == stokId);

                    if (stok != null)
                    {
                        stok.Konum = _konumKodu;
                        stok.Flag = true;
                    }
                }
                UpdateGrids();
                islem = true;
            }
            else
            {
                MessageBox.Show("Konuma eklemek istediğiniz ürünü sol tablodan seçiniz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCikart_Click(object sender, EventArgs e)
        {
            if (gridViewSag.GetSelectedRows().Length != 0)
            {
                foreach (var row in gridViewSag.GetSelectedRows())
                {
                    int stokId = Convert.ToInt32(gridViewSag.GetRowCellValue(row, colId).ToString());

                    var stok = stokHarekets.FirstOrDefault(s => s.Id == stokId);

                    if (stok != null)
                    {
                        stok.Konum = null;
                        stok.Flag = true;
                    }
                }
                UpdateGrids();
                islem = true;
            }
            else
            {
                MessageBox.Show("Konumdan çıkartmak istediğiniz ürünü sağ tablodan seçiniz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            stokHarekets.Clear();
            stokHarekets = context.StokHareketleri.ToList();
            UpdateGrids();
            islem = true;
        }

        private void gridViewSag_Click(object sender, EventArgs e)
        {

        }

        private void repositoryItemImageEdit2_Click(object sender, EventArgs e)
        {


        }

        private void gridContSag_DataSourceChanged(object sender, EventArgs e)
        {
            
        }

        private void gridViewSag_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            
        }
    }
}
