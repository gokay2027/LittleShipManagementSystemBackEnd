namespace LittleShipManagermentSystemApi.Application.Query.ShipQuery.Model.ResponseModel
{
    public class GetShipsByFilterResponseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RecordNumber { get; set; }
        public int ShipAge { get; set; }
        public bool IsOnTheWay { get; set; }
        public string Nationality { get; set; }
        public int? ShipCompanyId { get; set; }
        public int? ShipDockId { get; set; }
    }
}