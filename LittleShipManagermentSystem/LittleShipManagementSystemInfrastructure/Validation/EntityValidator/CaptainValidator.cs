using FluentValidation;
using ListtleShipManagementSystemDomain.Entities;

namespace LittleShipManagementSystemInfrastructure.Validation.EntityValidator
{
    public class CaptainValidator : AbstractValidator<Captain>
    {
        public CaptainValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Captain Name must be defined");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Captain Surname must be Defined");
            RuleFor(x => x.ExperienceYears).NotEmpty();

        }
    }
}