using ListtleShipManagementSystemDomain.Entities;
using LittleShipManagementSystemData.Repositories.Abstract;
using MediatR;

namespace LittleShipManagermentSystemApi.Application.Command.CompanyCommand
{
    public class UpdateCompanyCommandHandler : IRequestHandler<UpdateCompanyRequest, CreateCompanyRequest>
    {
        private readonly IRepository<Company> _companyRepository;

        public UpdateCompanyCommandHandler(IRepository<Company> efCoreCompanyRepository)
        {
            _companyRepository = efCoreCompanyRepository;
        }

        public async Task<CreateCompanyRequest> Handle(UpdateCompanyRequest request, CancellationToken cancellationToken)
        {
            var company = await _companyRepository.GetById(request.Model.Id);

            company.Update(request.Model.Name, request.Model.Nation, request.Model.City, request.Model.Country, request.Model.HoodName, request.Model.Street, request.Model.No, request.Model.Description);

            await _companyRepository.ModifyAndSave(company);

            return new CreateCompanyRequest
            {
                Model=request.Model
            };
        }
    }
}