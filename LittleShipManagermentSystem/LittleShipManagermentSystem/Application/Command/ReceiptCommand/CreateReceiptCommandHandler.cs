using ListtleShipManagementSystemDomain.Entities;
using LittleShipManagementSystemData.Repositories.Abstract;
using LittleShipManagermentSystemApi.Application.Command.ReceiptCommand.Model.ResponseModel;
using LittleShipManagermentSystemApi.Application.Command.ReceiptCommand.Request;
using LittleShipManagermentSystemApi.Application.Command.ReceiptCommand.Response;
using MediatR;

namespace LittleShipManagermentSystemApi.Application.Command.ReceiptCommand
{
    public class CreateReceiptCommandHandler : IRequestHandler<CreateReceiptRequest, CreateReceiptResponse>
    {
        private readonly IRepository<Receipt> _receiptRepository;
        private readonly IRepository<Journey> _journeyRepository;
        private readonly IRepository<Worker> _workerRepository;
        private readonly IRepository<Contract> _contractRepository;
        private readonly IRepository<Ship> _shipRepository;
        private readonly IRepository<Captain> _captainRepository;

        public CreateReceiptCommandHandler(IRepository<Receipt> receiptRepository, IRepository<Journey> journeyRepository, IRepository<Worker> workerRepository, IRepository<Contract> contractRepository, IRepository<Ship> shipRepository, IRepository<Captain> captainRepository)
        {
            _receiptRepository = receiptRepository;
            _journeyRepository = journeyRepository;
            _workerRepository = workerRepository;
            _contractRepository = contractRepository;
            _shipRepository = shipRepository;
            _captainRepository = captainRepository;
        }

        public async Task<CreateReceiptResponse> Handle(CreateReceiptRequest request, CancellationToken cancellationToken)
        {
            var contract = _contractRepository.Include(c => c.Journey).FirstOrDefault(c => c.Id == request.Model.ContractId);

            var journey = _journeyRepository.Include(j => j.Ship, j => j.Captain, j => j.Workers).FirstOrDefault(j => j.Id == contract.JourneyId);

            var captain = journey.Captain;
            var ship = journey.Ship;

            captain.NotGoToWay();
            ship.NotGoToWay();

            await _shipRepository.ModifyAndSave(ship);
            await _captainRepository.ModifyAndSave(captain);

            foreach (var wr in journey.Workers)
            {
                wr.NotGoToWay();
                await _workerRepository.ModifyAndSave(wr);
            }

            contract.SetIsContractCompleted(true);

            await _contractRepository.ModifyAndSave(contract);
            
            var receipt = new Receipt(request.Model.ContractId,request.Model.Description);

            await _receiptRepository.AddandSave(receipt);

            return new CreateReceiptResponse
            {
                Model = new CreateReceiptResponseModel
                {
                    Message = "The receipt has been saved succesfully",
                    Success = true,
                }
            };
        }
    }
}