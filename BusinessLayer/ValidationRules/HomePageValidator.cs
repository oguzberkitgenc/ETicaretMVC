using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Tables;
using FluentValidation;
using FluentValidation.Results;

namespace BusinessLayer.ValidationRules
{
    public class HomePageValidator : AbstractValidator<HomePage>
    {
        public HomePageValidator()
        {
            RuleFor(x => x.HomPageTitle).NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.HomPageTitle).MinimumLength(5).WithMessage("5 Karakterden az olamaz");
            RuleFor(x => x.HomPageTitle).MaximumLength(30).WithMessage("30 Karakterden fazla olamaz");

            RuleFor(X => X.HomPageSubTitle).MinimumLength(5).WithMessage("5 Karakterden az olamaz");
            RuleFor(X => X.HomPageSubTitle).MaximumLength(80).WithMessage("80 Karakterden fazla olamaz");
            //---***///
            RuleFor(x => x.LowerLeft).NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.LowerLeft).MinimumLength(5).WithMessage("5 Karakterden az olamaz");
            RuleFor(x => x.LowerLeft).MaximumLength(30).WithMessage("30 Karakterden fazla olamaz");

            RuleFor(x => x.LowerLeftDesc).MinimumLength(5).WithMessage("5 Karakterden fazla olamaz");
            RuleFor(x => x.LowerLeftDesc).MaximumLength(150).WithMessage("150 Karakterden fazla olamaz");
            RuleFor(x => x.LowerLeftDesc).NotNull().WithMessage("Bu alan boş geçilemez");
            //---***///
            RuleFor(x => x.LowerCenter).NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.LowerCenter).MinimumLength(5).WithMessage("5 Karakterden az olamaz");
            RuleFor(x => x.LowerCenter).MaximumLength(30).WithMessage("30 Karakterden fazla olamaz");

            RuleFor(x => x.LowerCenterDesc).MinimumLength(5).WithMessage("5 Karakterden fazla olamaz");
            RuleFor(x => x.LowerCenterDesc).MaximumLength(150).WithMessage("150 Karakterden fazla olamaz");
            RuleFor(x => x.LowerCenterDesc).NotNull().WithMessage("Bu alan boş geçilemez");
            //---***///
            RuleFor(x => x.LowerRight).NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.LowerRight).MinimumLength(5).WithMessage("5 Karakterden az olamaz");
            RuleFor(x => x.LowerRight).MaximumLength(30).WithMessage("30 Karakterden fazla olamaz");

            RuleFor(x => x.LowerRightDesc).MinimumLength(5).WithMessage("5 Karakterden fazla olamaz");
            RuleFor(x => x.LowerRightDesc).MaximumLength(150).WithMessage("150 Karakterden fazla olamaz");
            RuleFor(x => x.LowerRightDesc).NotNull().WithMessage("Bu alan boş geçilemez");
            //---***///
            RuleFor(x => x.LeftPageBreak).NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.LeftPageBreak).MinimumLength(5).WithMessage("5 Karakterden az olamaz");
            RuleFor(x => x.LeftPageBreak).MaximumLength(30).WithMessage("30 Karakterden fazla olamaz");

            RuleFor(x => x.LeftPageBreakDesc).MinimumLength(5).WithMessage("5 Karakterden fazla olamaz");
            RuleFor(x => x.LeftPageBreakDesc).MaximumLength(150).WithMessage("150 Karakterden fazla olamaz");
            RuleFor(x => x.LeftPageBreakDesc).NotNull().WithMessage("Bu alan boş geçilemez");
            //---***///
            RuleFor(x => x.CenterPageBreak).NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.CenterPageBreak).MinimumLength(5).WithMessage("5 Karakterden az olamaz");
            RuleFor(x => x.CenterPageBreak).MaximumLength(30).WithMessage("30 Karakterden fazla olamaz");

            RuleFor(x => x.CenterPageBreakDesc).MinimumLength(5).WithMessage("5 Karakterden fazla olamaz");
            RuleFor(x => x.CenterPageBreakDesc).MaximumLength(150).WithMessage("150 Karakterden fazla olamaz");
            RuleFor(x => x.CenterPageBreakDesc).NotNull().WithMessage("Bu alan boş geçilemez");
            //---***///
            RuleFor(x => x.RightPageBreak).NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.RightPageBreak).MinimumLength(5).WithMessage("5 Karakterden az olamaz");
            RuleFor(x => x.RightPageBreak).MaximumLength(30).WithMessage("30 Karakterden fazla olamaz");

            RuleFor(x => x.RightPageBreakDesc).MinimumLength(5).WithMessage("5 Karakterden fazla olamaz");
            RuleFor(x => x.RightPageBreakDesc).MaximumLength(150).WithMessage("150 Karakterden fazla olamaz");
            RuleFor(x => x.RightPageBreakDesc).NotNull().WithMessage("Bu alan boş geçilemez");
            //---***///
            RuleFor(x => x.PageBreakTitle).MaximumLength(100).WithMessage("100 Karakterden fazla olamaz");
            RuleFor(x => x.PageBreakTitleDesc).MaximumLength(100).WithMessage("100 Karakterden fazla olamaz");
            //---***///
            RuleFor(x => x.BottomGreenTitle).MaximumLength(100).WithMessage("100 Karakterden fazla olamaz");
            RuleFor(x => x.BottomGreenBox).MaximumLength(100).WithMessage("100 Karakterden fazla olamaz");
        }

        public ValidationResult Validate(Product product2)
        {
            throw new NotImplementedException();
        }
    }
}
