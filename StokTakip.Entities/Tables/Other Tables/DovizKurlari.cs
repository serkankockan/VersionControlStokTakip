using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Entities.Tables.Other_Tables
{
    public class DovizKurlari
    {
        public int Sira { get; set; }

        public string CurrencyCode { get; set; }

        public string Sembol { get; set; }

        public string Isim { get; set; }

        public decimal ForexBuying { get; set; }

        public decimal ForexSelling { get; set; }

        public decimal BanknoteBuying { get; set; }

        public decimal BanknoteSelling { get; set; }
    }
}
