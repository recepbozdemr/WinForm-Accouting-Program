using HeraSatis.Entities.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeraSatis.Entities.Mapping
{
   public class StokMap:EntityTypeConfiguration<Stok>
    {

        public StokMap()
        {
            this.HasKey(p => p.Id);//Birincil Anahtar
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity); //Otomatik Artan Şekilde Ayarlayacak
            this.Property(p => p.StokKodu).HasMaxLength(12);  //
            this.Property(p => p.StokAdi).HasMaxLength(50).IsRequired(); //Max Karakter ve boş geçilemez durumu
            this.Property(p => p.BarkodTuru).HasMaxLength(15);
            this.Property(p => p.Birimi).HasMaxLength(15);
            this.Property(p => p.StokGrubu).HasMaxLength(30);
            this.Property(p => p.StokAltGrubu).HasMaxLength(30);
            this.Property(p => p.Marka).HasMaxLength(30);
            this.Property(p => p.Modeli).HasMaxLength(30);
            this.Property(p => p.OzelKod1).HasMaxLength(30);
            this.Property(p => p.OzelKod2).HasMaxLength(30);
            this.Property(p => p.OzelKod3).HasMaxLength(30);
            this.Property(p => p.OzelKod4).HasMaxLength(30);
            this.Property(p => p.GarantiSuresi).HasMaxLength(15);
            this.Property(p => p.UreticiKodu).HasMaxLength(20);
            this.Property(p => p.AlisFiyati1).HasPrecision(12,2); //Decimal karakterde özellik
            this.Property(p => p.AlisFiyati2).HasPrecision(12, 2);
            this.Property(p => p.AlisFiyati3).HasPrecision(12, 2);
            this.Property(p => p.SatisFiyati1).HasPrecision(12, 2);
            this.Property(p => p.SatisFiyati2).HasPrecision(12, 2);
            this.Property(p => p.SatisFiyati3).HasPrecision(12, 2);
            this.Property(p => p.MinStokMiktari).HasPrecision(12, 3);
            this.Property(p => p.MaxStokMiktari).HasPrecision(12, 3);
            this.Property(p => p.Aciklama).HasMaxLength(200);
            this.ToTable("Stoklar");
          
        }








    }
}
