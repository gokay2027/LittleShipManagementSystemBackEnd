using ListtleShipManagementSystemDomain.Entities;

namespace LittleShipManagermentSystemApi.Application.Command.LoadCommand.Model.ResponseModels
{
    public class AddContainerToLoadResponseModel
    {
        public string WeightType { get; set; }

        public string LoadType { get; set; }

        public string ContainerType { get; set; }

        public int WeightAmount { get; set; }
    }
}