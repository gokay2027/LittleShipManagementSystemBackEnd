namespace LittleShipManagermentSystemApi.Application.Query.ShipQuery.Model.ResponseModel
{
    public class GetShipsByFilterResponseModel
    {
        public string Name { get; set; }
        public string RecordNumber { get; set; }
        public int ShipAge { get; set; }
        public bool IsOnTheWay { get; set; }
        public string Nationality { get; set; }
    }
}
