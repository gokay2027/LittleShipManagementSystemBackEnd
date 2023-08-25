using LittleShipManagermentSystemApi.Application.Query.DockQuery.Model.ResponseModel;

namespace LittleShipManagermentSystemApi.Application.Query.DockQuery.Response
{
    public class GetAllDocksResponse
    {
        public string Message { get; set; }

        public List<GetAllDocksResponseModel> modelList { get; set; } = new List<GetAllDocksResponseModel>();
    }
}