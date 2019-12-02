using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip.Entities.Tables;

namespace StokTakip.Entities.Mapping
{
    public class SatinAlmaTalepFormMap : EntityTypeConfiguration<SatinAlmaTalepForm>
    {
        public SatinAlmaTalepFormMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity); // Id otomatik artan yapılır.
            this.Property(p => p.FormNo).HasMaxLength(50);
            this.Property(p => p.PersonelNo).HasMaxLength(50);
            this.Property(p => p.PersonelAdi).HasMaxLength(35);
            this.Property(p => p.PersonelSoyadi).HasMaxLength(60);
            this.Property(p => p.Aciklama).HasMaxLength(200);

            this.ToTable("SatinAlmaTalepForm"); // Tablo adı tanımlanır

            ////////////Field isimleri belirlenir///////////

            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.FormNo).HasColumnName("FormNo");
            this.Property(p => p.Durumu).HasColumnName("Durumu");
            this.Property(p => p.PersonelNo).HasColumnName("PersonelNo");
            this.Property(p => p.PersonelAdi).HasColumnName("PersonelAdi");
            this.Property(p => p.PersonelSoyadi).HasColumnName("PersonelSoyadi");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");
            
        }
    }
}
