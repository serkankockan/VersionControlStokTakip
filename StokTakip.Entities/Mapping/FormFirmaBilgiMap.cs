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
    public class FormFirmaBilgiMap : EntityTypeConfiguration<FormFirmaBilgi>
    {
        public FormFirmaBilgiMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity); // Id otomatik artan yapılır.
            this.Property(p => p.FormNo).HasMaxLength(50);
            this.Property(p => p.Firma).HasMaxLength(50);
            this.Property(p => p.Doviz).HasMaxLength(10);
            this.Property(p => p.TeklifAciklama).HasMaxLength(200);
            
            this.ToTable("FormFirmaBilgi"); // Tablo adı tanımlanır

            ////////////Field isimleri belirlenir///////////

            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.FormNo).HasColumnName("FormNo");
            this.Property(p => p.Firma).HasColumnName("Firma");
            this.Property(p => p.Doviz).HasColumnName("Doviz");
            this.Property(p => p.Fiyat).HasColumnName("Fiyat");
            this.Property(p => p.TeklifAciklama).HasColumnName("TeklifAciklama");
        }
    }
}
