using ListtleShipManagementSystemDomain.Entities;
using LittleShipManagementSystemData.Repositories.Abstract;
using LittleShipManagermentSystemApi.Application.Query.DockQuery.Model.ResponseModel;
using LittleShipManagermentSystemApi.Application.Query.DockQuery.Request;
using LittleShipManagermentSystemApi.Application.Query.DockQuery.Response;
using MediatR;

namespace LittleShipManagermentSystemApi.Application.Query.DockQuery
{
    public class GetAllDocksQuery : IRequestHandler<GetAllDocksRequest, GetAllDocksResponse>
    {
        private readonly IRepository<Dock> _dockRepository;

        public GetAllDocksQuery(IRepository<Dock> dockRepository)
        {
            _dockRepository = dockRepository;
        }

        public async Task<GetAllDocksResponse> Handle(GetAllDocksRequest request, CancellationToken cancellationToken)
        {
            var AllDocks = await _dockRepository.GetAll();

            var responseList = new List<GetAllDocksResponseModel>();

            foreach (var dock in AllDocks)
            {
                responseList.Add(new GetAllDocksResponseModel()
                {
                    Id=dock.Id,
                    Location = dock.Location,
                    Name = dock.Name,
                });
            }

            return new GetAllDocksResponse
            {
                Message = "Success",
                modelList = responseList
            };
        }
    }
}