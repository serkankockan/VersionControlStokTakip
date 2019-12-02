using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip.Entities.Interfaces;

namespace StokTakip.Entities.Tables
{
    public class SatinAlmaTalepForm : IEntity
    {
        public int Id { get; set; }
        public string FormNo { get; set; }
        public bool Durumu { get; set; }
        public string PersonelNo { get; set; }
        public string PersonelAdi { get; set; }
        public string PersonelSoyadi { get; set; }
        public string Aciklama { get; set; }
    }
}