using LittleShipManagermentSystemApi.Application.Command.JourneyCommand.Model.Request_Model;
using LittleShipManagermentSystemApi.Application.Command.JourneyCommand.Response;
using MediatR;

namespace LittleShipManagermentSystemApi.Application.Command.JourneyCommand.Request
{
    public class CreateJourneyRequest : IRequest<CreateJourneyResponse>
    {
        public CreateJourneyRequestModel Model { get; set; }
    }
}