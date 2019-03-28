using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using StokTakip.DataAccess.EfModel;

namespace StokTakip.Business.ValidationRule
{
    public class PersonalValidator:AbstractValidator<Personal>
    {
        public PersonalValidator()
        {
            RuleFor(p => p.PersonalId).NotEmpty().WithMessage("{PropertyName} Kısmı Boş Bırakılamaz").GreaterThan(0)
                .WithMessage("{PropertyName} 0'dam Büyük Olmalıdır");

            RuleFor(p => p.BolumId).NotEmpty().WithMessage("{PropertyName} Kısmı Boş Bırakılamaz").GreaterThan(0)
                .WithMessage("{PropertyName} 0'dam Büyük Olmalıdır");

            RuleFor(p => p.Adi).NotEmpty().WithMessage("{PropertyName} Kısmı Boş Bırakılamaz")
                .Length(3, 50).WithMessage("{PropertyName} 3-50 Karekter Arası Olmalıdır")
                .Must(BeAValidName).WithMessage("{PropertyName} sadece harflerden oluşmalıdır");

            RuleFor(p => p.KisiId).NotEmpty().WithMessage("{PropertyName} Kısmı Boş Bırakılamaz").GreaterThan(0)
                .WithMessage("{PropertyName} 0'dam Büyük Olmalıdır");

            RuleFor(p => p.Soyadi).NotEmpty().WithMessage("{PropertyName} Kısmı Boş Bırakılamaz")
                .Length(3, 50).WithMessage("{PropertyName} 3-50 Karekter Arası Olmalıdır")
                .Must(BeAValidName).WithMessage("{PropertyName} sadece harflerden oluşmalıdır");

            RuleFor(p => p.Sifre).NotEmpty().WithMessage("{PropertyName} Kısmı Boş Bırakılamaz").GreaterThan(0)
                .WithMessage("{PropertyName} 0'dam Büyük Olmalıdır");

            RuleFor(p => p.Mail).NotEmpty().WithMessage("{PropertyName} Kısmı Boş Bırakılamaz");

        }
        protected bool BeAValidName(string name)
        {
            name = name.Replace(" ", "");
            name = name.Replace("-", "");
            return name.All(Char.IsLetter);
        }
    }
}
