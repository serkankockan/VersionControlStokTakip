using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using StokTakip.Entities.Tables;

namespace StokTakip.Entities.Validations
{
    public class DepoValidator:AbstractValidator<Depo>
    {
        public DepoValidator()
        {
            RuleFor(p => p.DepoKodu).NotEmpty().WithMessage("Depo kodu alanı boş geçilemez.");
            RuleFor(p => p.DepoAdi).NotEmpty().WithMessage("Depo adı alanı boş geçilemez.");
        }
    }
}
