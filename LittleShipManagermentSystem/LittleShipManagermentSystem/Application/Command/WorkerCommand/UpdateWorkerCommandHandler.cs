using ListtleShipManagementSystemDomain.Entities;
using LittleShipManagementSystemData.Repositories.Abstract;
using LittleShipManagermentSystemApi.Application.Command.WorkerCommand.Model.ResponseModel;
using LittleShipManagermentSystemApi.Application.Command.WorkerCommand.Request;
using LittleShipManagermentSystemApi.Application.Command.WorkerCommand.Response;
using MediatR;

namespace LittleShipManagermentSystemApi.Application.Command.WorkerCommand
{
    public class UpdateWorkerCommandHandler : IRequestHandler<UpdateWorkerRequest, UpdateWorkerResponse>
    {
        private readonly IRepository<Worker> _workerRepository;

        public UpdateWorkerCommandHandler(IRepository<Worker> workerRepository)
        {
            _workerRepository = workerRepository;
        }

        public async Task<UpdateWorkerResponse> Handle(UpdateWorkerRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var WorkerToBeUpdated = await _workerRepository.GetById(request.Model.Id);

                WorkerToBeUpdated.Update(request.Model.Name, request.Model.Surname, request.Model.Nationality, request.Model.Experience, request.Model.BirthDate, request.Model.CompanyId, request.Model.IsOnTheWay); ;

                await _workerRepository.ModifyAndSave(WorkerToBeUpdated);

                return new UpdateWorkerResponse
                {
                    responseModel = new UpdateWorkerResponseModel {

                        IsSuccess = true,
                        Message = "Worker has been successfully Updated",
                    }
                };
            }
            catch (Exception ex)
            {
                return new UpdateWorkerResponse
                {
                    responseModel = new UpdateWorkerResponseModel
                    {
                        IsSuccess = false,
                        Message = ex.Message,
                    }
                };
            }
        }
    }
}
