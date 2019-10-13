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
    public class OnMaliyetFormDAL: EntityRepositoryBase<StokTakipContext, OnMaliyetForm, OnMaliyetFormValidator>
    {
        public object TumOnMaliyetler(StokTakipContext context)
        {
            var result = context.OnMaliyetFormlari.ToList();
            return result;
        }

        public int OnayBekleyenler(StokTakipContext context)
        {
            var result = context.OnMaliyetFormlari.Count(c => c.onayDurumu == false);
            return result;
        }
    }
}
