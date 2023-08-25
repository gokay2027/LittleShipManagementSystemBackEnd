using LittleShipManagermentSystemApi.Application.Command.CompanyCommand.Model.RequestModel;
using MediatR;

namespace LittleShipManagermentSystemApi.Application.Command
{
    public class UpdateCompanyRequest : IRequest<CreateCompanyRequest>
    {
        public UpdateCompanyRequestModel Model { get; set; }
    }
}