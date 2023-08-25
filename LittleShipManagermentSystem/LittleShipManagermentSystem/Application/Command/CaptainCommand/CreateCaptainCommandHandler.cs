using ListtleShipManagementSystemDomain.Entities;
using LittleShipManagementSystemData.Repositories.Abstract;
using LittleShipManagementSystemInfrastructure.Validation.EntityValidator;
using LittleShipManagermentSystemApi.Application.Command.CaptainCommand.Model;
using MediatR;

namespace LittleShipManagermentSystemApi.Application.Command.CaptainCommand
{
    public class CreateCaptainCommandHandler : IRequestHandler<CaptainCreateRequest, CaptainCreateRequest>
    {
        private readonly IRepository<Captain> _captainRepository;

        public CreateCaptainCommandHandler(IRepository<Captain> captainRepository)
        {
            _captainRepository = captainRepository;
        }

        public async Task<CaptainCreateRequest> Handle(CaptainCreateRequest request, CancellationToken cancellationToken)
        {
            CaptainValidator validator = new CaptainValidator();

            var captain = new Captain(request.Model.Name, request.Model.Surname, request.Model.Nationality, request.Model.ExperienceYears, request.Model.BirthDate, request.Model.CompanyId);

            var result = validator.Validate(captain);

            if (result.IsValid)
            {
                await _captainRepository.AddandSave(captain);
                return request;
            }
            else
            {
                throw new Exception(result.Errors.ElementAt(0).ToString());
            }
        }
    }
}