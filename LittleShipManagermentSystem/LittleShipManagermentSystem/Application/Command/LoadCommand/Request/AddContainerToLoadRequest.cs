using LittleShipManagermentSystemApi.Application.Command.LoadCommand.Model.Response;
using MediatR;

namespace LittleShipManagermentSystemApi.Application.Command.LoadCommand.Model.Request
{
    public class AddContainerToLoadRequest : IRequest<AddContainerToLoadResponse>
    {
        public int LoadId { get; set; }
        public List<AddContainerToLoadRequestModel> Containers { get; set; }

    }
}