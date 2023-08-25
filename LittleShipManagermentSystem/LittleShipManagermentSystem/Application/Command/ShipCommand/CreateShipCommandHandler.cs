using ListtleShipManagementSystemDomain.Entities;
using LittleShipManagementSystemData.Repositories.Abstract;
using LittleShipManagermentSystemApi.Application.Command.ShipCommand.Model.ResponseModel;
using LittleShipManagermentSystemApi.Application.Command.ShipCommand.Request;
using LittleShipManagermentSystemApi.Application.Command.ShipCommand.Response;
using MediatR;

namespace LittleShipManagermentSystemApi.Application.Command.ShipCommand
{
    public class CreateShipCommandHandler : IRequestHandler<CreateShipRequest, CreateShipResponse>
    {
        private readonly IRepository<Ship> _shipRepository;

        public CreateShipCommandHandler(IRepository<Ship> shipRepository)
        {
            _shipRepository = shipRepository;
        }

        public async Task<CreateShipResponse> Handle(CreateShipRequest request, CancellationToken cancellationToken)
        {
            var newShip = new Ship(request.Model.Name, request.Model.RecordNumber, request.Model.ShipNationality, request.Model.ShipAge, request.Model.IsOnTheWay
                , request.Model.ShipCompanyId, request.Model.CurrentDockId);

            await _shipRepository.AddandSave(newShip);

            var response = new CreateShipResponse
            {
                Model = new CreateShipResponseModel
                {
                    Message = "The Ship was Successfully Added",
                    Success = true
                }
            };

            return response;
        }
    }
}