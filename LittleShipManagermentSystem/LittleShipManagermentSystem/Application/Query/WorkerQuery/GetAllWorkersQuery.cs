using ListtleShipManagementSystemDomain.Entities;
using LittleShipManagementSystemData.Repositories.Abstract;
using LittleShipManagermentSystemApi.Application.Query.WorkerQuery.Model.ResponseModel;
using LittleShipManagermentSystemApi.Application.Query.WorkerQuery.Request;
using LittleShipManagermentSystemApi.Application.Query.WorkerQuery.Response;
using MediatR;

namespace LittleShipManagermentSystemApi.Application.Query.WorkerQuery
{
    public class GetAllWorkersQuery : IRequestHandler<GetAllWorkersRequest, GetAllWorkersResponse>
    {

        private readonly IRepository<Worker> _workerRepository;


        public GetAllWorkersQuery(IRepository<Worker> workerRepository)
        {
            _workerRepository = workerRepository;
        }

        public async Task<GetAllWorkersResponse> Handle(GetAllWorkersRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var AllWorkers = _workerRepository.Include(a => a.Company).ToList();

                List<GetAllWorkersResponseModel> responseModelList = new List<GetAllWorkersResponseModel>();

                foreach (var worker in AllWorkers)
                {
                    responseModelList.Add(new GetAllWorkersResponseModel
                    {
                        name = worker.Name,
                        surname = worker.Surname,
                        isOnTheWay = worker.IsOnTheWay,
                        birthDate = worker.BirthDate,
                        companyName = worker.Company.Name,
                        experience = worker.Experience,
                        nationality = worker.Nationality,

                    });
                }

                return
                new GetAllWorkersResponse
                {
                    IsSuccess = true,
                    Message = "Data were successfully Queried",
                    ModelList = responseModelList
                };
            }
            catch (Exception ex)
            {
                return new GetAllWorkersResponse
                {
                    IsSuccess = false,
                    Message = ex.Message,
                };
            }
        }
    }
}
