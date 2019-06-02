using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using StokTakip.Entities.Tables;

namespace StokTakip.Entities.Validations
{
    public class OdemeTuruValidator: AbstractValidator<OdemeTuru>
    {
        public OdemeTuruValidator()
        {
            RuleFor(p => p.OdemeTuruKodu).NotEmpty().WithMessage("Ödeme türü kodu alanı boş geçilemez.");
            RuleFor(p => p.OdemeTuruAdi).NotEmpty().WithMessage("Ödeme türü adı alanı boş geçilemez.");
        }
    }
}
