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
    public class OdemeTuruDAL : EntityRepositoryBase<StokTakipContext, OdemeTuru,OdemeTuruValidator>
    {
        public object KasaListele(StokTakipContext context)
        {
            var result = context.OdemeTurleri.GroupJoin(context.KasaHareketleri, c => c.OdemeTuruKodu, c => c.OdemeTuruKodu,
                (odemeturu, kasahareket) => new
                {
                    odemeturu.Id,
                    odemeturu.OdemeTuruKodu,
                    odemeturu.OdemeTuruAdi,
                    odemeturu.Aciklama,
                    

                    KasaGiris = (kasahareket.Where(c => c.KasaKodu == kasa.KasaKodu && c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0),
                    KasaCikis = (kasahareket.Where(c => c.KasaKodu == kasa.KasaKodu && c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0),
                    Bakiyet = (kasahareket.Where(c => c.KasaKodu == kasa.KasaKodu && c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0) - (kasahareket.Where(c => c.KasaKodu == kasa.KasaKodu && c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0)
                }).ToList();
            return result;
        }
    }
}
