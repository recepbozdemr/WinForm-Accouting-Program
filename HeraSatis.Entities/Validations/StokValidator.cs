using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using HeraSatis.Entities.Tables;

namespace HeraSatis.Entities.Validations
{
 public   class StokValidator:AbstractValidator<Stok>
    {

        public StokValidator()
        {
            RuleFor(p => p.StokKodu).NotEmpty().WithMessage("Stok Kodu alanı boş geçilemez.");
            RuleFor(p => p.StokAdi).NotEmpty().WithMessage("Stok Kodu alanı boş geçilemez.").Length(5,50).WithMessage("Stok Adı 5 ile 50 Karakter arasında olabilir.");
            RuleFor(p => p.Barkod).NotEmpty().WithMessage("Barkod alanı boş geçilemez.");
            RuleFor(p => p.AlisFiyati1).GreaterThan(0).WithMessage("Alış Fiyatı  - 1 alanı 0'dan küçük olamaz.");
            RuleFor(p => p.AlisFiyati2).GreaterThan(0).WithMessage("Alış Fiyatı  - 2 alanı 0'dan küçük olamaz.");
            RuleFor(p => p.AlisFiyati3).GreaterThan(0).WithMessage("Alış Fiyatı  - 3 alanı 0'dan küçük olamaz.");
            RuleFor(p => p.SatisFiyati1).GreaterThan(0).WithMessage("Satış Fiyatı  - 1 alanı 0'dan küçük olamaz.");
            RuleFor(p => p.SatisFiyati2).GreaterThan(0).WithMessage("Satış Fiyatı  - 2 alanı 0'dan küçük olamaz.");
            RuleFor(p => p.SatisFiyati3).GreaterThan(0).WithMessage("Satış Fiyatı  - 3 alanı 0'dan küçük olamaz.");

        }




    }
}
