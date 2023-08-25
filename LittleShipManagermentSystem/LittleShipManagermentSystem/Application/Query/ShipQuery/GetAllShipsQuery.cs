using ListtleShipManagementSystemDomain.Entities;
using LittleShipManagementSystemData.Repositories.Abstract;
using LittleShipManagermentSystemApi.Application.Query.ShipQuery.Model.ResponseModel;
using LittleShipManagermentSystemApi.Application.Query.ShipQuery.Request;
using LittleShipManagermentSystemApi.Application.Query.ShipQuery.Response;
using MediatR;

namespace LittleShipManagermentSystemApi.Application.Query.ShipQuery
{
    public class GetAllShipsQuery : IRequestHandler<GetAllShipsRequest, GetAllShipsResponse>
    {
        private readonly IRepository<Ship> _shipRepository;

        public GetAllShipsQuery(IRepository<Ship> shipRepository)
        {
            _shipRepository = shipRepository;
        }

        public async Task<GetAllShipsResponse> Handle(GetAllShipsRequest request, CancellationToken cancellationToken)
        {
            var shipList = await _shipRepository.GetAll();

            List<GetShipsByFilterResponseModel> responseList = new List<GetShipsByFilterResponseModel>();

            foreach (var ship in shipList)
            {
                var shipObject = new GetShipsByFilterResponseModel
                {
                    Id = ship.Id,
                    IsOnTheWay = ship.IsOnTheWay,
                    Name = ship.Name,
                    Nationality = ship.ShipNationality,
                    RecordNumber = ship.RecordNumber,
                    ShipAge = ship.ShipAge,
                };

                responseList.Add(shipObject);
            }

            return new GetAllShipsResponse
            {
                Message = "Successfull",
                ModelList = responseList
            };
        }
    }
}