using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip.Entities.Interfaces;

namespace StokTakip.Entities.Tables
{
    public class SiparisFormlari: IEntity
    {
        public int id { get; set; }

        public string UrunAdi { get; set; }
        public string UrunKodu { get; set; }

        public string UreticiAdi { get; set; }
        public string UreticiKodu { get; set; }

        public string Hareket { get; set; }
        public string Birimi { get; set; }
        public Nullable<decimal> Miktar { get; set; }
        public string StokKodu { get; set; }
        public string StokAdi { get; set; }

        public string FormOnayDurumu { get; set; }

        public int AlisKDV { get; set; }
        public Nullable<decimal> BirimFiyat { get; set; }

        public string DepoKodu { get; set; }
        public string DepoAdi { get; set; }
        public Nullable<DateTime> Tarih { get; set; }

        public string Aciklama { get; set; }
    }
}
