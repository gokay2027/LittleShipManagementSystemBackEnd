using ListtleShipManagementSystemDomain.Entities;
using LittleShipManagementSystemData.Repositories.Abstract;
using LittleShipManagermentSystemApi.Application.Query.ShipQuery.Model.ResponseModel;
using LittleShipManagermentSystemApi.Application.Query.ShipQuery.Request;
using LittleShipManagermentSystemApi.Application.Query.ShipQuery.Response;
using MediatR;

namespace LittleShipManagermentSystemApi.Application.Query.ShipQuery
{
    public class GetShipsInTheDockQuery : IRequestHandler<GetShipsInTheDockRequest, GetShipsInTheDockResponse>
    {
        public IRepository<Ship> _shipRepository;

        public GetShipsInTheDockQuery(IRepository<Ship> shipRepository)
        {
            _shipRepository = shipRepository;
        }

        public async Task<GetShipsInTheDockResponse> Handle(GetShipsInTheDockRequest request, CancellationToken cancellationToken)
        {
            var ships = _shipRepository.Include(x => x.Dock);

            var ShipList = ships.Where(x => x.CurrentDockId == request.Model.DockId).ToList();

            List<GetShipsInTheDockResponseModel> ResponseList = new List<GetShipsInTheDockResponseModel>();

            foreach (var ship in ShipList)
            {
                var ResponseListItemModel = new GetShipsInTheDockResponseModel
                {
                    CurrentDockName = ship.Dock.Name,
                    ShipName = ship.Name,
                    RecordNumber = ship.RecordNumber,
                    ShipAge = ship.ShipAge,
                    ShipNationality = ship.ShipNationality,
                };

                ResponseList.Add(ResponseListItemModel);
            }

            var Response = new GetShipsInTheDockResponse
            {
                ModelList = ResponseList
            };

            return Response;
        }
    }
}