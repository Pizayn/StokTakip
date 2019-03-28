using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using StokTakip.DataAccess.EfModel;

namespace StokTakip.Business.ValidationRule
{
    public class ZimmetValidation:AbstractValidator<Zimmet>
    {
        public ZimmetValidation()
        {
            RuleFor(p => p.PersonalId).NotEmpty().WithMessage("{PropertyName} Kısmı Boş Bırakılamaz").GreaterThan(0)
                .WithMessage("{PropertyName} 0'dam Büyük Olmalıdır");

            RuleFor(p => p.MarkaId).NotEmpty().WithMessage("{PropertyName} Kısmı Boş Bırakılamaz").GreaterThan(0)
                .WithMessage("{PropertyName} 0'dam Büyük Olmalıdır");
            RuleFor(p => p.UrunId).NotEmpty().WithMessage("{PropertyName} Kısmı Boş Bırakılamaz").GreaterThan(0)
                .WithMessage("{PropertyName} 0'dam Büyük Olmalıdır");
            RuleFor(p => p.ZimmetAded).NotEmpty().WithMessage("{PropertyName} Kısmı Boş Bırakılamaz").GreaterThan(0)
                .WithMessage("{PropertyName} 0'dam Büyük Olmalıdır");

            RuleFor(p => p.ZimmetDurumu).NotEmpty().WithMessage("{PropertyName} Kısmı Boş Bırakılamaz");

        }
    }
}
