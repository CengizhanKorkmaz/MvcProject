using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules.FluentValidation
{
    public class ContactValidator:AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.UserEmail).NotEmpty().WithMessage("Mail adresi boş bırakılamaz.");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu kısmı boş bırakılamaz.");
            RuleFor(x => x.Message).NotEmpty().WithMessage("Mesaj alanı boş bırakılamaz.");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("İsim alanı boş bırakılamaz.");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("En az 3 karekterden oluşmalıdır.");
            RuleFor(x => x.UserName).MinimumLength(3).WithMessage("En az 3 karekterden oluşmalıdır.");
            
        }
    }
}
