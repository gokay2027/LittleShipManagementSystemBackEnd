using ListtleShipManagementSystemDomain.Entities;
using LittleShipManagementSystemData.Repositories.Abstract;
using LittleShipManagermentSystemApi.Application.Command.DockCommand.Model.ResponseModel;
using LittleShipManagermentSystemApi.Application.Command.DockCommand.Request;
using LittleShipManagermentSystemApi.Application.Command.DockCommand.Response;
using MediatR;

namespace LittleShipManagermentSystemApi.Application.Command.DockCommand
{
    public class CreateDockCommandHandler : IRequestHandler<CreateDockRequest, CreateDockResponse>
    {
        private readonly IRepository<Dock> _dockRepository;

        public CreateDockCommandHandler(IRepository<Dock> dockRepository)
        {
            _dockRepository = dockRepository;
        }

        public async Task<CreateDockResponse> Handle(CreateDockRequest request, CancellationToken cancellationToken)
        {
            var newDock = new Dock(request.Model.Name, request.Model.City, request.Model.Country, request.Model.HoodName, request.Model.Street, request.Model.No, request.Model.Description);

            await _dockRepository.AddandSave(newDock);

            var response = new CreateDockResponse
            {
                Model = new CreateDockResponseModel
                {
                    Message = "The Dock has been created Successfully",
                    Success = true,
                }
            };
            return response;
        }
    }
}