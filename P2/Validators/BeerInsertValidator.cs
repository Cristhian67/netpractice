using FluentValidation;
using P2.DTOs;

namespace P2.Vlidators
{
    public class BeerInsertValidator : AbstractValidator<BeerInsertDto>
    {
        public BeerInsertValidator() { 
            RuleFor(x=>x.Name).NotEmpty().WithMessage("El nombre es obligatorio");
            RuleFor(x => x.Name).Length(2, 20).WithMessage("El nombre debe medir de 2 a 20 caracteres");
            RuleFor(x => x.BrandId).NotNull().WithMessage("la marca es obligatoria");
            RuleFor(x => x.BrandId).GreaterThan(0).WithMessage("Error con el valor enviado de marca");
            RuleFor(x => x.Alcohol).GreaterThan(0).WithMessage("El {PropertyName} debe ser mayor a 0");
        }
    }
}
