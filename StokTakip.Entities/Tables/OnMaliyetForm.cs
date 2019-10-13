using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip.Entities.Interfaces;

namespace StokTakip.Entities.Tables
{
    public class OnMaliyetForm : IEntity
    {
        public int Id { get; set; }
        public bool Durumu { get; set; }
        public string MusteriAdi { get; set; }
        public string DesenNo { get; set; }
        public string Makina { get; set; }
        public int SiparisNo { get; set; }
        public decimal BoyaGideri { get; set; }
        public string Profil { get; set; }
        public string KumasCinsiVeEni { get; set; }
        public string PassSayisi { get; set; }
        public string BaskiEni { get; set; }
        public string KagitCinsi { get; set; }
        public string Eni { get; set; }
        public string TransferHizi { get; set; }
        public Nullable<DateTime> SiparisTarihi { get; set; }
        public string TransferDerecesi { get; set; }
        public string IsTipi { get; set; }
        public string SiparisMiktari { get; set; }
        public string Pazarlamaci { get; set; }
        public string Desinator { get; set; }
        public string DesenGorseli { get; set; }
        public bool onayDurumu { get; set; }
        public string Aciklama { get; set; }
        public string Ozelkod1 { get; set; }
        public string OzelKod2 { get; set; }
    }
}
