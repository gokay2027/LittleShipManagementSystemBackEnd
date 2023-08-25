using LittleShipManagermentSystemApi.Application.Query.ShipQuery.Model.RequestModel;
using LittleShipManagermentSystemApi.Application.Query.ShipQuery.Response;
using MediatR;

namespace LittleShipManagermentSystemApi.Application.Query.ShipQuery.Request
{
    public class GetShipsByCompanyIdRequest : IRequest<GetShipsByCompanyIdResponse>
    {
        public GetShipsByCompanyIdRequestModel Model { get; set; }
    }
}