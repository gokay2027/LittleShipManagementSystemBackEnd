using LittleShipManagermentSystemApi.Application.Query.DockQuery.Request;
using LittleShipManagermentSystemApi.Application.Query.DockQuery.Response;
using MediatR;

namespace LittleShipManagermentSystemApi.Application.Query.DockQuery
{
    public class GetAllDocksQuery : IRequestHandler<GetAllDocksRequest, GetAllDocksResponse>
    {




        public Task<GetAllDocksResponse> Handle(GetAllDocksRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}