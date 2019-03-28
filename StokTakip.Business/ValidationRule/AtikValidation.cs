using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using StokTakip.DataAccess.EfModel;

namespace StokTakip.Business.ValidationRule
{
    public class AtikValidation:AbstractValidator<Atik>
    {
        public AtikValidation()
        {
            RuleFor(p => p.AtikId).NotEmpty().WithMessage("{PropertyName} Kısmı Boş Bırakılamaz").GreaterThan(0)
                .WithMessage("{PropertyName} 0'dam Büyük Olmalıdır");
            RuleFor(p => p.MarkaId).NotEmpty().WithMessage("{PropertyName} Kısmı Boş Bırakılamaz").GreaterThan(0)
                .WithMessage("{PropertyName} 0'dam Büyük Olmalıdır");
            RuleFor(p => p.UrunId).NotEmpty().WithMessage("{PropertyName} Kısmı Boş Bırakılamaz").GreaterThan(0)
                .WithMessage("{PropertyName} 0'dam Büyük Olmalıdır");



        }
    }
}
