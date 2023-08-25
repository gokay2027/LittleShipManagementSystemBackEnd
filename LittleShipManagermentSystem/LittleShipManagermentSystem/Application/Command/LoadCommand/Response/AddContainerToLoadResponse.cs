using LittleShipManagermentSystemApi.Application.Command.LoadCommand.Model.ResponseModels;

namespace LittleShipManagermentSystemApi.Application.Command.LoadCommand.Model.Response
{
    public class AddContainerToLoadResponse
    {
        public List<AddContainerToLoadResponseModel> Containers { get; set; }
    }
}