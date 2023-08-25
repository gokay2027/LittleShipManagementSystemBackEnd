using LittleShipManagermentSystemApi.Application.Query.ShipQuery.Model.ResponseModel;

namespace LittleShipManagermentSystemApi.Application.Query.ShipQuery.Response
{
    public class GetShipsInTheDockResponse
    {
        public List<GetShipsInTheDockResponseModel> ModelList { get; set; }
    }
}