using ListtleShipManagementSystemDomain.Entities;
using LittleShipManagementSystemData.Repositories.Abstract;
using LittleShipManagermentSystemApi.Application.Query.CompanyQuery.Model.ResponseModel;
using LittleShipManagermentSystemApi.Application.Query.CompanyQuery.Request;
using LittleShipManagermentSystemApi.Application.Query.CompanyQuery.Response;
using MediatR;

namespace LittleShipManagermentSystemApi.Application.Query.CompanyQuery
{
    public class GetAllCompaniesQuery : IRequestHandler<GetAllCompaniesRequest, GetAllCompaniesResponse>
    {
        private readonly IRepository<Company> _companyRepository;

        public GetAllCompaniesQuery(IRepository<Company> companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public async Task<GetAllCompaniesResponse> Handle(GetAllCompaniesRequest request, CancellationToken cancellationToken)
        {
            var ShipsList = await _companyRepository.GetAll();

            List<GetAllCompaniesResponseModel> responseList = new List<GetAllCompaniesResponseModel>();

            foreach (var ships in ShipsList)
            {
                var responseObject = new GetAllCompaniesResponseModel
                {
                    Location = ships.Location,
                    Name = ships.Name,
                    Nation = ships.Nation,
                };

                responseList.Add(responseObject);
            }

            return new GetAllCompaniesResponse
            {
                Message = "Success",
                modelList = responseList
            };
        }
    }
}