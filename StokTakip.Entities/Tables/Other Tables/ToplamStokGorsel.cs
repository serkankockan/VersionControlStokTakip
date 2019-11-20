using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Entities.Tables.Other_Tables
{
    public class ToplamStokGorsel
    {
        public string StokAdi { get; set; }
        public string SeriNo { get; set; }
        public string Birim { get; set; }
        public decimal? Miktar { get; set; }
        public byte[] Gorsel { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string StokGrubu { get; set; }
    }
}
