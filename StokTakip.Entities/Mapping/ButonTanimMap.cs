using StokTakip.Entities.Tables;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Entities.Mapping
{
    public class ButonTanimMap : EntityTypeConfiguration<ButonTanim>
    {
        public ButonTanimMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity); // Id otomatik artan yapılır.
            this.Property(p => p.Aciklama).HasMaxLength(200);
            this.Property(p => p.Size).HasMaxLength(30);
            this.Property(p => p.Turu).HasMaxLength(30);
            this.Property(p => p.SimpleArkaPlanRengi).HasMaxLength(50);
            this.Property(p => p.SimpleKenarRengi).HasMaxLength(50);

            //this.Property(p => p.X);
            //this.Property(p => p.Y);
            //this.Property(p => p.Height);
            //this.Property(p => p.Width);

            this.ToTable("ButonTanim"); // Tablo adı tanımlanır

            ////////////Field isimleri belirlenir///////////

            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.Durumu).HasColumnName("Durumu");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");
            this.Property(p => p.Size).HasColumnName("Size");
            this.Property(p => p.Turu).HasColumnName("Turu");
            this.Property(p => p.X).HasColumnName("X");
            this.Property(p => p.Y).HasColumnName("Y");
            this.Property(p => p.Height).HasColumnName("Height");
            this.Property(p => p.Width).HasColumnName("Width");
            this.Property(p => p.SimpleArkaPlanRengi).HasColumnName("ArkaPlanRengi");
            this.Property(p => p.SimpleKenarRengi).HasColumnName("KenarRengi");
            this.Property(p => p.GroupWidth).HasColumnName("GroupWidth");
            this.Property(p => p.GroupHeight).HasColumnName("GroupHeight");
            this.Property(p => p.FlowWidth).HasColumnName("FlowWidth");
            this.Property(p => p.FlowHeight).HasColumnName("FlowHeight");
            this.Property(p => p.FlowDock).HasColumnName("FlowDock");
            this.Property(p => p.FlowVisible).HasColumnName("FlowVisible");
            this.Property(p => p.SimpleDock).HasColumnName("SimpleDock");
        }
    }
}
