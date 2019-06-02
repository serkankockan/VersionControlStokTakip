﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip.Entities.Interfaces;

namespace StokTakip.Entities.Tables
{
    public class Kasa : IEntity
    {
        public int Id { get; set; }

        public string KasaKodu { get; set; }

        public string KasaAdi { get; set; }

        public string YetkiliKodu { get; set; }

        public string YetkiliAdi { get; set; }

        public string Aciklama { get; set; }

    }
}
