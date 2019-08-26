using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using StokTakip.BackOffice.Cari;
using StokTakip.BackOffice.Depo;
using StokTakip.BackOffice.Kasa;
using StokTakip.BackOffice.Stok;
using StokTakip.Entities.Context;
using StokTakip.Entities.Data_Access;
using StokTakip.Entities.Tables;
using StokTakip.Entities.Tables.Other_Tables;


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
        FisAyarlari ayarlar = new FisAyarlari();
        Entities.Tables.Fis _fisentity = new Entities.Tables.Fis();
        CariBakiye entityBakiye = new CariBakiye();

        public frmFisIslem(string fisKodu=null, string fisTuru=null)
        {
            InitializeComponent();

            if (fisKodu!=null)
            {
                _fisentity = context.Fisler.Where(c => c.FisKodu == fisKodu).SingleOrDefault();
                context.StokHareketleri.Where(c=>c.FisKodu == fisKodu).Load();
                context.KasaHareketleri.Where(c => c.FisKodu == fisKodu).Load();
                toggleBakiyeTuru.IsOn =
                    context.KasaHareketleri.Count(c => c.FisKodu == fisKodu && c.Hareket == "Kasa Giriş") == 0;


                if (_fisentity.CariKodu != null)
                {
                    entityBakiye = this.cariDal.CariBakiyesi(context, _fisentity.CariKodu);
                    lblAlacak.Text = entityBakiye.Alacak.ToString("C2");
                    lblBorc.Text = entityBakiye.Borc.ToString("C2");
                    lblBakiye.Text = entityBakiye.Bakiye.ToString("C2");
                }

            }
            else // yeni bir fiş oluşturuluyorsa
            {
                _fisentity.FisTuru = fisTuru;
                _fisentity.Tarih = DateTime.Now;
            }
            
            txtFisKodu.DataBindings.Add("Text", _fisentity, "FisKodu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtFisTuru.DataBindings.Add("Text", _fisentity, "FisTuru", false, DataSourceUpdateMode.OnPropertyChanged);
            cmbTarih.DataBindings.Add("EditValue", _fisentity, "Tarih", false, DataSourceUpdateMode.OnPropertyChanged,DateTime.Now);
            txtBelgeNo.DataBindings.Add("Text", _fisentity, "BelgeNo", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAciklama.DataBindings.Add("Text", _fisentity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
            lblCariKodu.DataBindings.Add("Text", _fisentity, "CariKodu", false, DataSourceUpdateMode.OnPropertyChanged);
            lblCariAdi.DataBindings.Add("Text", _fisentity, "CariAdi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtFaturaUnvani.DataBindings.Add("Text", _fisentity, "FaturaUnvani", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCepTelefonu.DataBindings.Add("Text", _fisentity, "CepTelefonu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtIl.DataBindings.Add("Text", _fisentity, "Il", false, DataSourceUpdateMode.OnPropertyChanged);
            txtIlce.DataBindings.Add("Text", _fisentity, "Ilce", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSemt.DataBindings.Add("Text", _fisentity, "Semt", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAdres.DataBindings.Add("Text", _fisentity, "Adres", false, DataSourceUpdateMode.OnPropertyChanged);
            txtVergiDairesi.DataBindings.Add("Text", _fisentity, "VergiDairesi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtVergiNo.DataBindings.Add("Text", _fisentity, "VergiNo", false, DataSourceUpdateMode.OnPropertyChanged);

            gridContStokHareket.DataSource = context.StokHareketleri.Local.ToBindingList();
            gridContKasaHareket.DataSource = context.KasaHareketleri.Local.ToBindingList();
            fisAyari();
            Toplamlar();
            OdenenTutarGuncelle();
            ButonlariYukle();
        }

        private void ButonlariYukle()
        {
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

            var personelSecimIptal = new CheckButton
            {
                Name = "Yok",
                Text = "Yok",
                GroupIndex = 1,
                Height = 35,
                Width = 75,
                Checked = _fisentity.PlasiyerKodu==null
                
            };
            personelSecimIptal.Click += PersonelYukle_Click;
            flowPersonel.Controls.Add(personelSecimIptal);

            foreach (var item in context.Personeller.ToList())
            {
                var button = new CheckButton
                {
                    Name = item.PersonelKodu,
                    Text = item.PersonelAdi,
                    Checked = item.PersonelKodu==_fisentity.PlasiyerKodu,
                    GroupIndex = 1,
                    Height = 35,
                    Width = 75
                };
                button.Click += PersonelYukle_Click;
                flowPersonel.Controls.Add(button);
            }
        }

        private void PersonelYukle_Click(object sender, EventArgs e)
        {
            var button = sender as CheckButton;

            if (button.Name == "Yok")
            {
                _fisentity.PlasiyerKodu = null;
                _fisentity.PlasiyerAdi = null;
            }
            else
            {
                _fisentity.PlasiyerKodu = button.Name;
                _fisentity.PlasiyerAdi = button.Text;
            }

            
        }

        private void fisAyari()
        {

            switch (_fisentity.FisTuru)
            {
                case "Alış Faturası":
                    ayarlar.StokHareketi = "Stok Giriş";
                    ayarlar.KasaHareketi = "Kasa Çıkış";
                    ayarlar.OdemeEkrani = true;
                    ayarlar.SatisEkrani = true;
                    lblBaslik.Appearance.ImageIndex = 0;
                    break;

                case "Perakende Satış Faturası":
                    ayarlar.StokHareketi = "Stok Çıkış";
                    ayarlar.KasaHareketi = "Kasa Giriş";
                    ayarlar.OdemeEkrani = true;
                    ayarlar.SatisEkrani = true;
                    lblBaslik.Appearance.ImageIndex = 1;
                    break;

                case "Toptan Satış Faturası":
                    ayarlar.StokHareketi = "Stok Çıkış";
                    ayarlar.KasaHareketi = "Kasa Giriş";
                    ayarlar.OdemeEkrani = true;
                    ayarlar.SatisEkrani = true;
                    lblBaslik.Appearance.ImageIndex = 2;
                    break;

                case "Alış İade Faturası":
                    ayarlar.StokHareketi = "Stok Çıkış";
                    ayarlar.KasaHareketi = "Kasa Giriş";
                    ayarlar.OdemeEkrani = true;
                    ayarlar.SatisEkrani = true;
                    lblBaslik.Appearance.ImageIndex = 3;
                    break;

                case "Satış İade Faturası":
                    ayarlar.StokHareketi = "Stok Giriş";
                    ayarlar.KasaHareketi = "Kasa Çıkış";
                    ayarlar.OdemeEkrani = true;
                    ayarlar.SatisEkrani = true;
                    lblBaslik.Appearance.ImageIndex = 4;
                    break;

                case "Sayım Fazlası Fişi":
                    ayarlar.StokHareketi = "Stok Giriş";
                    lblBaslik.Appearance.ImageIndex = 5;
                    ayarlar.OdemeEkrani = false;
                    ayarlar.SatisEkrani = true;
                    panelOdeme.Visible = false;
                    navOdemeEkrani.Dispose();
                    navCariBilgi.Dispose();
                    break;

                case "Sayım Eksiği Fişi":
                    ayarlar.StokHareketi = "Stok Çıkış";
                    lblBaslik.Appearance.ImageIndex = 6;
                    ayarlar.OdemeEkrani = false;
                    ayarlar.SatisEkrani = true;
                    panelOdeme.Visible = false;
                    navOdemeEkrani.Dispose();
                    navCariBilgi.Dispose();
                    break;

                case "Stok Devir Fişi":
                    ayarlar.StokHareketi = "Stok Giriş";
                    lblBaslik.Appearance.ImageIndex = 7;
                    ayarlar.OdemeEkrani = false;
                    ayarlar.SatisEkrani = true;
                    panelOdeme.Visible = false;
                    navOdemeEkrani.Dispose();
                    navCariBilgi.Dispose();
                    break;


                case "Tahsilat Fişi":
                    ayarlar.KasaHareketi = "Kasa Giriş";
                    ayarlar.OdemeEkrani = true;
                    ayarlar.SatisEkrani = false;
                    navSatisEkrani.Dispose();
                    navigationPane2.SelectedPage = navOdemeEkrani;
                    panelOdeme.Visible = false;
                    panelIskonto.Visible = false;
                    panelKDV.Visible = false;
                    grpToplamlar.Height = 98;
                    panelToplam.Top = 32;
                    break;


                case "Ödeme Fişi":
                    ayarlar.KasaHareketi = "Kasa Çıkış";
                    ayarlar.OdemeEkrani = true;
                    ayarlar.SatisEkrani = false;
                    panelOdeme.Visible = false;
                    panelIskonto.Visible = false;
                    panelKDV.Visible = false;
                    navSatisEkrani.Dispose();
                    navigationPane2.SelectedPage = navOdemeEkrani;
                    grpToplamlar.Height = 98;
                    panelToplam.Top = 32;
                    break;

                //Bu alana daha sonra bakılacak

                case "Cari Devir Fişi":
                    ayarlar.KasaHareketi = "Kasa Giriş";
                    ayarlar.OdemeEkrani = true;
                    ayarlar.SatisEkrani = false;
                    panelOdeme.Visible = false;
                    panelIskonto.Visible = false;
                    panelKDV.Visible = false;
                    panelCariDevir.Visible = true;
                    txtFisKodu.Width = 117;
                    navSatisEkrani.Dispose();
                    navigationPane2.SelectedPage = navOdemeEkrani;
                    grpToplamlar.Height = 98;
                    panelToplam.Top = 32;
                    break;
            }
        }

        private void OdemeEkle_Click(object sender, EventArgs e)
        {

            var button = (sender as SimpleButton);
            if (ayarlar.SatisEkrani==false)
            {
                frmOdemeEkrani form = new frmOdemeEkrani(button.Text,button.Name);
                form.ShowDialog();

                if (form.entity!=null)
                {
                    kasaHareketDal.AddOrUpdate(context, form.entity);
                    OdenenTutarGuncelle();
                }
            }
            else
            {
                if (txtOdenmesiGerekenTutar.Value <= 0)
                {
                    MessageBox.Show("Ödenmesi gereken tutar zaten ödenmiş durumdadır.");
                }
                else
                {
                    KasaHareket entityKasaHareket = new KasaHareket
                    {
                        OdemeTuruKodu = button.Name,
                        OdemeTuruAdi = button.Text,
                        Tutar = txtOdenmesiGerekenTutar.Value
                    };

                    kasaHareketDal.AddOrUpdate(context, entityKasaHareket);
                    OdenenTutarGuncelle();
                }
            }
        }

        private void OdenenTutarGuncelle()
        {
            gridKasaHareket.UpdateSummary();


            if (ayarlar.SatisEkrani)
            {
                txtOdenenTutar.Value = Convert.ToDecimal(colTutar.SummaryItem.SummaryValue);
                txtOdenmesiGerekenTutar.Value = txtGenelToplam.Value - txtOdenenTutar.Value;
            }
            else
            {
                txtGenelToplam.Value = Convert.ToDecimal(colTutar.SummaryItem.SummaryValue);
            }
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
            stokHareket.BirimFiyat = txtFisTuru.Text == "Alış Faturası" ? entity.AlisFiyati1 : entity.SatisFiyati1;
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
            if (gridStokHareket.RowCount != 0)
            {
                if(MessageBox.Show("Satış ekranına eklenmiş ürünler var. Bu işlemi iptal edip formu " + 
                                   "kapatmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
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

            barFiyat1.Tag = txtFisTuru.Text == "Alış Faturası" ? fiyatEntity.AlisFiyati1 ?? 0 : fiyatEntity.SatisFiyati1 ?? 0;
            barFiyat2.Tag = txtFisTuru.Text == "Alış Faturası" ? fiyatEntity.AlisFiyati2 ?? 0 : fiyatEntity.SatisFiyati2 ?? 0;
            barFiyat3.Tag = txtFisTuru.Text == "Alış Faturası" ? fiyatEntity.AlisFiyati3 ?? 0 : fiyatEntity.SatisFiyati3 ?? 0;

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
                Toplamlar();
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

        private void btnIslemiKaydet_Click(object sender, EventArgs e)
        {

            if (toggleBakiyeTuru.IsOn)
            {
                ayarlar.KasaHareketi = "Kasa Çıkış";
            }
            else
            {
                ayarlar.KasaHareketi = "Kasa Giriş";
            }

            int StokHata = context.StokHareketleri.Local.Where(c => c.DepoKodu == null).Count();
            int KasaHata = context.KasaHareketleri.Local.Where(c => c.KasaKodu == null).Count();

            string message = null;
            int hata = 0;

            if (gridStokHareket.RowCount == 0 && ayarlar.SatisEkrani == true)
            {
                message += "Satış ekranında eklenmiş bir ürün bulunamadı." + System.Environment.NewLine;
                hata++;
            }

            if (_fisentity.CariKodu==null && ayarlar.SatisEkrani==false)
            {
                message += txtFisTuru.Text + "türünde cari seçimi zorunludur." + System.Environment.NewLine;
                hata++;
            }

            if (gridKasaHareket.RowCount== 0 && ayarlar.SatisEkrani == false)
            {
                message += "Herhangi bir ödeme bulunamadı." + System.Environment.NewLine;
                hata++;
            }

            if (txtFisKodu.Text == "") //fiş kodunu almıyor. Refresh edilmesi gerekiyor.
            {
                message += "Fiş Kodu alanı boş geçilemez." + System.Environment.NewLine;
                hata++;
            }

            if (txtFisKodu.Text == null)
            {
                message += "Fiş Kodu alanı boş geçilemez." + System.Environment.NewLine;
                hata++;
            }

            if (txtOdenmesiGerekenTutar.Value != 0 && ayarlar.OdemeEkrani == true)
            {
                message += "Ödenmesi gereken tutar ödenmemiş görünüyor." + System.Environment.NewLine;
                hata++;
            }

            if (StokHata != 0)
            {
                message += "Satış ekranındaki ürünlerin Depo seçimlerinde eksiklikler var." + System.Environment.NewLine;
                hata++;
            }

            if (KasaHata != 0)
            {
                message += "Ödeme ekranındaki ödemelerin Kasa seçimlerinde eksiklikler var.";
                hata++;
            }

            if (hata!=0)
            {
                MessageBox.Show(message);
                return;
            }

            foreach (var stokVeri in context.StokHareketleri.Local.ToList())
            {
                stokVeri.Tarih = stokVeri.Tarih == null
                    ? Convert.ToDateTime(cmbTarih.DateTime)
                    : Convert.ToDateTime(stokVeri.Tarih);
                stokVeri.FisKodu = txtFisKodu.Text;
                stokVeri.Hareket = ayarlar.StokHareketi;
            }

            if (ayarlar.OdemeEkrani)
            {
                foreach (var kasaVeri in context.KasaHareketleri.Local.ToList())
                {
                    kasaVeri.Tarih = kasaVeri.Tarih == null
                        ? Convert.ToDateTime(cmbTarih.DateTime)
                        : Convert.ToDateTime(kasaVeri.Tarih);
                    kasaVeri.FisKodu = txtFisKodu.Text;
                    kasaVeri.Hareket = ayarlar.KasaHareketi;
                    kasaVeri.CariKodu = lblCariKodu.Text;
                    kasaVeri.CariAdi = lblCariAdi.Text;
                }
            }

            _fisentity.ToplamTutar = txtGenelToplam.Value;
            _fisentity.IskontoOrani = txtIskontoOrani.Value;
            _fisentity.IskontoTutar = txtIskontoTutar.Value;

            fisDal.AddOrUpdate(context, _fisentity);

            context.SaveChanges();

            this.Close();
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {

        }
    }
}