namespace LittleShipManagermentSystemApi.Application.Query.ShipQuery.Model.ResponseModel
{
    public class GetShipsInTheDockResponseModel
    {
        public string ShipName { get; set; }
        public string RecordNumber { get; set; }
        public string ShipNationality { get; set; }
        public int ShipAge { get; set; }
        public string CurrentDockName { get; set; }

    }
}
