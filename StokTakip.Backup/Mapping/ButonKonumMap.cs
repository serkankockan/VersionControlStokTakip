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
    public class ButonKonumMap : EntityTypeConfiguration<ButonKonum>
    {
        public ButonKonumMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity); // Id otomatik artan yapılır.
            this.Property(p => p.Aciklama).HasMaxLength(200);
            this.Property(p => p.Size).HasMaxLength(30);
            this.Property(p => p.Turu).HasMaxLength(30);
            this.Property(p => p.KonumAdi).HasMaxLength(30);

            this.ToTable("ButonKonum"); // Tablo adı tanımlanır

            ////////////Field isimleri belirlenir///////////

            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.Durumu).HasColumnName("Durumu");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");
            this.Property(p => p.Size).HasColumnName("Size");
            this.Property(p => p.Turu).HasColumnName("Turu");
            this.Property(p => p.X).HasColumnName("X");
            this.Property(p => p.Y).HasColumnName("Y");
            this.Property(p => p.KonumAdi).HasColumnName("KonumAdi");

        }
    }
}
