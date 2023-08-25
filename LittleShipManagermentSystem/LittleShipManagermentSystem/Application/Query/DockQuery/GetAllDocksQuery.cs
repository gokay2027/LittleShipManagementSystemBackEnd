using ListtleShipManagementSystemDomain.Entities;
using LittleShipManagementSystemData.Repositories.Abstract;
using LittleShipManagermentSystemApi.Application.Query.DockQuery.Request;
using LittleShipManagermentSystemApi.Application.Query.DockQuery.Response;
using MediatR;

namespace LittleShipManagermentSystemApi.Application.Query.DockQuery
{
    public class GetAllDocksQuery : IRequestHandler<GetAllDocksRequest, GetAllDocksResponse>
    {
        private readonly IRepository<Dock> _dockRepository;


        public Task<GetAllDocksResponse> Handle(GetAllDocksRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}