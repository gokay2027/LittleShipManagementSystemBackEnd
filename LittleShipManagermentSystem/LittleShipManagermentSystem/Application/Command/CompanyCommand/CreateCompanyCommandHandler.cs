using ListtleShipManagementSystemDomain.Entities;
using LittleShipManagementSystemData.Repositories.Abstract;
using MediatR;

namespace LittleShipManagermentSystemApi.Application.Command.CompanyCommand
{
    public class CreateCompanyCommandHandler : IRequestHandler<CreateCompanyRequest, CreateCompanyRequest>
    {
        private readonly IRepository<Company> _efCoreCompanyRepository;

        public CreateCompanyCommandHandler(IRepository<Company> efCoreCompanyRepository)
        {
            _efCoreCompanyRepository = efCoreCompanyRepository;
        }

        public async Task<CreateCompanyRequest> Handle(CreateCompanyRequest request, CancellationToken cancellationToken)
        {
            var company = new Company(request.Model.Name, request.Model.Nation, request.Model.City, request.Model.Country, request.Model.HoodName, request.Model.Street, request.Model.No, request.Model.Description);

            await _efCoreCompanyRepository.AddandSave(company);

            return request;
        }
    }
}