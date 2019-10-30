using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using StokTakip.Entities.Tables;

namespace StokTakip.Entities.Validations
{
    public class OnMaliyetFormValidator : AbstractValidator<OnMaliyetForm>
    {
        public OnMaliyetFormValidator()
        {
            RuleFor(p => p.DesenNo).NotEmpty().WithMessage("Desen numarası alanı boş geçilemez.");
        }
    }
}
