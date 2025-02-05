using Blogsite.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogsite.BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adı!");
            
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adresi boş geçilemez!");
            
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre boş geçilemez!");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("İsim en az 2 karakter olamlıdır!");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("İsim en fazla 50 karakter olamlıdır!");

        }
    }
}
