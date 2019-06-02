using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using StokTakip.Entities.Tables;

namespace StokTakip.Entities.Validations
{
    public class KasaValidator: AbstractValidator<Kasa>
    {
        public KasaValidator()
        {
            RuleFor(p => p.KasaKodu).NotEmpty().WithMessage("Kasa kodu alanı boş geçilemez.");
            RuleFor(p => p.KasaAdi).NotEmpty().WithMessage("Kasa adı alanı boş geçilemez.");
        }
    }
}
