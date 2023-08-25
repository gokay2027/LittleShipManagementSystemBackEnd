using LittleShipManagermentSystemApi.Application.Query.WorkerQuery.Model.ResponseModel;

namespace LittleShipManagermentSystemApi.Application.Query.WorkerQuery.Response
{
    public class GetWorkerBySearchResponse
    {
        //liste olarak tutulacak

        public List<GetWorkerBySearchResponseModel> Model { get; set; } = new List<GetWorkerBySearchResponseModel>();
    }
}