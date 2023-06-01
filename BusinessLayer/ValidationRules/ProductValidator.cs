using EntityLayer.Tables;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("50 Karakterden fazla olamaz");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("3 Karakterden az olamaz");

            RuleFor(x => x.Price).NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.Stock).NotNull().WithMessage("Bu alan boş geçilemez");
        }
    }
}
