using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules.FluentValidation
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adını boş bırakamazsınız.");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Yazar adı en az iki karakter olmalıdır.");

            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Yazar soyadını boş bırakamazsınız.");
            RuleFor(x => x.WriterSurName).MinimumLength(2).WithMessage("Yazar adı en az iki karakter olmalıdır.");

            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Yazar hakkkımda boş bırakamazsınız.");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Yazar ünvanını boş bırakamazsınız.");
         
        }
    }
}
