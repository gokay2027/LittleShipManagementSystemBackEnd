using LittleShipManagermentSystemApi.Application.Command.DockCommand.Model.RequestModel;
using LittleShipManagermentSystemApi.Application.Command.DockCommand.Response;
using MediatR;

namespace LittleShipManagermentSystemApi.Application.Command.DockCommand.Request
{
    public class CreateDockRequest : IRequest<CreateDockResponse>
    {
        public CreateDockRequestModel Model { get; set; }
    }
}