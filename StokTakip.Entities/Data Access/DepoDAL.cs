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
    public class DepoDAL : EntityRepositoryBase<StokTakipContext, Depo,DepoValidator>
    {
        public object DepoBazindaStokListele(StokTakipContext context, string stokKodu)
        {
            var result = context.Depolar.GroupJoin(context.StokHareketleri.Where(c => c.StokKodu == stokKodu),
                c => c.DepoKodu, c => c.DepoKodu, (depolar, stokhareketleri) => new
                {
                    depolar.Id,
                    depolar.DepoKodu,
                    depolar.DepoAdi,
                    depolar.YetkiliKodu,
                    depolar.YetkiliAdi,
                    depolar.Telefon,
                    depolar.Il,
                    depolar.Ilce,
                    depolar.Semt,
                    depolar.Adres,
                    StokGiris = stokhareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0,
                    StokCikis = stokhareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0,
                    MevcutStok = (stokhareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ??
                                  0) - (stokhareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0)
                }).ToList();
            return result;
        }
    }
}
