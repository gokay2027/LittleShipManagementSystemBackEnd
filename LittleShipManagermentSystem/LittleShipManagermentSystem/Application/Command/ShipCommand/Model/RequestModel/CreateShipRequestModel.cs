namespace LittleShipManagermentSystemApi.Application.Command.ShipCommand.Model.RequestModel
{
    public class CreateShipRequestModel
    {
        public string Name { get; set; }

        public string RecordNumber { get; set; }

        public string ShipNationality { get; set; }

        public int ShipAge { get; set; }

        public bool IsOnTheWay { get; set; }

        public int? ShipCompanyId { get; set; }

        public int? CurrentDockId { get; set; }
    }
}