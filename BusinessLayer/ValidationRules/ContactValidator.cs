using EntityLayer.Tables;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.Name)
                .NotNull().WithMessage("Bu alan boş geçilemez")
                .MaximumLength(30).WithMessage("30 Karakterden fazla girilemez")
                .MinimumLength(3).WithMessage("3 Karakterden az girilemez");
            RuleFor(x=>x.Email)
                .NotNull().WithMessage("Bu alan boş geçilemez")
                .MaximumLength(50).WithMessage("50 Karakterden fazla girilemez")
                .MinimumLength(10).WithMessage("10 Karakterden az girilemez");
            RuleFor(x=>x.Subject)
                 .NotNull().WithMessage("Bu alan boş geçilemez")
                .MaximumLength(50).WithMessage("100 Karakterden fazla girilemez")
                .MinimumLength(10).WithMessage("10 Karakterden az girilemez");
            RuleFor(x=>x.Description)
                 .NotNull().WithMessage("Bu alan boş geçilemez")
                .MaximumLength(500).WithMessage("500 Karakterden fazla girilemez")
                .MinimumLength(10).WithMessage("10 Karakterden az girilemez");
        }
    }
}
