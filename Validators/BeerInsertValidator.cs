using Backend.DTOs;
using FluentValidation;

namespace Backend.Validators
{
    public class BeerInsertValidator: AbstractValidator<BeerInsertDto>
    {
        public BeerInsertValidator() 
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("The name is mandatory.");
            RuleFor(x => x.Name).Length(2, 20).WithMessage("The length of the name must be between 2 and 20 characters.");
            RuleFor(x => x.BrandID).NotNull().WithMessage(x => "The brand is mandatory.");
            RuleFor(x => x.BrandID).GreaterThan(0).WithMessage(x => "There was an error sending the brand.");
            RuleFor(x => x.Alcohol).GreaterThan(0).WithMessage(x => "The {PropertyName} must be greater than 0.");
        }
    }
}
