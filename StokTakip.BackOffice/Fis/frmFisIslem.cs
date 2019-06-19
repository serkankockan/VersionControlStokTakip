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
using StokTakip.BackOffice.Depo;
using StokTakip.BackOffice.Kasa;
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
            txtFaturaUnvani.DataBindings.Add("Text", _fisentity, "FaturaUnvani");
            txtCepTelefonu.DataBindings.Add("Text", _fisentity, "CepTelefonu");
            txtIl.DataBindings.Add("Text", _fisentity, "Il");
            txtIlce.DataBindings.Add("Text", _fisentity, "Ilce");
            txtSemt.DataBindings.Add("Text", _fisentity, "Semt");
            txtAdres.DataBindings.Add("Text", _fisentity, "Adres");
            txtVergiDairesi.DataBindings.Add("Text", _fisentity, "VergiDairesi");
            txtVergiNo.DataBindings.Add("Text", _fisentity, "VergiNo");

            gridContStokHareket.DataSource = context.StokHareketleri.Local.ToBindingList();
            gridContKasaHareket.DataSource = context.KasaHareketleri.Local.ToBindingList();

            foreach (var item in context.OdemeTurleri.ToList())
            {
                var button = new SimpleButton
                {
                    Name = item.OdemeTuruKodu,
                    Text = item.OdemeTuruAdi,
                    Height = 35,
                    Width = 75
                };
                button.Click += OdemeEkle_Click;
                flowLayoutPanel1.Controls.Add(button);
            }
        }

        private void OdemeEkle_Click(object sender, EventArgs e)
        {
            var button = (sender as SimpleButton);
            KasaHareket entityKasaHareket = new KasaHareket
            {
                OdemeTuruKodu = button.Name, OdemeTuruAdi = button.Text, Tutar = txtOdenmesiGerekenTutar.Value
            };

            if (txtOdenmesiGerekenTutar.Value <= 0)
            {
                MessageBox.Show("Ödenmesi gereken tutar zaten ödenmiş durumdadır.");
            }
            else
            {
                kasaHareketDal.AddOrUpdate(context, entityKasaHareket);
                OdenenTutarGuncelle();
            }
        }

        private void OdenenTutarGuncelle()
        {
            gridKasaHareket.UpdateSummary();
            txtOdenenTutar.Value = Convert.ToDecimal(colTutar.SummaryItem.SummaryValue);
            txtOdenmesiGerekenTutar.Value = txtGenelToplam.Value - txtOdenenTutar.Value;
        }

        private void frmFisIslem_Load(object sender, EventArgs e)
        {

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
                if (entity != null)
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
            txtOdenmesiGerekenTutar.Value = txtGenelToplam.Value - txtOdenenTutar.Value;


        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtIskontoOrani_Validated(object sender, EventArgs e)
        {
            Toplamlar();
        }

        private void repoDepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmDepoSec form = new frmDepoSec(gridStokHareket.GetFocusedRowCellValue(colStokKodu).ToString());
            form.ShowDialog();
            if (form.secildi)
            {
                gridStokHareket.SetFocusedRowCellValue(colDepoKodu, form.entity.DepoKodu);
                gridStokHareket.SetFocusedRowCellValue(colDepoAdi, form.entity.DepoKodu);
            }
        }

        private void repoBirimFiyat_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string fiyatSecilen = gridStokHareket.GetFocusedRowCellValue(colStokKodu).ToString();
            Entities.Tables.Stok fiyatEntity = context.Stoklar.Where(c => c.StokKodu == fiyatSecilen).SingleOrDefault();

            barFiyat1.Tag = fiyatEntity.SatisFiyati1 ?? 0;
            barFiyat2.Tag = fiyatEntity.SatisFiyati2 ?? 0;
            barFiyat3.Tag = fiyatEntity.SatisFiyati3 ?? 0;

            barFiyat1.Caption = string.Format("{0:C2}", barFiyat1.Tag);
            barFiyat2.Caption = string.Format("{0:C2}", barFiyat2.Tag);
            barFiyat3.Caption = string.Format("{0:C2}", barFiyat3.Tag);

            radialFiyat.ShowPopup(MousePosition);
        }

        private void FiyatSec(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridStokHareket.SetFocusedRowCellValue(colBirimFiyat, Convert.ToDecimal(e.Item.Tag));
        }

        private void repoSeriNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string veri = Convert.ToString(gridStokHareket.GetFocusedRowCellValue(colSeriNo));
            fmrSeriNo form = new fmrSeriNo(veri);
            form.ShowDialog();
            gridStokHareket.SetFocusedRowCellValue(colSeriNo, form.veriSeriNo);
        }

        private void repoSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridStokHareket.DeleteSelectedRows();
            }
        }

        private void repoKasa_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmKasaSec form = new frmKasaSec();
            form.ShowDialog();
            if (form.secildi)
            {
                gridKasaHareket.SetFocusedRowCellValue(colKasaKodu, form.entity.KasaKodu);
                gridKasaHareket.SetFocusedRowCellValue(colKasaAdi, form.entity.KasaAdi);
            }
        }

        private void repoKHSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridKasaHareket.DeleteSelectedRows();
                OdenenTutarGuncelle();
            }
        }
    }
}