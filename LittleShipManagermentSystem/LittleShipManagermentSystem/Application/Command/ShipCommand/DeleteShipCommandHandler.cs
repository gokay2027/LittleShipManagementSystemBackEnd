using ListtleShipManagementSystemDomain.Entities;
using LittleShipManagementSystemData.Repositories.Abstract;
using LittleShipManagermentSystemApi.Application.Command.ShipCommand.Model.ResponseModel;
using LittleShipManagermentSystemApi.Application.Command.ShipCommand.Request;
using LittleShipManagermentSystemApi.Application.Command.ShipCommand.Response;
using MediatR;

namespace LittleShipManagermentSystemApi.Application.Command.ShipCommand
{
    public class DeleteShipCommandHandler : IRequestHandler<DeleteShipRequest, DeleteShipResponse>
    {

        private readonly IRepository<Ship> _shipRepository;

        public DeleteShipCommandHandler(IRepository<Ship> shipRepository)
        {
            _shipRepository = shipRepository;
        }

        public async Task<DeleteShipResponse> Handle(DeleteShipRequest request, CancellationToken cancellationToken)
        {

            await _shipRepository.RemoveAndSave(request.Model.Id);

            try
            {
                return new DeleteShipResponse
                {
                    ResponseModel = new DeleteShipResponseModel
                    {
                        isSuccess = true,
                        Message = "Ship was successfully deleted"
                    }
                };
            }
            catch (Exception ex)
            {
                return new DeleteShipResponse
                {
                    ResponseModel = new DeleteShipResponseModel
                    {
                        isSuccess = false,
                        Message = ex.Message
                    }
                };
            }
        }
    }
}
