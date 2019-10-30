using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip.Entities.Interfaces;

namespace StokTakip.Entities.Tables
{
    public class BoyaliKumasMaliyet : IEntity
    {
        public int Id { get; set; }
        public bool Durumu { get; set; }
        public string MusteriAdi { get; set; }
        public string KumasCinsi { get; set; }
        public string IplikCinsi { get; set; }
        public decimal BirimFiyati { get; set; }
        public string DovizCinsi { get; set; }
        public decimal TLFiyat { get; set; }
        public int IplikOrani { get; set; }
        public int IplikFiyat { get; set; }
        public decimal IplikToplamOran { get; set; }
        public decimal IplikToplam { get; set; }

        public Nullable<DateTime> SiparisTarihi { get; set; }
    }
}