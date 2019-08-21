using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using StokTakip.Entities.Tables;

namespace StokTakip.Entities.Validations
{
    public class PersonelValidator:AbstractValidator<Personel>
    {
        public PersonelValidator()
        {
            RuleFor(p => p.PersonelKodu).NotEmpty().WithMessage("Personel Kodu alanı boş geçilemez.");
            RuleFor(p => p.IseGirisTarihi).NotEmpty().WithMessage("İşe Giriş Tarihi alanı boş geçilemez.");
        }
    }
}
