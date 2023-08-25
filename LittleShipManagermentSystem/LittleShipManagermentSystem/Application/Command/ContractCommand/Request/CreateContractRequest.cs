using LittleShipManagermentSystemApi.Application.Command.ContractCommand.Model.RequestModel;
using LittleShipManagermentSystemApi.Application.Command.ContractCommand.Response;
using MediatR;

namespace LittleShipManagermentSystemApi.Application.Command.ContractCommand.Request
{
    public class CreateContractRequest : IRequest<CreateContractResponse>
    {
        public CreateContractRequestModel Model { get; set; }
    }
}