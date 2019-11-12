using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using StokTakip.Entities.Tables;

namespace StokTakip.Entities.Validations
{
    public class ButonTanimValidator : AbstractValidator<ButonTanim>
    {
        public ButonTanimValidator()
        {
            RuleFor(p => p.Turu).NotEmpty().WithMessage("Tür alanı boş geçilemez.");
            RuleFor(p => p.Aciklama).NotEmpty().WithMessage("Açıklama alanı boş geçilemez.");
        }
    }
}