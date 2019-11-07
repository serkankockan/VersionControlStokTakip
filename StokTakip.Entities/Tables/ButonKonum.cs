using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip.Entities.Interfaces;

namespace StokTakip.Entities.Tables
{
    public class ButonKonum : IEntity
    {

        public int Id { get; set; }

        public bool Durumu { get; set; }

        public string Turu { get; set; } //Buton özelliklerini alır.

        public int TurKodu { get; set; }

        public string Size { get; set; }

        public Nullable<int> X { get; set; } // Mevcut buton konumunu alır.

        public Nullable<int> Y { get; set; } // Mevcut buton konumunu alır.

        public string KonumAdi { get; set; } // Kullanıcı ve cihazları birleştirir.

        public string Aciklama { get; set; }

        public string BarkodNo { get; set; }

        public string BarkodTipi { get; set; }

    }
}
