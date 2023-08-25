using LittleShipManagermentSystemApi.Application.Query.ShipQuery.Model.ResponseModel;

namespace LittleShipManagermentSystemApi.Application.Query.ShipQuery.Response
{
    public class GetShipsByCompanyIdResponse
    {
        public List<GetShipsByCompanyIdResponseModel> ModelList { get; set; }
    }
}