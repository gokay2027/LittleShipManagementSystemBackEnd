using ListtleShipManagementSystemDomain.Entities;
using LittleShipManagementSystemData.Repositories.Abstract;
using LittleShipManagermentSystemApi.Application.Command.LoadCommand.Model.Request;
using LittleShipManagermentSystemApi.Application.Command.LoadCommand.Model.Response;
using LittleShipManagermentSystemApi.Application.Command.LoadCommand.Model.ResponseModels;
using MediatR;

namespace LittleShipManagermentSystemApi.Application.Command.LoadCommand
{
    public class AddContainerToLoadCommandHandler : IRequestHandler<AddContainerToLoadRequest, AddContainerToLoadResponse>
    {
        private readonly IRepository<Container> _containerRepository;

        public AddContainerToLoadCommandHandler(IRepository<Container> containerRepository)
        {
            _containerRepository = containerRepository;
        }

        public async Task<AddContainerToLoadResponse> Handle(AddContainerToLoadRequest request, CancellationToken cancellationToken)
        {
            //doldur burayi

            foreach (var container in request.Containers)
            {
                // geçici
                var containerToAdd = new Container(container.WeightType, container.LoadType, container.ContainerType, container.WeightAmount, request.LoadId);
                await _containerRepository.AddandSave(containerToAdd);
            }

            var responseList = new List<AddContainerToLoadResponseModel>();

            foreach (var container in request.Containers)
            {
                responseList.Add(new AddContainerToLoadResponseModel
                {
                    ContainerType = container.ContainerType,
                    LoadType = container.LoadType,
                    WeightType = container.WeightType,
                    WeightAmount = container.WeightAmount,
                });
            }

            return new AddContainerToLoadResponse
            {
                Containers = responseList,
            };
        }
    }
}