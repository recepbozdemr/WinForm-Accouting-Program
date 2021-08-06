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
   public class TanimMap:EntityTypeConfiguration<Tanim>
    {


        public TanimMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.Turu).HasMaxLength(30);
            this.Property(p => p.Tanimi).HasMaxLength(30);
            this.Property(p => p.Aciklama).HasMaxLength(200);
            this.ToTable("Tanimlar");
        }




    }
}
