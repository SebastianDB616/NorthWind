using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.UseCases.CreateOrder
{
    public class CreateOrderValidator : AbstractValidator<CreateOrderInputPort>
    {
        public CreateOrderValidator() 
        {
            RuleFor(c => c.RequestData.CustomerId).NotEmpty()
                .WithMessage("Debe proporcionar el identificador del cliente");
            RuleFor(c => c.RequestData.ShipAddress).NotEmpty()
                .WithMessage("Debe proporcionar la dirección de envío");
            RuleFor(c => c.RequestData.ShipCity).NotEmpty().MinimumLength(3)
                .WithMessage("Debe proporcionar mínimo tres caracteres del nombre de la ciudad");
            RuleFor(c => c.RequestData.ShipCountry).NotEmpty().MinimumLength(3)
                .WithMessage("Debe proporcionar mínimo tres caracteres del nombre del país");
            RuleFor(c => c.RequestData.OrderDetails).NotEmpty()
                .Must(d => d != null && d.Any())
                .WithMessage("Deben especificarse los productos de la orden");
        }
    }
}
