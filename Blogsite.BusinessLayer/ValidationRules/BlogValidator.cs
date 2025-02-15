using Blogsite.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogsite.BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog Başlığı boş geçilemez!");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("Başlık en az 5 karakter olamlıdır!");
            RuleFor(x => x.BlogTitle).MaximumLength(100).WithMessage("Başlık en fazla 100 karakter olamlıdır!");


            RuleFor(x => x.BlogContent).MinimumLength(100).WithMessage("İçerik en az 100 karakter olamlıdır!");

            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog İçeriği boş geçilemez!");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog Resimi boş geçilemez!");

        }
    }
}
