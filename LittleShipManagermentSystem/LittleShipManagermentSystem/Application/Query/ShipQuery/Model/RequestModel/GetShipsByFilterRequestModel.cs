namespace LittleShipManagermentSystemApi.Application.Query.ShipQuery.Model.RequestModel
{
    public class GetShipsByFilterRequestModel
    {
        public string? Name { get; set; }
        public string? RecordNumber { get; set; }
        public int? ShipAge { get; set; }
        public bool? IsOnTheWay { get; set; }
        public string? Nationality { get; set; }
    }
}