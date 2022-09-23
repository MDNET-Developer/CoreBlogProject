using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.CategoryValidator
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Boş verilən daxil ediləməz !!!");
            RuleFor(x => x.CategoryName).MinimumLength(2).WithMessage("Ən azı 2 simvol daxil edilə bilər");
            RuleFor(x => x.CategoryName).MaximumLength(30).WithMessage("Ən çoxu 30 simvol daxil edə bilərsiz");

            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Boş verilən daxil ediləməz !!!");
            RuleFor(x => x.CategoryDescription).MinimumLength(15).WithMessage("Ən azı 30 simvol daxil edilə bilər");
            RuleFor(x => x.CategoryDescription).MaximumLength(4000).WithMessage("Ən çoxu 4000 simvol daxil edə bilərsiz");

        }
    }
}
