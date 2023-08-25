using ListtleShipManagementSystemDomain.Entities;
using LittleShipManagementSystemData.Repositories.Abstract;
using LittleShipManagermentSystemApi.Application.Command.ContractCommand.Model.ResponseModel;
using LittleShipManagermentSystemApi.Application.Command.ContractCommand.Request;
using LittleShipManagermentSystemApi.Application.Command.ContractCommand.Response;
using MediatR;

namespace LittleShipManagermentSystemApi.Application.Command.ContractCommand
{
    public class CreateContractCommandHandler : IRequestHandler<CreateContractRequest, CreateContractResponse>
    {
        private readonly IRepository<Contract> _contractRepository;

        public CreateContractCommandHandler(IRepository<Contract> contractRepository)
        {
            _contractRepository = contractRepository;
        }

        public async Task<CreateContractResponse> Handle(CreateContractRequest request, CancellationToken cancellationToken)
        {
            var contract = new Contract(request.Model.JourneyId,
                request.Model.ShipLogisticCompanyId,
                request.Model.CustomerCompanyId,
                request.Model.LoadId,
                request.Model.IsContractCompleted,
                request.Model.MoneyNationality,
                request.Model.MoneyAmount);

            await _contractRepository.AddandSave(contract);

            var response = new CreateContractResponse
            {
                Model = new CreateContractResponseModel
                {
                    Message = "Contract has been added succesfully",
                    Success = true,
                }
            };

            return response;
        }
    }
}