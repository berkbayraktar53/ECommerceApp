using ECommerceApp.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Business.ValidationRules.FluentValidation
{
    public class ShippingDetailValidator : AbstractValidator<ShippingDetail>
    {
        public ShippingDetailValidator()
        {
            RuleFor(s => s.FirstName).NotEmpty().WithMessage("İsim boş geçilemez");
            RuleFor(s => s.LastName).NotEmpty().WithMessage("Soyisim boş geçilemez");
            RuleFor(s => s.Email).NotEmpty().WithMessage("Email boş geçilemez");
            RuleFor(s => s.Address).NotEmpty().WithMessage("Adres boş geçilemez");
            RuleFor(s => s.City).NotEmpty().WithMessage("Şehir boş geçilemez");
            RuleFor(s => s.Age).NotEmpty().WithMessage("Yaş boş geçilemez");
        }
    }
}