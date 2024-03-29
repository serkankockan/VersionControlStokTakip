﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip.Entities.Interfaces;

namespace StokTakip.Entities.Tables
{
    public class StokHareket : IEntity
    {
        public int Id { get; set; }

        public string FisKodu { get; set; }

        public string Hareket { get; set; }

        public string StokKodu { get; set; }

        public string StokAdi { get; set; }

        public string BarkodTuru { get; set; }

        public string Barkod { get; set; }

        public string Birimi { get; set; }

        public Nullable<decimal> Miktar { get; set; }

        public int KDV { get; set; }

        public string DovizCinsi { get; set; }

        public Nullable<decimal> BirimFiyat { get; set; }

        public Nullable<decimal> IndirimOrani { get; set; }

        //public Nullable<decimal> IndirimTutari { get; set; } Silindi

        //public Nullable<decimal> ToplamTutar { get; set; } Silindi

        public string DepoKodu { get; set; }

        public string DepoAdi { get; set; }

        public string SeriNo { get; set; }

        public Nullable<DateTime> Tarih { get; set; }

        public string Aciklama { get; set; }

        public string Konum { get; set; }

        public string KonumKodu { get; set; }

        public string BirimKodu { get; set; }

        public string BirimAdi { get; set; }

        [NotMapped]
        public bool Flag { get; set; }

        [NotMapped]
        public byte[] Resim { get; set; }
    }
}
