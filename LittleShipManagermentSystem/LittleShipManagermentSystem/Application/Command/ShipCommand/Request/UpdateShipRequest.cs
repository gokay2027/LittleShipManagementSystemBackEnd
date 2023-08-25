using LittleShipManagermentSystemApi.Application.Command.ShipCommand.Model.RequestModel;
using LittleShipManagermentSystemApi.Application.Command.ShipCommand.Response;
using MediatR;

namespace LittleShipManagermentSystemApi.Application.Command.ShipCommand.Request
{
    public class UpdateShipRequest:IRequest<UpdateShipResponse>
    {
        public UpdateShipRequestModel Model { get; set; } 
    }
}
