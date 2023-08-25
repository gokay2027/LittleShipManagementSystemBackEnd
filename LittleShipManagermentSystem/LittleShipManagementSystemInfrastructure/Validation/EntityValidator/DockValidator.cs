using FluentValidation;
using ListtleShipManagementSystemDomain.Entities;

namespace LittleShipManagementSystemInfrastructure.Validation.EntityValidator
{
    public class DockValidator : AbstractValidator<Dock>
    {
        public DockValidator()
        {
            RuleFor(x => x.Name).NotNull().Length(1, 100).WithMessage("Name Can not be Empty");
            RuleFor(x => x.Location).NotNull().WithMessage("Location can not be empty");
        }
    }
}