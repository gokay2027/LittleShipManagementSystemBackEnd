using LittleShipManagermentSystemApi.Application.Command.WorkerCommand.Model.RequestModel;
using LittleShipManagermentSystemApi.Application.Command.WorkerCommand.Response;
using MediatR;

namespace LittleShipManagermentSystemApi.Application.Command.WorkerCommand.Request
{
    public class DeleteWorkerRequest:IRequest<DeleteWorkerResponse>
    {
        public DeleteWorkerRequestModel Model { get; set; }

    }
}
