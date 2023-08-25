using LittleShipManagermentSystemApi.Application.Query.ShipQuery.Model.ResponseModel;

namespace LittleShipManagermentSystemApi.Application.Query.ShipQuery.Response
{
    public class GetAllShipsResponse
    {
        public string Message { get; set; }

        public List<GetShipsByFilterResponseModel> ModelList { get; set; } = new List<GetShipsByFilterResponseModel>();
    }
}
