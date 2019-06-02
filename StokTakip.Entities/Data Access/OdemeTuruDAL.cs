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
    }
}
