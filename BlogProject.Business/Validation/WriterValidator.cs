using BlogProject.Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Business.Validation
{
   public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Yazar adı soyadı boş geçilemez!");
            RuleFor(x => x.Email).NotEmpty().EmailAddress().WithMessage("Mail adresi boş geçilemez!");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Parola boş geçilemez!").MinimumLength(8).Matches("[A-Z]").WithMessage("Şifreniz büyük harf içermelidir!").Matches("[a-z]").WithMessage("Şifreniz küçük harf içermelidir!").Matches("[0-9]").WithMessage("Şifreniz rakam içermelidir!");

            RuleFor(x => x.PasswordConfirm).NotEmpty().WithMessage("Parolanızı tekrar giriniz!");

            RuleFor(x => x).Custom((x, context) =>
            {
                if (x.Password != x.PasswordConfirm)
                {
                    context.AddFailure(nameof(x.Password), "Parolanız eşleşmiyor!");
                }
            });
        }
    }
}
