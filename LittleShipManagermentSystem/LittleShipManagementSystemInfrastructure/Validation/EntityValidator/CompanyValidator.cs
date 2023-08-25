using FluentValidation;
using ListtleShipManagementSystemDomain.Entities;

namespace LittleShipManagementSystemInfrastructure.Validation.EntityValidator
{
    public class CompanyValidator : AbstractValidator<Company>
    {
        public CompanyValidator()
        {
            RuleFor(x => x.Name).NotEmpty().Length(4, 100).WithMessage("Name rules were not satisfied");
            RuleFor(x => x.Nation).NotEmpty().WithMessage("Nation must be defined");
            RuleFor(x => x.Location).NotEmpty();
        }
    }
}