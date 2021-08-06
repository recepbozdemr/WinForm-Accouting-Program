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
   public class FisMap:EntityTypeConfiguration<Fis>
    {

        public FisMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.FisKodu).HasMaxLength(12);
            this.Property(p => p.FisTuru).HasMaxLength(30);
            this.Property(p => p.CariKodu).HasMaxLength(12);
            this.Property(p => p.BelgeNo).HasMaxLength(20);
            this.Property(p => p.PlasiyerAdi).HasMaxLength(50);
            this.Property(p => p.PlasiyerKodu).HasMaxLength(12);
            this.Property(p => p.IskontoOrani).HasPrecision(5, 2);
            this.Property(p => p.İskontoTutari).HasPrecision(12, 2);
            this.Property(p => p.ToplamTutar).HasPrecision(12, 2);
            this.Property(p => p.Aciklama).HasMaxLength(200);

            this.ToTable("Fisler");
        }






    }
}
