using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentValidation;
using StokTakip.Entities.Interfaces;

namespace StokTakip.Entities.Tools
{
    public static class ValidatorTools
    {
        public static bool Validate(IValidator validator, IEntity entity)
        {
            bool result = true;

            var validationResult = validator.Validate(entity);
            if (!validationResult.IsValid)
            {
                string message = null;
                foreach (var error in validationResult.Errors)
                {
                    message += error.ErrorMessage+System.Environment.NewLine;
                }

                MessageBox.Show(message);
                result = false;
            }

            return result;

        }
    }
}
