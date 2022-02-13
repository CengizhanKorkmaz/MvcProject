using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules.FluentValidation
{
    public class MessageValidator:AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Alıcı mailini boş geçemezsiniz.");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Mesaj konusunu giriniz.");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Mesajı boş geçemezsiniz.");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Konu başlığı en az 3 karakterden oluşmalıdır.");
            RuleFor(x => x.ReceiverMail).EmailAddress().WithMessage("Girdiğiniz mail adresi geçersizdir.");
        }
    }
}
