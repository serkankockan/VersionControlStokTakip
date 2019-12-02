using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip.Entities.Interfaces;

namespace StokTakip.Entities.Tables
{
    public class FormFirmaBilgi : IEntity
    {
        public int Id { get; set; }
        public string FormNo { get; set; }
        public string Firma { get; set; }
        public string Doviz { get; set; }
        public Nullable<decimal> Fiyat { get; set; }
        public string TeklifAciklama { get; set; }
    }
}