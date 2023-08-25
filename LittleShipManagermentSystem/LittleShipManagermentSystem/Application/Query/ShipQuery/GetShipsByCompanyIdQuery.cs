using ListtleShipManagementSystemDomain.Entities;
using LittleShipManagementSystemData.Repositories.Abstract;
using LittleShipManagermentSystemApi.Application.Query.ShipQuery.Model.ResponseModel;
using LittleShipManagermentSystemApi.Application.Query.ShipQuery.Request;
using LittleShipManagermentSystemApi.Application.Query.ShipQuery.Response;
using MediatR;

namespace LittleShipManagermentSystemApi.Application.Query.ShipQuery
{
    public class GetShipsByCompanyIdQuery : IRequestHandler<GetShipsByCompanyIdRequest, GetShipsByCompanyIdResponse>
    {
        private readonly IRepository<Company> _companyRepository;
        private readonly IRepository<Dock> _dockRepository;

        public GetShipsByCompanyIdQuery(IRepository<Company> companyRepository, IRepository<Dock> dockRepository)
        {
            _companyRepository = companyRepository;
            _dockRepository = dockRepository;
        }

        public async Task<GetShipsByCompanyIdResponse> Handle(GetShipsByCompanyIdRequest request, CancellationToken cancellationToken)
        {
            var company = _companyRepository.Include(c => c.Ships).FirstOrDefault(c => c.Id == request.Model.CompanyId);

            var ships = company.Ships;

            var shipsResponseModelList = new List<GetShipsByCompanyIdResponseModel>();

            foreach (var ship in ships)
            {
                var dock = await _dockRepository.GetById(ship.CurrentDockId);

                shipsResponseModelList.Add(new GetShipsByCompanyIdResponseModel
                {
                    ShipId = ship.Id,
                    ShipName = ship.Name,
                    IsOnTheWay = ship.IsOnTheWay,
                    RecordNumber = ship.RecordNumber,
                    ShipAge = ship.ShipAge,
                    ShipNationality = ship.ShipNationality,
                    CurrentDockName = dock.Name
                });
            }

            return new GetShipsByCompanyIdResponse
            {
                ModelList = shipsResponseModelList,
            };
        }
    }
}