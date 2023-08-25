using ListtleShipManagementSystemDomain.Entities;
using LittleShipManagementSystemData.Repositories.Abstract;
using LittleShipManagermentSystemApi.Application.Command.LoadCommand.Model;
using MediatR;

namespace LittleShipManagermentSystemApi.Application.Command.LoadCommand
{
    public class CreateLoadCommnadHandler : IRequestHandler<LoadCreateRequest, LoadCreateRequest>
    {
        private readonly IRepository<Load> _loadRepository;

        public CreateLoadCommnadHandler(IRepository<Load> loadRepository)
        {
            _loadRepository = loadRepository;
        }

        public async Task<LoadCreateRequest> Handle(LoadCreateRequest request, CancellationToken cancellationToken)
        {
            var load = new Load();
            await _loadRepository.AddandSave(load);
            return request;
        }
    }
}