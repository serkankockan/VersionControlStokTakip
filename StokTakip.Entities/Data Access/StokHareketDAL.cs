using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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

        public object DepoStokListele(StokTakipContext context, string depoKodu)
        {
            var tablo = context.Stoklar.GroupJoin(context.StokHareketleri.Where(c=> c.DepoKodu == depoKodu), c => c.StokKodu, c => c.StokKodu,
                (Stoklar, StokHareketleri) => new
                {
                    Stoklar.StokAdi,
                    Stoklar.Barkod,
                    StokGiris = StokHareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0,
                    StokCikis = StokHareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0,
                    MevcutStok = StokHareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) -
                                 StokHareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0
                }).ToList();
            return tablo;
        }

        public object DepoIstatistikListele(StokTakipContext context, string depoKodu)
        {
            List<GenelToplam> genelToplamlar = new List<GenelToplam>()
            {
                new GenelToplam
                {
                    Bilgi = "Stok Giriş",
                    KayitSayisi = context.StokHareketleri.Where(c=>c.DepoKodu == depoKodu && c.Hareket=="Stok Giriş").Count(),
                    Tutar = context.StokHareketleri.Where(c=>c.DepoKodu == depoKodu && c.Hareket == "Stok Giriş").Sum(c=>c.Miktar) ?? 0
                },
                new GenelToplam
                {
                    Bilgi = "Stok Giriş",
                    KayitSayisi = context.StokHareketleri.Where(c=>c.DepoKodu == depoKodu && c.Hareket=="Stok Çıkış").Count(),
                    Tutar = context.StokHareketleri.Where(c=>c.DepoKodu == depoKodu && c.Hareket == "Stok Çıkış").Sum(c=>c.Miktar) ?? 0
                },
            };
            return genelToplamlar;
        }

        public object KonumStoklari(StokTakipContext context, string konum)
        {
            /*context.StokHareketleri.Where(s => s.Konum == konum).ToList();*/

            var result = (from sh in context.StokHareketleri.Where(s=>s.Konum==konum)
                join s in context.Stoklar on sh.StokKodu equals s.StokKodu
                select new
                {
                    sh.StokAdi,
                    sh.SeriNo,
                    sh.Birimi,
                    sh.Miktar,
                    s.Gorsel
                }).ToList();
            return result;
        }

        public object KonumsuzStoklar(StokTakipContext context)
        {
            var result = context.StokHareketleri.Where(c => c.Konum == null || c.Konum == "").ToList();
            return result;
        }


        //public object KonumlarDuzenle(StokTakipContext context, string depoKodu)
        //{
        //    var KonumListele = context.StokHareketleri.Where()
        //}

    }
}
