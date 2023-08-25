using FluentValidation;
using ListtleShipManagementSystemDomain.Entities;

namespace LittleShipManagementSystemInfrastructure.Validation.EntityValidator
{
    public class ShipValidator : AbstractValidator<Ship>
    {
        public ShipValidator()
        {
            RuleFor(s => s.ShipCompanyId).NotEmpty().WithMessage("Ship company must be defined");
            RuleFor(s => s.ShipAge).NotEmpty().WithMessage("Ship age must be defined");
            RuleFor(s => s.ShipNationality).NotEmpty();
            RuleFor(s => s.RecordNumber).NotEmpty().Length(8).WithMessage("Ship Record number must be 8 length");
            RuleFor(s => s.Name).NotEmpty().WithMessage("Ship name must be entered can not be empty");
            RuleFor(s=>s.ShipAge).NotEmpty().WithMessage("Ship age must be entered");
        }
    }
}