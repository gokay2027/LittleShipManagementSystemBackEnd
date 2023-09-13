using ListtleShipManagementSystemDomain.Entities;
using LittleShipManagementSystemData.Repositories.Abstract;
using LittleShipManagermentSystemApi.Application.Query.WorkerQuery.Model.ResponseModel;
using LittleShipManagermentSystemApi.Application.Query.WorkerQuery.Request;
using LittleShipManagermentSystemApi.Application.Query.WorkerQuery.Response;
using MediatR;

namespace LittleShipManagermentSystemApi.Application.Query.WorkerQuery
{
    public class GetWorkerByIdQuery : IRequestHandler<GetWorkerByIdRequest, GetWorkerByIdResponse>
    {
        private readonly IRepository<Worker> _workerRepository;

        public GetWorkerByIdQuery(IRepository<Worker> workerRepository)
        {
            _workerRepository = workerRepository;
        }

        public async Task<GetWorkerByIdResponse> Handle(GetWorkerByIdRequest request, CancellationToken cancellationToken)
        {


            var worker = await _workerRepository.GetById(request.Model.Id);

            return new GetWorkerByIdResponse
            {
                ResponseModel = new GetWorkerByIdResponseModel
                {
                    Id = worker.Id,
                    BirthDate = worker.BirthDate,
                    CompanyId = worker.CompanyId,
                    Experience = worker.Experience,
                    IsOnTheWay = worker.IsOnTheWay,
                    Name = worker.Name,
                    Nationality = worker.Nationality,
                    Surname = worker.Surname,
                }
            };


        }
    }
}
