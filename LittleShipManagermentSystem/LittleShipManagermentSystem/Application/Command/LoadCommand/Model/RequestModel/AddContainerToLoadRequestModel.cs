namespace LittleShipManagermentSystemApi.Application.Command.LoadCommand.Model
{
    public class AddContainerToLoadRequestModel
    {
        public string WeightType { get; set; }

        public string LoadType { get; set; }

        public string ContainerType { get; set; }

        public int WeightAmount { get; set; }
    }
}