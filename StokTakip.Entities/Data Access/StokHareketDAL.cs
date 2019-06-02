using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip.Entities.Context;
using StokTakip.Entities.Repositories;
using StokTakip.Entities.Tables;
using StokTakip.Entities.Validations;

namespace StokTakip.Entities.Data_Access
{
    public class StokHareketDAL : EntityRepositoryBase<StokTakipContext, StokHareket, StokHareketValidator>
    {
        public object GetGenelStok(StokTakipContext context, string stokKodu)
        {
            var result = (from c in context.StokHareketleri.Where(c => c.StokKodu == stokKodu)
                group c by new { c.Hareket }
                into g
                select new
                {
                    Bilgi = g.Key.Hareket,
                    KayitSayisi = g.Count(),
                    Toplam = g.Sum(c => c.Miktar)
                }).ToList();
            return result;
        }

        public object GetDepoStok(StokTakipContext context, string stokKodu)
        {
            var result = context.Depolar.GroupJoin(context.StokHareketleri.Where(c => c.StokKodu == stokKodu),
                c => c.DepoKodu, c => c.DepoKodu, (depolar, stokhareketleri) => new
                {
                    depolar.DepoKodu,
                    depolar.DepoAdi,
                    StokGiris = stokhareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0,
                    StokCikis = stokhareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0,
                    MevcutStok = (stokhareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ??
                                  0) - (stokhareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0)
                }).ToList();
            return result;
        }
    }
}
