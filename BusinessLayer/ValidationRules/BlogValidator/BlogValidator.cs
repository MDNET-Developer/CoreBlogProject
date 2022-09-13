using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.BlogValidator
{
    public class BlogValidator: AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Boş verilən daxil ediləməz");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("Ən azı 5 simvol daxil edilməlidir");

            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Boş verilən daxil ediləməz");
            RuleFor(x => x.BlogContent).MinimumLength(77).WithMessage("Ən azı 77 simvol olmalıdır");


            
        }
    }
}
