using LittleShipManagermentSystemApi.Application.Command.WorkerCommand.Model.RequestModel;
using LittleShipManagermentSystemApi.Application.Command.WorkerCommand.Response;
using MediatR;

namespace LittleShipManagermentSystemApi.Application.Command.WorkerCommand.Request
{
    public class UpdateWorkerRequest:IRequest<UpdateWorkerResponse>
    {
        public UpdateWorkerRequestModel Model { get; set; }
    }
}
