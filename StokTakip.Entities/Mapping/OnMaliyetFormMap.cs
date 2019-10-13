using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip.Entities.Tables;

namespace StokTakip.Entities.Mapping
{
    public class OnMaliyetFormMap :EntityTypeConfiguration<OnMaliyetForm>
    {
        public OnMaliyetFormMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity); // Id otomatik artan yapılır.
            this.Property(p => p.Durumu);
            this.Property(p => p.MusteriAdi).HasMaxLength(50);
            this.Property(p => p.onayDurumu);
            this.Property(p => p.DesenNo).HasMaxLength(35);
            this.Property(p => p.Makina).HasMaxLength(35);
            this.Property(p => p.BoyaGideri).HasPrecision(5, 2);
            this.Property(p => p.Profil).HasMaxLength(25);
            this.Property(p => p.KumasCinsiVeEni).HasMaxLength(30);
            this.Property(p => p.PassSayisi).HasMaxLength(10);
            this.Property(p => p.BaskiEni).HasMaxLength(10);
            this.Property(p => p.KagitCinsi).HasMaxLength(25);
            this.Property(p => p.Eni).HasMaxLength(10);
            this.Property(p => p.IsTipi).HasMaxLength(7);
            this.Property(p => p.Pazarlamaci).HasMaxLength(50);
            this.Property(p => p.Desinator).HasMaxLength(25);
            this.Property(p => p.DesenGorseli).HasMaxLength(100);
            this.Property(p => p.Aciklama).HasMaxLength(100);
            this.Property(p => p.Ozelkod1).HasMaxLength(100);
            this.Property(p => p.OzelKod2).HasMaxLength(100);

            this.ToTable("OnMaliyetFormlari");

            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.Durumu).HasColumnName("Durumu");
            this.Property(p => p.onayDurumu).HasColumnName("onayDurumu");
            this.Property(p => p.MusteriAdi).HasColumnName("MusteriAdi");
            this.Property(p => p.DesenNo).HasColumnName("DesenNo");
            this.Property(p => p.Makina).HasColumnName("Makina");
            this.Property(p => p.SiparisNo).HasColumnName("SiparisNo");
            this.Property(p => p.BoyaGideri).HasColumnName("BoyaGideri");
            this.Property(p => p.Profil).HasColumnName("Profil");
            this.Property(p => p.KumasCinsiVeEni).HasColumnName("KumasCinsiVeEni");
            this.Property(p => p.PassSayisi).HasColumnName("PassSayisi");
            this.Property(p => p.BaskiEni).HasColumnName("BaskiEni");
            this.Property(p => p.KagitCinsi).HasColumnName("KagitCinsi");
            this.Property(p => p.Eni).HasColumnName("Eni");
            this.Property(p => p.TransferHizi).HasColumnName("TransferHizi");
            this.Property(p => p.SiparisTarihi).HasColumnName("SiparisTarihi");
            this.Property(p => p.TransferDerecesi).HasColumnName("TransferDerecesi");
            this.Property(p => p.IsTipi).HasColumnName("IsTipi");
            this.Property(p => p.SiparisMiktari).HasColumnName("SiparisMiktari");
            this.Property(p => p.Pazarlamaci).HasColumnName("Pazarlamaci");
            this.Property(p => p.Desinator).HasColumnName("Desinator");
            this.Property(p => p.DesenGorseli).HasColumnName("DesenGorseli");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");
            this.Property(p => p.Ozelkod1).HasColumnName("Ozelkod1");
            this.Property(p => p.OzelKod2).HasColumnName("OzelKod2");
        }
    }
}
