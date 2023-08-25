using LittleShipManagermentSystemApi.Application.Command.WorkerCommand.Model.RequestModel;
using MediatR;

namespace LittleShipManagermentSystemApi.Application.Command.WorkerCommand.Model
{
    public class CreateWorkerRequest : IRequest<CreateWorkerRequest>
    {
        public CreateWorkerRequestModel Model {get;set;}
    }
}