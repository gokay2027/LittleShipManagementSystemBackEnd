using FluentValidation;
using ListtleShipManagementSystemDomain.Entities;

namespace LittleShipManagementSystemInfrastructure.Validation.EntityValidator
{
    public class WorkerValidator : AbstractValidator<Worker>
    {
        public WorkerValidator()
        {
        
            RuleFor(w => w.Name).NotEmpty().WithMessage("Name can not be empty");

            RuleFor(w => w.Nationality).Length(2, 3).WithMessage("Nationality definition can be Minimum 2 Max 3 length")
                .NotEmpty().WithMessage("Nationality Can not be Empty");

            RuleFor(w => w.CompanyId).NotEmpty().WithMessage("Company Id Can not be Empty");
            RuleFor(w => w.Experience).NotEmpty().WithMessage("Experience Can not be empty");
            

        
        
        }
    }
}