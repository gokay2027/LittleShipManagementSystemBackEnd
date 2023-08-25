using ListtleShipManagementSystemDomain.Entities;
using LittleShipManagementSystemData.Repositories.Abstract;
using LittleShipManagermentSystemApi.Application.Command.ShipCommand.Model.ResponseModel;
using LittleShipManagermentSystemApi.Application.Command.ShipCommand.Request;
using LittleShipManagermentSystemApi.Application.Command.ShipCommand.Response;
using MediatR;

namespace LittleShipManagermentSystemApi.Application.Command.ShipCommand
{
    public class UpdateShipCommandHandler : IRequestHandler<UpdateShipRequest, UpdateShipResponse>
    {
        private readonly IRepository<Ship> _shipRepository;

        public UpdateShipCommandHandler(IRepository<Ship> shipRepository)
        {
            _shipRepository = shipRepository;
        }

        public async Task<UpdateShipResponse> Handle(UpdateShipRequest request, CancellationToken cancellationToken)
        {
            var shipToUpdate = await _shipRepository.GetById(request.Model.Id);

            shipToUpdate.Update(request.Model.name,
                request.Model.recordNumber,
                request.Model.shipNationality,
                request.Model.shipAge,
                request.Model.isOnTheWay,
                request.Model.shipCompanyId,
                request.Model.currentDockId);

            await _shipRepository.ModifyAndSave(shipToUpdate);

            var responseModel = new UpdateShipResponseModel
            {
                isSucces = true,
                Message = "Ship was updated successfully"
            };

            return new UpdateShipResponse { Model = responseModel };
        }
    }
}