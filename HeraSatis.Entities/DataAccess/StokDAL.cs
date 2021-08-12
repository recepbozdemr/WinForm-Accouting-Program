using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using HeraSatis.Entities.Context;
using HeraSatis.Entities.Repositories;
using HeraSatis.Entities.Tables;
using HeraSatis.Entities.Validations;

namespace HeraSatis.Entities.DataAccess
{
   public class StokDAL:EntityRepositoryBase<HeraSatisContext,Stok,StokValidator>
    {
        public object GetAllJoin(HeraSatisContext context)
        {


            //Tablo olarak bi değişken oluşturup Stoklar tablosu ile Stok hareket tablosunu group join ile birleştirip idlerini birbirine bağladım, daha sonra hayali bir tablo oluşturup stok giriş çıkışlarımı toplam tutarımı ve stoğumu görebileceğim bir listeye döndürdüm


            var tablo = context.Stoklar.GroupJoin(context.StokHareketleri, c => c.StokKodu, c => c.StokKodu,
                (Stoklar, StokHareketleri) => new
                {
                    Stoklar.Id,
                    Stoklar.StokKodu,
                    Stoklar.StokAdi,
                    Stoklar.Durum,
                    Stoklar.Barkod,
                    Stoklar.BarkodTuru,
                    Stoklar.Birimi,
                    Stoklar.StokGrubu,
                    Stoklar.StokAltGrubu,
                    Stoklar.Marka,
                    Stoklar.Modeli,
                    Stoklar.OzelKod1,
                    Stoklar.OzelKod2,
                    Stoklar.OzelKod3,
                    Stoklar.OzelKod4,
                    Stoklar.GarantiSuresi,
                    Stoklar.UreticiKodu,
                    Stoklar.AlisKdv,
                    Stoklar.SatisKdv,
                    Stoklar.AlisFiyati1,
                    Stoklar.AlisFiyati2,
                    Stoklar.AlisFiyati3,
                    Stoklar.SatisFiyati1,
                    Stoklar.SatisFiyati2,
                    Stoklar.SatisFiyati3,
                    Stoklar.MinStokMiktari,
                    Stoklar.MaxStokMiktari,
                    Stoklar.Aciklama,
                    StokGiris = StokHareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0,
                    StokCikis = StokHareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0,
                    MevcutStok = StokHareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) - StokHareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0
                }).ToList();

            return tablo;


        }


    }




}
