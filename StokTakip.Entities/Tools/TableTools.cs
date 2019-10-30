using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip.Entities.Context;

namespace StokTakip.Entities.Tools
{
    public class TableTools
    {
        public void RefreshAll(StokTakipContext context)
        {
            foreach (var entity in context.ChangeTracker.Entries())
            {
                entity.Reload();
            }
        }
    }
}
