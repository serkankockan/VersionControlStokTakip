using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using StokTakip.BackOffice.Cari;
using StokTakip.BackOffice.Stok;
using StokTakip.Entities.Context;
using StokTakip.Entities.Data_Access;
using StokTakip.Entities.Tables;


namespace StokTakip.BackOffice.Fis
{
    public partial class frmFisIslem : DevExpress.XtraEditors.XtraForm
    {
        StokTakipContext context = new StokTakipContext();
        FisDAL fisDal = new FisDAL();
        StokHareket stokHareket = new StokHareket();
        KasaHareketDAL kasaHareketDal = new KasaHareketDAL();
        CariDAL cariDal = new CariDAL();
        StokHareketDAL stokHareketDal = new StokHareketDAL();
        Entities.Tables.Fis _fisentity = new Entities.Tables.Fis();
        CariBakiye entityBakiye = new CariBakiye();

        

        public frmFisIslem()
        {
            InitializeComponent();
            txtFisTuru.DataBindings.Add("Text", _fisentity, "FisTuru");
            cmbTarih.DataBindings.Add("EditValue", _fisentity, "Tarih");
            txtBelgeNo.DataBindings.Add("Text", _fisentity, "BelgeNo");
            txtAciklama.DataBindings.Add("Text", _fisentity, "Aciklama");
            lblCariKodu.DataBindings.Add("Text", _fisentity, "CariKodu");
            lblCariAdi.DataBindings.Add("Text", _fisentity, "CariAdi");
            gridContStokHareket.DataSource = context.StokHareketleri.Local.ToBindingList();
            gridContKasaHareket.DataSource = context.KasaHareketleri.Local.ToBindingList();
        }

        private void frmFisIslem_Load(object sender, EventArgs e)
        {
            //FontFamilies();
        }

        void FontFamilies()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("C:\\Users\\Admin\\Downloads\\ds_digital\\DS-DIGI.TTF");
            txtOdenenTutar.Font = new Font(pfc.Families[0], 17, FontStyle.Bold);
            txtOdenecekTutar.Font = new Font(pfc.Families[0], 17, FontStyle.Bold);
            txtAcikHesapBakiyesi.Font = new Font(pfc.Families[0], 27, FontStyle.Bold);
            txtMiktar.Font = new Font(pfc.Families[0], 17, FontStyle.Bold);
            txtBarkod.Font = new Font(pfc.Families[0], 17, FontStyle.Bold);

            txtIndirimToplam.Font = new Font(pfc.Families[0], 17, FontStyle.Bold);
            txtIskontoOrani.Font = new Font(pfc.Families[0], 17, FontStyle.Bold);
            txtIskontoTutar.Font = new Font(pfc.Families[0], 17, FontStyle.Bold);

            txtKdvToplam.Font = new Font(pfc.Families[0], 33, FontStyle.Bold);
            txtGenelToplam.Font = new Font(pfc.Families[0], 33, FontStyle.Bold);
        }

        private StokHareket StokSec(Entities.Tables.Stok entity)
        {
            StokHareket stokHareket = new StokHareket();
            stokHareket.StokKodu = entity.StokKodu;
            stokHareket.StokAdi = entity.StokAdi;
            stokHareket.Barkod = entity.Barkod;
            stokHareket.BarkodTuru = entity.BarkodTuru;
            stokHareket.BirimFiyat = entity.SatisFiyati1;
            stokHareket.Birimi = entity.Birimi;
            stokHareket.Miktar = txtMiktar.Value;
            stokHareket.KDV = entity.SatisKDV;
            stokHareket.IndirimOrani = 0;
            return stokHareket;
        }

        private void btnStokSec_Click(object sender, EventArgs e)
        {
            frmStokSec form = new frmStokSec();
            form.ShowDialog();
            if (form.secildi)
            {
                stokHareketDal.AddOrUpdate(context, StokSec(form.secilen.First()));
                Toplamlar();
            }
        }

        private void txtBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Entities.Tables.Stok entity;
                entity = context.Stoklar.Where(c => c.Barkod == txtBarkod.Text).SingleOrDefault();
                if (entity!=null)
                {
                    stokHareketDal.AddOrUpdate(context, StokSec(entity));
                    Toplamlar();
                }
                else
                {
                    MessageBox.Show("Aradığınız barkod numarası ürünler arasında bulunamadı.");
                }

                txtBarkod.Text = null;
            }
        }

        private void btnCariBul_Click(object sender, EventArgs e)
        {
            frmCariSec form = new frmCariSec();
            form.ShowDialog();
            if (form.secildi)
            {
                Entities.Tables.Cari entity = form.secilen.FirstOrDefault();
                entityBakiye = this.cariDal.CariBakiyesi(context, entity.CariKodu);


                lblCariKodu.Text = entity.CariKodu;
                lblCariAdi.Text = entity.CariAdi;
                txtFaturaUnvani.Text = entity.FaturaUnvani;
                txtVergiDairesi.Text = entity.VergiDairesi;
                txtVergiNo.Text = entity.VergiNo;
                txtCepTelefonu.Text = entity.CepTelefonu;
                txtIl.Text = entity.Il;
                txtIlce.Text = entity.Ilce;
                txtSemt.Text = entity.Semt;
                txtAdres.Text = entity.Adres;

                lblAlacak.Text = entityBakiye.Alacak.ToString("C2");
                lblBorc.Text = entityBakiye.Borc.ToString("C2");
                lblBakiye.Text = entityBakiye.Bakiye.ToString("C2");
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lblCariKodu.Text = null;
            lblCariAdi.Text = null;
            txtFaturaUnvani.Text = null;
            txtVergiDairesi.Text = null;
            txtVergiNo.Text = null;
            txtCepTelefonu.Text = null;
            txtIl.Text = null;
            txtIlce.Text = null;
            txtSemt.Text = null;
            txtAdres.Text = null;

            lblAlacak.Text = "Görüntülenemiyor";
            lblBorc.Text = "Görüntülenemiyor";
            lblBakiye.Text = "Görüntülenemiyor";
        }

        private void gridStokHareket_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
                Toplamlar();
        }

        private void Toplamlar()
        {
            gridStokHareket.UpdateSummary();

            txtIskontoTutar.Value =
                Convert.ToDecimal(colToplamTutar.SummaryItem.SummaryValue) / 100 * txtIskontoOrani.Value;

            txtGenelToplam.Value = Convert.ToDecimal(colToplamTutar.SummaryItem.SummaryValue) - txtIskontoTutar.Value;
            txtKdvToplam.Value = Convert.ToDecimal(colKdvToplam.SummaryItem.SummaryValue);
            txtIndirimToplam.Value = Convert.ToDecimal(colIndirimTutar.SummaryItem.SummaryValue);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtIskontoOrani_Validated(object sender, EventArgs e)
        {
            Toplamlar();
        }
    }
}