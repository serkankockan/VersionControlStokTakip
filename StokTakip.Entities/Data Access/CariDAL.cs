using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using StokTakip.Entities.Context;
using StokTakip.Entities.Interfaces;
using StokTakip.Entities.Repositories;
using StokTakip.Entities.Tables;
using StokTakip.Entities.Validations;

namespace StokTakip.Entities.Data_Access
{
    public class CariDAL : EntityRepositoryBase<StokTakipContext, Cari, CariValidator>
    {

        public object GetCariler(StokTakipContext context)
        {

            var result = context.Cariler.GroupJoin(context.Fisler, c => c.CariKodu, c => c.CariKodu,
                (cariler, fisler) => new
                {
                    cariler.Id,
                    cariler.Durumu,
                    cariler.CariKodu,
                    cariler.CariAdi,
                    cariler.CariTuru,
                    cariler.YetkiliKisi,
                    cariler.FaturaUnvani,
                    cariler.CepTelefonu,
                    cariler.Telefon,
                    cariler.Fax,
                    cariler.EMail,
                    cariler.Web,
                    cariler.Il,
                    cariler.Ilce,
                    cariler.Semt,
                    cariler.Adres,
                    cariler.CariGrubu,
                    cariler.CariAltGrubu,
                    cariler.OzelKod1,
                    cariler.OzelKod2,
                    cariler.OzelKod3,
                    cariler.OzelKod4,
                    cariler.VergiNo,
                    cariler.VergiDairesi,
                    cariler.IskontoOrani,
                    cariler.RiskLimiti,
                    cariler.AlisOzelFiyati,
                    cariler.SatisOzelFiyati,
                    cariler.Aciklama,

                    AlisToplam = fisler.Where(c => c.FisTuru == "Alış Fişi").Sum(c => c.ToplamTutar) ?? 0,
                    SatisToplam = fisler.Where(c => c.FisTuru == "Satış Fişi").Sum(c => c.ToplamTutar) ?? 0
                }).GroupJoin(context.KasaHareketleri, c => c.CariKodu, c => c.CariKodu, (cariler, kasahareket) => new
                {
                    cariler.Id,
                    cariler.Durumu,
                    cariler.CariKodu,
                    cariler.CariAdi,
                    cariler.CariTuru,
                    cariler.YetkiliKisi,
                    cariler.FaturaUnvani,
                    cariler.CepTelefonu,
                    cariler.Telefon,
                    cariler.Fax,
                    cariler.EMail,
                    cariler.Web,
                    cariler.Il,
                    cariler.Ilce,
                    cariler.Semt,
                    cariler.Adres,
                    cariler.CariGrubu,
                    cariler.CariAltGrubu,
                    cariler.OzelKod1,
                    cariler.OzelKod2,
                    cariler.OzelKod3,
                    cariler.OzelKod4,
                    cariler.VergiNo,
                    cariler.VergiDairesi,
                    cariler.IskontoOrani,
                    cariler.RiskLimiti,
                    cariler.AlisOzelFiyati,
                    cariler.SatisOzelFiyati,
                    cariler.Aciklama,
                    Alacak =
                    cariler.AlisToplam + (kasahareket.Where(c => c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0),
                    Borc = cariler.AlisToplam + (kasahareket.Where(c => c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0),
                    Bakiye = (cariler.AlisToplam +
                          (kasahareket.Where(c => c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0))
                         -
                         (cariler.AlisToplam + (kasahareket.Where(c => c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0))
                }).ToList();

            return result;
        }

        public object CariFisAyrinti(StokTakipContext context, string cariKodu)
        {
            var result = context.Fisler.Where(c => c.CariKodu == cariKodu).GroupJoin(
                context.KasaHareketleri.Where(c => c.CariKodu == cariKodu), c => c.CariKodu, c => c.CariKodu,
                (fisler, kasahareket) => new
                {
                    fisler.Id,
                    fisler.FisKodu,
                    fisler.FisTuru,
                    fisler.PlasiyerKodu,
                    fisler.PlasiyerAdi,
                    fisler.BelgeNo,
                    fisler.Tarih,
                    fisler.IskontoOrani,
                    fisler.IskontoTutar,
                    fisler.Aciklama,
                    fisler.ToplamTutar,
                    Odenen = context.KasaHareketleri.Sum(c => c.Tutar) ?? 0,
                    KalanOdeme = fisler.ToplamTutar - context.KasaHareketleri.Sum(c => c.Tutar) ?? 0
                }).ToList();

            return result;
        }

        public object CariFisGenelToplam(StokTakipContext context, string cariKodu)
        {
            var result = (from c in context.Fisler.Where(c => c.CariKodu == cariKodu)
                group c by new {c.FisTuru, c.ToplamTutar}
                into grp
                select new
                {
                    Bilgi = grp.Key.FisTuru,
                    KayitSayisi = grp.Count(),
                    ToplamTutar = grp.Sum(c => c.ToplamTutar)
                }).ToString();
            return result;
        }

        public object CariGenelToplam(StokTakipContext context, string cariKodu)
        {
            decimal alacak =
                (context.Fisler.Where(c => c.CariKodu == cariKodu && c.FisTuru == "Alış Faturası")
                     .Sum(c => c.ToplamTutar) ?? 0) +
                (context.KasaHareketleri.Where(c => c.CariKodu == cariKodu && c.Hareket == "Kasa Giriş")
                     .Sum(c => c.Tutar) ?? 0);

            decimal borc =
                (context.Fisler.Where(c => c.CariKodu == cariKodu && c.FisTuru == "Satış Faturası")
                     .Sum(c => c.ToplamTutar) ?? 0) +
                (context.KasaHareketleri.Where(c => c.CariKodu == cariKodu && c.Hareket == "Kasa Çıkış")
                     .Sum(c => c.Tutar) ?? 0);

            List<GenelToplam> genelToplamlar = new List<GenelToplam>()
            {
                new GenelToplam
                {
                    Bilgi = "Alacak",
                    Tutar = alacak
                },
                new GenelToplam
                {
                    Bilgi = "Alacak",
                    Tutar = borc
                },
                new GenelToplam
                {
                    Bilgi = "Alacak",
                    Tutar = alacak - borc
                }
            };
            return genelToplamlar;
        }

    }
}
