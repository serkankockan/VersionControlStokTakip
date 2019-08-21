using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using StokTakip.Entities.Context;
using StokTakip.Entities.Repositories;
using StokTakip.Entities.Tables;
using StokTakip.Entities.Validations;

namespace StokTakip.Entities.Data_Access
{
    public class PersonelDAL: EntityRepositoryBase<StokTakipContext,Personel,PersonelValidator>
    {
        public object PersonelListesi(StokTakipContext context)
        {
            var result = context.Personeller.GroupJoin(context.Fisler, c => c.PersonelKodu, c => c.PlasiyerKodu,
                (personel, fis) => new
                {
                    personel.id,
                    personel.Calisisyor,
                    personel.PersonelKodu,
                    personel.PersonelAdi,
                    personel.Unvani,
                    personel.TCKimlikNo,
                    personel.IseGirisTarihi,
                    personel.IstenCikisTarihi,
                    personel.VergiDairesi,
                    personel.VergiNo,
                    personel.CepTelefonu,
                    personel.Fax,
                    personel.Il,
                    personel.Ilce,
                    personel.Semt,
                    personel.Adres,
                    personel.Email,
                    personel.Web,
                    personel.PrimOrani,
                    personel.AylikMaas,
                    personel.Aciklama,
                    ToplamSatis = fis.Where(c => c.FisTuru == "Perakende Satış Faturası").Sum(c=> c.ToplamTutar) ?? 0,
                    PrimTutari = (fis.Where(c => c.FisTuru == "Perakende Satış Faturası").Sum(c=> c.ToplamTutar) ?? 0) / 100 * personel.PrimOrani
                }).ToList();
            return result;
        }


        public object PersonelFisToplam(StokTakipContext context,string personelKodu)
        {
            var result = (from c in context.Fisler.Where(c => c.PlasiyerKodu == personelKodu)
                    group c by new {c.FisTuru}
                    into grp
                    select new
                    {
                        Bilgi = grp.Key.FisTuru,
                        KayitSayisi = grp.Count(),
                        ToplamTutar = grp.Sum(c => c.ToplamTutar)
                    }
                ).ToList();
            return result;
        }
    }
}
