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
    public class FormUrunBilgiMap : EntityTypeConfiguration<FormUrunBilgi>
    {
        public FormUrunBilgiMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity); // Id otomatik artan yapılır.
            this.Property(p => p.FormNo).HasMaxLength(50);
            this.Property(p => p.Urun).HasMaxLength(50);
            this.Property(p => p.Miktar).HasMaxLength(50);
            this.Property(p => p.Tahsis).HasMaxLength(50);
            this.Property(p => p.Amaci).HasMaxLength(50);
            this.Property(p => p.UrunAciklama).HasMaxLength(200);

            this.ToTable("FormUrunBilgi"); // Tablo adı tanımlanır

            ////////////Field isimleri belirlenir///////////

            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.FormNo).HasColumnName("FormNo");
            this.Property(p => p.Urun).HasColumnName("Urun");
            this.Property(p => p.Miktar).HasColumnName("Miktar");
            this.Property(p => p.Tahsis).HasColumnName("Tahsis");
            this.Property(p => p.Amaci).HasColumnName("Amaci");
            this.Property(p => p.Sozlesme).HasColumnName("Sozlesme");
            this.Property(p => p.UrunAciklama).HasColumnName("UrunAciklama");

        }
    }
}
