using LinqKit;
using ListtleShipManagementSystemDomain.Entities;
using LittleShipManagementSystemData.Repositories.Abstract;
using LittleShipManagermentSystemApi.Application.Query.WorkerQuery.Model.ResponseModel;
using LittleShipManagermentSystemApi.Application.Query.WorkerQuery.Request;
using LittleShipManagermentSystemApi.Application.Query.WorkerQuery.Response;
using MediatR;

namespace LittleShipManagermentSystemApi.Application.Query.WorkerQuery
{
    public class GetWorkerBySearchQuery : IRequestHandler<GetWorkerBySearchRequest, GetWorkerBySearchResponse>
    {
        private readonly IRepository<Worker> _workerRepository;
        private readonly IRepository<Company> _companyRepository;

        public GetWorkerBySearchQuery(IRepository<Worker> workerRepository, IRepository<Company> companyRepository)
        {
            _workerRepository = workerRepository;
            _companyRepository = companyRepository;
        }

        public async Task<GetWorkerBySearchResponse> Handle(GetWorkerBySearchRequest request, CancellationToken cancellationToken)
        {
            #region Filter Expressions

            var filter = PredicateBuilder.New<Worker>(true);
            if (request.Model.SearchNameProperty != null && request.Model.SearchNameProperty != "")
            {
                filter = filter.And(a => a.Name.Contains(request.Model.SearchNameProperty));
            }

            if (request.Model.SearchSurnameProperty != null && request.Model.SearchSurnameProperty != "")
            {
                filter = filter.And(a => a.Surname.Contains(request.Model.SearchSurnameProperty));
            }

            if (request.Model.SearchNationalityProperty != null && request.Model.SearchNationalityProperty != "")
            {
                filter = filter.And(a => a.Nationality.Contains(request.Model.SearchNationalityProperty));
            }

            if(request.Model.SearchExperienceProperty!=null && request.Model.SearchExperienceProperty != "")
            {
                filter=filter.And(a=>a.Experience==request.Model.SearchExperienceProperty);
            }

            if(request.Model.SearchCompanyModel!=null && request.Model.SearchCompanyModel != "")
            {
                filter = filter.And(a => a.Company.Name.Contains(request.Model.SearchCompanyModel));
            }


            #endregion Filter Expressions

            var worker =  _workerRepository.Include(a=>a.Company).Where(filter);
            
            var searchlist = worker.ToList();

            var resultList = new List<GetWorkerBySearchResponseModel>();

            foreach (var search in searchlist)
            {
                var cmp = await _companyRepository.GetById(search.CompanyId);

                resultList.Add(new GetWorkerBySearchResponseModel
                {
                    Name = search.Name,
                    Surname = search.Surname,
                    BirthDate = search.BirthDate,
                    Experience = search.Experience,
                    IsOnTheWay = search.IsOnTheWay,
                    Nationality = search.Nationality,
                    CompanyName = cmp.Name
                });
            }

            return new GetWorkerBySearchResponse
            {
                Model = resultList
            };
        }
    }
}