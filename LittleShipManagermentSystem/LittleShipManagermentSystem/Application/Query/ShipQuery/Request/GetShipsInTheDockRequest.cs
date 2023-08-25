using LittleShipManagermentSystemApi.Application.Query.ShipQuery.Model.RequestModel;
using LittleShipManagermentSystemApi.Application.Query.ShipQuery.Response;
using MediatR;

namespace LittleShipManagermentSystemApi.Application.Query.ShipQuery.Request
{
    public class GetShipsInTheDockRequest : IRequest<GetShipsInTheDockResponse>
    {
        public GetShipsInTheDockRequestModel Model { get; set; }
    }
}