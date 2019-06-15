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
        public object OdemeTuruListele(StokTakipContext context)
        {
            var result = context.OdemeTurleri.GroupJoin(context.KasaHareketleri, c => c.OdemeTuruKodu, c => c.OdemeTuruKodu,
                (odemeturu, kasahareket) => new
                {
                    odemeturu.Id,
                    odemeturu.OdemeTuruKodu,
                    odemeturu.OdemeTuruAdi,
                    odemeturu.Aciklama,
                    KasaGiris = (kasahareket.Where(c => c.OdemeTuruKodu == odemeturu.OdemeTuruKodu && c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0),
                    KasaCikis = (kasahareket.Where(c => c.OdemeTuruKodu == odemeturu.OdemeTuruKodu && c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0),
                    Bakiyet = (kasahareket.Where(c => c.OdemeTuruKodu == odemeturu.OdemeTuruKodu && c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0) - (kasahareket.Where(c => c.OdemeTuruKodu == odemeturu.OdemeTuruKodu && c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0)
                }).ToList();
            return result;
        }

        public object KasaToplamListele(StokTakipContext context, string odemeTuruKodu)
        {
            var result = (from c in context.KasaHareketleri.Where(c => c.OdemeTuruKodu == odemeTuruKodu)
                          group c by new
                          { c.KasaKodu, c.KasaAdi }
                into grp
                          select new
                          {
                              grp.Key.KasaKodu,
                              grp.Key.KasaAdi,
                              KasaGiris = (grp.Where(c => c.KasaKodu == grp.Key.KasaKodu && c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0),
                              KasaCikis = (grp.Where(c => c.KasaKodu == grp.Key.KasaKodu && c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0),
                              Bakiye = (grp.Where(c => c.KasaKodu == grp.Key.KasaKodu && c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0) -
                                       (grp.Where(c => c.KasaKodu == grp.Key.KasaKodu && c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0)
                          }).ToList();
            return result;
        }

        public object GenelToplamListele(StokTakipContext context, string odemeTuruKodu)
        {
            decimal KasaGiris = context.KasaHareketleri.Where(c => c.OdemeTuruKodu == odemeTuruKodu && c.Hareket == "Kasa Giriş")
                                    .Sum(c => c.Tutar) ?? 0;

            int KasaGirisKayitSayisi = context.KasaHareketleri
                .Where(c => c.OdemeTuruKodu == odemeTuruKodu && c.Hareket == "Kasa Giriş").Count();


            decimal KasaCikis = context.KasaHareketleri.Where(c => c.OdemeTuruKodu == odemeTuruKodu && c.Hareket == "Kasa Çıkış")
                                    .Sum(c => c.Tutar) ?? 0;

            int KasaCikisKayitSayisi = context.KasaHareketleri
                .Where(c => c.OdemeTuruKodu == odemeTuruKodu && c.Hareket == "Kasa Çıkış").Count();

            List<GenelToplam> genelToplamlar = new List<GenelToplam>()
            {
                new GenelToplam
                {
                    Bilgi = "Kasa Giriş",
                    KayitSayisi = KasaGirisKayitSayisi,
                    Tutar = KasaGiris
                },
                new GenelToplam
                {
                    Bilgi = "Kasa Çıkış",
                    KayitSayisi = KasaCikisKayitSayisi,
                    Tutar = KasaCikis
                },
                new GenelToplam
                {
                    Bilgi = "Bakiye",
                    KayitSayisi = KasaGirisKayitSayisi + KasaCikisKayitSayisi,
                    Tutar = KasaGiris - KasaCikis
                }
            };
            return genelToplamlar;
        }

    }
}
