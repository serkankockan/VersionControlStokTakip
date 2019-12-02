using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip.Entities.Context;
using StokTakip.Entities.Repositories;
using StokTakip.Entities.Tables;
using StokTakip.Entities.Validations;

namespace StokTakip.Entities.Data_Access
{
    public class ButonTanimDAL : EntityRepositoryBase<StokTakipContext, ButonTanim, ButonTanimValidator>
    {
        public object AraclarButonlari(StokTakipContext context)
        {
            var result = context.ButonTanimlar.Select(x => x).ToList();
            return result;
        }

        public object AracTanimlariListele(StokTakipContext context,int secim)
        {
            var result = context.ButonTanimlar.First(c => c.Id == secim);
            return result;
        }

        public Stream ResimGetir(StokTakipContext context, int konumId)
        {
            var resim = context.ButonTanimlar.Where(c => c.Id == konumId).SingleOrDefault();
            Stream stream = new MemoryStream(resim.Gorsel);
            return stream;
        }
    }
}
