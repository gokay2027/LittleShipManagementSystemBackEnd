using LittleShipManagermentSystemApi.Application.Query.WorkerQuery.Model.RequestModel;
using LittleShipManagermentSystemApi.Application.Query.WorkerQuery.Response;
using MediatR;

namespace LittleShipManagermentSystemApi.Application.Query.WorkerQuery.Request
{
    public class GetWorkerByIdRequest:IRequest<GetWorkerByIdResponse>
    {
        public GetWorkerByIdRequestModel Model { get; set; }
    }
}
