using LittleShipManagermentSystemApi.Application.Command.CompanyCommand.Model.RequestModel;
using MediatR;

namespace LittleShipManagermentSystemApi.Application.Command
{
    public class CreateCompanyRequest:IRequest<CreateCompanyRequest>
    {
        public CreateCompanyRequestModel Model { get; set; }
    }
}