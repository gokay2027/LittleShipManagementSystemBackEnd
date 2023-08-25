using LittleShipManagermentSystemApi.Application.Command.ShipCommand.Model.RequestModel;
using LittleShipManagermentSystemApi.Application.Command.ShipCommand.Response;
using MediatR;

namespace LittleShipManagermentSystemApi.Application.Command.ShipCommand.Request
{
    public class CreateShipRequest:IRequest<CreateShipResponse>
    {
        public CreateShipRequestModel Model { get; set; }

    }
}
