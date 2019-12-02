using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Entities.Tables
{
    public class FormUrunBilgi
    {
        public int Id { get; set; }
        public string FormNo { get; set; }
        public string Urun { get; set; }
        public string Miktar { get; set; }
        public string Tahsis { get; set; }
        public string Amaci { get; set; }
        public bool Sozlesme { get; set; }
        public string UrunAciklama { get; set; }
    }
}
