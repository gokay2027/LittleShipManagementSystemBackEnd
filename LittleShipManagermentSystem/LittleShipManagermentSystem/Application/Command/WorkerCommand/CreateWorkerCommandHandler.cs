using ListtleShipManagementSystemDomain.Entities;
using LittleShipManagementSystemData.Repositories.Abstract;
using LittleShipManagermentSystemApi.Application.Command.WorkerCommand.Model;
using MediatR;

namespace LittleShipManagermentSystemApi.Application.Command.WorkerCommand
{
    public class CreateWorkerCommandHandler : IRequestHandler<CreateWorkerRequest, CreateWorkerRequest>
    {
        private readonly IRepository<Worker> _workerRepository;

        public CreateWorkerCommandHandler(IRepository<Worker> workerRepository)
        {
            _workerRepository = workerRepository;
        }

        public async Task<CreateWorkerRequest> Handle(CreateWorkerRequest request, CancellationToken cancellationToken)
        {
            var worker = new Worker(
                request.Model.Name,
                request.Model.Surname,
                request.Model.Nationality,
                request.Model.Experience,
                request.Model.BirthDate,
                request.Model.CompanyId
                );

            await _workerRepository.AddandSave(worker);

            return request;
        }
    }
}