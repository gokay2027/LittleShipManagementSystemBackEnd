namespace LittleShipManagermentSystemApi.Application.Command.ShipCommand.Model.RequestModel
{
    public class UpdateShipRequestModel
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string recordNumber { get; set; }
        public string shipNationality { get; set; }
        public int shipAge { get; set; }
        public bool isOnTheWay { get; set; }
        public int? shipCompanyId { get; set; }
        public int? currentDockId { get; set; }
    }
}