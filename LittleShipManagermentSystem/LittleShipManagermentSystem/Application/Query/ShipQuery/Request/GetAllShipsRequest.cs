using LittleShipManagermentSystemApi.Application.Query.ShipQuery.Response;
using MediatR;

namespace LittleShipManagermentSystemApi.Application.Query.ShipQuery.Request
{
    public class GetAllShipsRequest:IRequest<GetAllShipsResponse>
    {
    }
}
