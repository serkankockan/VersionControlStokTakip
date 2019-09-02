using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using DevExpress.XtraEditors;
using StokTakip.Entities.Tables.Other_Tables;

namespace StokTakip.BackOffice.Döviz_Kurları
{
    public partial class frmDovizKurlari : DevExpress.XtraEditors.XtraForm
    {
        public frmDovizKurlari()
        {
            InitializeComponent();

            FileInfo info = new FileInfo(Application.StartupPath + "\\Kurlar.xml");
            lblUyari.Text = "Son güncelleme tarihi : " +info.LastWriteTime.ToString();
        }

        private void frmDovizKurlari_Load(object sender, EventArgs e)
        {
            Guncelle(false);
        }

        private void Guncelle(bool indir = true)
        {

            if (indir)
            {
                using (WebClient kurIndir = new WebClient())
                {
                    kurIndir.DownloadFile("https://www.tcmb.gov.tr/kurlar/today.xml", Application.StartupPath + "\\Kurlar.xml");
                }
                lblUyari.Text = "Son güncelleme tarihi : " + DateTime.Now.ToString();
            }
            
            XElement kurlar = XElement.Load(Application.StartupPath + "\\Kurlar.xml");

            List<DovizKurlari> listKurlar = new List<DovizKurlari>();

            string ondalikKarakter = System.Globalization.CultureInfo.CurrentCulture.NumberFormat
                .CurrencyDecimalSeparator.ToString();

            int i = 0;
            foreach (var itemElement in kurlar.Elements().Where(c=> c.Attribute("CurrencyCode").Value != "XDR").ToList())
            {
                if (itemElement.Attribute("Kod").Value == "USD" || itemElement.Attribute("Kod").Value == "EUR")
                {
                    i++;
                }
                else
                {
                    i = 0;
                }

                listKurlar.Add(new DovizKurlari
                {
                    Sira = i,
                    CurrencyCode = itemElement.Attribute("CurrencyCode").Value,
                    Sembol = itemElement.Attribute("Kod").Value,
                    Isim = itemElement.Element("Isim").Value,
                    ForexBuying = Convert.ToDecimal(itemElement.Element("ForexBuying").Value.Replace(".",ondalikKarakter)),
                    ForexSelling = Convert.ToDecimal(itemElement.Element("ForexSelling").Value.Replace(".", ondalikKarakter)),
                    BanknoteBuying = itemElement.Element("BanknoteBuying").Value == "" ? 0 : Convert.ToDecimal(itemElement.Element("BanknoteBuying").Value.Replace(".", ondalikKarakter)),
                    BanknoteSelling = itemElement.Element("BanknoteSelling").Value == "" ? 0 : Convert.ToDecimal(itemElement.Element("BanknoteSelling").Value.Replace(".", ondalikKarakter))
                });
            }

            

            var sortedList = from sirala in listKurlar
                             orderby sirala.Sira descending
                select sirala; // sıra numarasına göre sırala

            
            gridControl1.DataSource = sortedList;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }
    }
}