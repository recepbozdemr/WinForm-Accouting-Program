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
   public class KasaHareketMap:EntityTypeConfiguration<KasaHareket>
    {
        public KasaHareketMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.FisKodu).HasMaxLength(12);
            this.Property(p => p.Hareket).HasMaxLength(10);
            this.Property(p => p.KasaKodu).HasMaxLength(12);
            this.Property(p => p.KasaAdi).HasMaxLength(30);
            this.Property(p => p.OdemeTuruKodu).HasMaxLength(12);
            this.Property(p => p.OdemeTuruAdi).HasMaxLength(30);
            this.Property(p => p.CariKodu).HasMaxLength(12);
            this.Property(p => p.CariAdi).HasMaxLength(50);
            this.Property(p => p.Tutar).HasPrecision(12, 2);
            this.Property(p => p.Aciklama).HasMaxLength(200);
            this.ToTable("KasaHaraketleri");



        }
    }
}
