using LinqKit;
using ListtleShipManagementSystemDomain.Entities;
using LittleShipManagementSystemData.Repositories.Abstract;
using LittleShipManagermentSystemApi.Application.Query.ShipQuery.Model.ResponseModel;
using LittleShipManagermentSystemApi.Application.Query.ShipQuery.Request;
using LittleShipManagermentSystemApi.Application.Query.ShipQuery.Response;
using MediatR;

namespace LittleShipManagermentSystemApi.Application.Query.ShipQuery
{
    public class GetShipsByFilterQuery : IRequestHandler<GetShipsByFilterRequest, GetShipsByFilterResponse>
    {
        private IRepository<Ship> _shipRepository;

        public GetShipsByFilterQuery(IRepository<Ship> shipRepository)
        {
            _shipRepository = shipRepository;
        }

        public async Task<GetShipsByFilterResponse> Handle(GetShipsByFilterRequest request, CancellationToken cancellationToken)
        {
            var filter = PredicateBuilder.New<Ship>(true);

            if (request.Model.Name != null && request.Model.Name != "")
            {
                filter = filter.And(a => a.Name.Contains(request.Model.Name));
            }

            if (request.Model.RecordNumber != null && request.Model.RecordNumber != "")
            {
                filter = filter.And(a => a.RecordNumber.Contains(request.Model.RecordNumber));
            }

            if (request.Model.Nationality != null && request.Model.Nationality != "")
            {
                filter = filter.And(a => a.ShipNationality.Contains(request.Model.Nationality));
            }

            if (request.Model.ShipAge != null)
            {
                filter = filter.And(a => a.ShipAge.Equals(request.Model.ShipAge));
            }

            if (request.Model.IsOnTheWay != null)
            {
                filter = filter.And(a => a.IsOnTheWay.Equals(request.Model.IsOnTheWay));
            }

            var shipList = await _shipRepository.GetByFilter(filter);

            var shipFilterList = shipList.ToList();

            var ResponseModelList = new List<GetShipsByFilterResponseModel>();

            foreach (var ship in shipFilterList)
            {
                var responseObject = new GetShipsByFilterResponseModel
                {
                    Name = ship.Name,
                    IsOnTheWay = ship.IsOnTheWay,
                    Nationality = ship.ShipNationality,
                    RecordNumber = ship.RecordNumber,
                    ShipAge = ship.ShipAge,
                };

                ResponseModelList.Add(responseObject);
            }

            return new GetShipsByFilterResponse
            {
                message = "Success",
                ModelList = ResponseModelList
            };
        }
    }
}