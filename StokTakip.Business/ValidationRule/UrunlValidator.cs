using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using StokTakip.DataAccess.EfModel;

namespace StokTakip.Business.ValidationRule
{
    public class UrunlValidator:AbstractValidator<Urun>
    {
        public UrunlValidator()
        {
            RuleFor(p => p.MarkaId).NotEmpty().WithMessage("{PropertyName} Kısmı Boş Bırakılamaz").GreaterThan(0)
                .WithMessage("{PropertyName} 0'dam Büyük Olmalıdır");

            RuleFor(p => p.UrunAdi).NotEmpty().WithMessage("{PropertyName} Kısmı Boş Bırakılamaz")
                .Length(3, 50).WithMessage("{PropertyName} 3-50 Karekter Arası Olmalıdır")
                .Must(BeAValidName).WithMessage("{PropertyName} sadece harflerden oluşmalıdır");

            RuleFor(p => p.UrunId).NotEmpty().WithMessage("{PropertyName} Kısmı Boş Bırakılamaz").GreaterThan(0)
                .WithMessage("{PropertyName} 0'dam Büyük Olmalıdır");

            RuleFor(p => p.UrunAded).NotEmpty().WithMessage("{PropertyName} Kısmı Boş Bırakılamaz").GreaterThan(0)
                .WithMessage("{PropertyName} 0'dam Büyük Olmalıdır");








        }
        protected bool BeAValidName(string name)
        {
            name = name.Replace(" ", "");
            name = name.Replace("-", "");
            return name.All(Char.IsLetter);
        }
    }
}
