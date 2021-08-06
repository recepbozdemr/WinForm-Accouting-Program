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
   public class CariMap:EntityTypeConfiguration<Cari>
    {

        public CariMap()
        {
            this.HasKey(p => p.ID);
            this.Property(p => p.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.CariKodu).HasMaxLength(12);
            this.Property(p => p.CariAdi).HasMaxLength(15);
            this.Property(p => p.YetkiliKisi).HasMaxLength(50);
            this.Property(p => p.FaturaUnvani).HasMaxLength(50);
            this.Property(p => p.CepTelefonu).HasMaxLength(20);
            this.Property(p => p.Fax).HasMaxLength(20);
            this.Property(p => p.Telefon).HasMaxLength(20);
            this.Property(p => p.EMail).HasMaxLength(50);
            this.Property(p => p.Web).HasMaxLength(20);
            this.Property(p => p.Il).HasMaxLength(20);
            this.Property(p => p.Ilce).HasMaxLength(20);
            this.Property(p => p.Semt).HasMaxLength(20);
            this.Property(p => p.Adres).HasMaxLength(100);
            this.Property(p => p.CariGrubu).HasMaxLength(30);
            this.Property(p => p.CariAltGrubu).HasMaxLength(30);
            this.Property(p => p.OzelKod1).HasMaxLength(30);
            this.Property(p => p.OzelKod2).HasMaxLength(30);
            this.Property(p => p.OzelKod3).HasMaxLength(30);
            this.Property(p => p.OzelKod4).HasMaxLength(30);
            this.Property(p => p.VergiDairesi).HasMaxLength(30);
            this.Property(p => p.VergiNo).HasMaxLength(15);
            this.Property(p => p.IskontoOrani).HasPrecision(5, 2);
            this.Property(p => p.RiskLimiti).HasPrecision(12, 2);
            this.Property(p => p.AlisOzelFiyati).HasMaxLength(15);
            this.Property(p => p.SatisOzelFiyati).HasMaxLength(15);
            this.Property(p => p.Aciklama).HasMaxLength(200);
            this.ToTable("Cariler");

        }


    }
}
