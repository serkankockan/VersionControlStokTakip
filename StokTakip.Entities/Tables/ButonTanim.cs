using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip.Entities.Interfaces;

namespace StokTakip.Entities.Tables
{
    public class ButonTanim : IEntity
    {
        public int Id { get; set; }

        public bool Durumu { get; set; }

        public string Turu { get; set; }

        public bool TuruTF { get; set; }
        
        public string Size { get; set; }

        public Nullable<int> X { get; set; }

        public Nullable<int> Y { get; set; }

        public Nullable<int> Width { get; set; }

        public Nullable<int> Height { get; set; }

        public string Aciklama { get; set; }

        //Group Panel Özellikleri
        public Nullable<int> GroupWidth { get; set; }

        public Nullable<int> GroupHeight { get; set; }

        //FlowLayout Özellikleri
        public Nullable<int> FlowWidth { get; set; }

        public Nullable<int> FlowHeight { get; set; }

        public bool FlowVisible { get; set; }

        public string FlowDock { get; set; }

        //SimpleButton Özellikleri

        public string SimpleDock { get; set; }

        public string SimpleArkaPlanRengi { get; set; }

        public string SimpleKenarRengi { get; set; }

    }
}
