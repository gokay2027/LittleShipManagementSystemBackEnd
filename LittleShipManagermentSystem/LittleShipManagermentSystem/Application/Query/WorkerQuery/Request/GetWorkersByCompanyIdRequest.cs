using LittleShipManagermentSystemApi.Application.Query.WorkerQuery.Model.RequestModel;
using LittleShipManagermentSystemApi.Application.Query.WorkerQuery.Response;
using MediatR;

namespace LittleShipManagermentSystemApi.Application.Query.WorkerQuery.Request
{
    public class GetWorkersByCompanyIdRequest : IRequest<GetWorkersByCompanyIdResponse>
    {
        public GetWorkersByCompanyIdRequestModel Model { get; set; }
    }
}