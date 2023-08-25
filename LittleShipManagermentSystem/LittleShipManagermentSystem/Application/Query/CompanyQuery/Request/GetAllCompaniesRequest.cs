using LittleShipManagermentSystemApi.Application.Query.CompanyQuery.Response;
using MediatR;

namespace LittleShipManagermentSystemApi.Application.Query.CompanyQuery.Request
{
    public class GetAllCompaniesRequest : IRequest<GetAllCompaniesResponse>
    {
    }
}