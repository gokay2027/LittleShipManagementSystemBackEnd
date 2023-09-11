using ListtleShipManagementSystemDomain.Entities;
using LittleShipManagementSystemData.Repositories.Abstract;
using LittleShipManagermentSystemApi.Application.Command.WorkerCommand.Model.ResponseModel;
using LittleShipManagermentSystemApi.Application.Command.WorkerCommand.Request;
using LittleShipManagermentSystemApi.Application.Command.WorkerCommand.Response;
using MediatR;

namespace LittleShipManagermentSystemApi.Application.Command.WorkerCommand
{
    public class DeleteWorkerCommandHandler : IRequestHandler<DeleteWorkerRequest, DeleteWorkerResponse>
    {

        public IRepository<Worker> _workerRepository;

        public DeleteWorkerCommandHandler(IRepository<Worker> workerRepository)
        {
            _workerRepository = workerRepository;
        }

        public async Task<DeleteWorkerResponse> Handle(DeleteWorkerRequest request, CancellationToken cancellationToken)
        {

           await _workerRepository.RemoveAndSave(request.Model.Id);

            var responseModel = new DeleteWorkerResponseModel
            {
                Message = "The worker has been deleted successfully",
                Success = true
            };


            return new DeleteWorkerResponse
            {
                ResponseModel=responseModel,
            };
           
        }
    }
}
