using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Entities.Tables.Other_Tables
{
    public class StokSec
    {
        public int Id { get; set; }
        public string StokAdi { get; set; }
        public string SeriNo { get; set; }
        public string Birimi { get; set; }
        public decimal Miktar { get; set; }
        public byte Gorsel { get; set; }
    }
}
