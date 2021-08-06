using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeraSatis.Entities.Tables;

namespace HeraSatis.Entities.Mapping
{
   public class StokHareketMap:EntityTypeConfiguration<StokHareket>
    {
        public StokHareketMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.FisKodu).HasMaxLength(15);
            this.Property(p => p.Hareket).HasMaxLength(10);
            this.Property(p => p.StokAdi).HasMaxLength(50);
            this.Property(p => p.StokKodu).HasMaxLength(15);
            this.Property(p => p.BarkodTuru).HasMaxLength(15);
            this.Property(p => p.Barkod).HasMaxLength(20);
            this.Property(p => p.Birimi).HasMaxLength(15);
            this.Property(p => p.Miktar).HasPrecision(12,3);
            this.Property(p => p.BirimFiyati).HasPrecision(12, 2);
            this.Property(p => p.IndırimOrani).HasPrecision(5, 2);
            this.Property(p => p.IndirimTutari).HasPrecision(12, 2);
            this.Property(p => p.ToplamTutar).HasPrecision(12, 2);
            this.Property(p => p.DepoKodu).HasMaxLength(12);
            this.Property(p => p.DepoAdi).HasMaxLength(30);
            this.Property(p => p.SeriNo).HasMaxLength(200);
            this.Property(p => p.Aciklama).HasMaxLength(200);
            this.ToTable("StokHaraketleri");








        }


    }
}
