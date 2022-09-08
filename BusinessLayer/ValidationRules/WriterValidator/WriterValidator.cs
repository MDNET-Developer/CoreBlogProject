using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.WriterValidator
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Verilən daxil edin !!!");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Verilən daxil edin !!!");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Verilən daxil edin !!!");
            RuleFor(x => x.WriterPassword).MinimumLength(6).WithMessage("Minimum 6 simvol olmalıdır !!!");
        }
    }
}
