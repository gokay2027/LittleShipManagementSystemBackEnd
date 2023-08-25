using ListtleShipManagementSystemDomain.Entities;
using LittleShipManagementSystemData.Repositories.Abstract;
using LittleShipManagermentSystemApi.Application.Query.WorkerQuery.Model.ResponseModel;
using LittleShipManagermentSystemApi.Application.Query.WorkerQuery.Request;
using LittleShipManagermentSystemApi.Application.Query.WorkerQuery.Response;
using MediatR;

namespace LittleShipManagermentSystemApi.Application.Query.WorkerQuery
{
    public class GetWorkersByCompanyIdQuery : IRequestHandler<GetWorkersByCompanyIdRequest, GetWorkersByCompanyIdResponse>
    {
        private readonly IRepository<Worker> _workerRepository;
        private readonly IRepository<Company> _companyRepository;

        public GetWorkersByCompanyIdQuery(IRepository<Worker> workerRepository, IRepository<Company> companyRepository)
        {
            _workerRepository = workerRepository;
            _companyRepository = companyRepository;
        }

        public async Task<GetWorkersByCompanyIdResponse> Handle(GetWorkersByCompanyIdRequest request, CancellationToken cancellationToken)
        {
            var workerlist = await _workerRepository.GetByFilter(w => w.CompanyId == request.Model.CompanyId);
            var company = await _companyRepository.GetById(request.Model.CompanyId);

            var workerResponseModelList = new List<GetWorkersByCompanyIdResponseModel>();

            foreach (var worker in workerlist)
            {
                workerResponseModelList.Add(new GetWorkersByCompanyIdResponseModel
                {
                    Name = worker.Name,
                    BirthDate = worker.BirthDate,
                    CompanyName = company.Name,
                    Surname = worker.Surname,
                    Experience = worker.Experience,
                    IsOnTheWay = worker.IsOnTheWay,
                    Nationality = worker.Nationality
                });
            }

            return new GetWorkersByCompanyIdResponse
            {
                Model = workerResponseModelList
            };
        }
    }
}