using BlogProject.Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Business.Validation
{
   public class ArticleValidator:AbstractValidator<Article>
    {
        public ArticleValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık boş geçilemez!");
            RuleFor(x => x.Content).NotEmpty().WithMessage("İçerik boş geçilemez!");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Blog görseli boş geçilemez!");
            RuleFor(x => x.Title).MaximumLength(150).WithMessage("Başlık 150 karakterden fazla olamaz!");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Başlık en az 5 karakter olmalıdır!");
            RuleFor(x => x.Content).MinimumLength(50).WithMessage("İçerik en az 50 karakter olmalıdır!");
        }
    }
}
