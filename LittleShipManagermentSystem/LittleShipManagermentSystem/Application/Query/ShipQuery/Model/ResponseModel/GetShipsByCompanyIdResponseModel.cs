namespace LittleShipManagermentSystemApi.Application.Query.ShipQuery.Model.ResponseModel
{
    public class GetShipsByCompanyIdResponseModel
    {
        public int ShipId { get; set; }
        public string ShipName { get; set; }
        public string RecordNumber { get; set; }
        public string ShipNationality { get; set; }
        public int ShipAge { get; set; }
        public bool IsOnTheWay { get; set; }
        public string CurrentDockName { get; set; }
    }
}