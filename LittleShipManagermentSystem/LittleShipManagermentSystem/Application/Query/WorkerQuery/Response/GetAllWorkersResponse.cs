using LittleShipManagermentSystemApi.Application.Query.WorkerQuery.Model.ResponseModel;

namespace LittleShipManagermentSystemApi.Application.Query.WorkerQuery.Response
{
    public class GetAllWorkersResponse
    {

        public string Message { get; set; }
        public bool IsSuccess { get; set; }
        public List<GetAllWorkersResponseModel> ModelList { get; set; } = new List<GetAllWorkersResponseModel>();

    }
}
