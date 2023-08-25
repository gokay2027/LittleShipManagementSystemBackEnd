using LittleShipManagermentSystemApi.Application.Command.CaptainCommand.Model.RequestModel;
using MediatR;

namespace LittleShipManagermentSystemApi.Application.Command.CaptainCommand.Model
{
    public class CaptainCreateRequest : IRequest<CaptainCreateRequest>
    {
        public CaptainCreateRequestModel Model { get; set; }

    }
}