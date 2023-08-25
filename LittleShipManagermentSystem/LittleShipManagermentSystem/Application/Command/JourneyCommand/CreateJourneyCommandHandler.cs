using ListtleShipManagementSystemDomain.Entities;
using LittleShipManagementSystemData.Repositories.Abstract;
using LittleShipManagermentSystemApi.Application.Command.JourneyCommand.Model.Response_Model;
using LittleShipManagermentSystemApi.Application.Command.JourneyCommand.Request;
using LittleShipManagermentSystemApi.Application.Command.JourneyCommand.Response;
using MediatR;

namespace LittleShipManagermentSystemApi.Application.Command.JourneyCommand
{
    public class CreateJourneyCommandHandler : IRequestHandler<CreateJourneyRequest, CreateJourneyResponse>
    {
        private readonly IRepository<Journey> _journeyRepository;
        private readonly IRepository<Captain> _captainRepository;
        private readonly IRepository<Dock> _dockRepository;
        private readonly IRepository<Worker> _workerRepository;
        private readonly IRepository<Ship> _shipRepository;

        public CreateJourneyCommandHandler(IRepository<Journey> journeyRepository, IRepository<Captain> captainRepository, IRepository<Dock> dockRepository, IRepository<Worker> workerRepository, IRepository<Ship> shipRepository)
        {
            _journeyRepository = journeyRepository;
            _captainRepository = captainRepository;
            _dockRepository = dockRepository;
            _workerRepository = workerRepository;
            _shipRepository = shipRepository;
        }

        public async Task<CreateJourneyResponse> Handle(CreateJourneyRequest request, CancellationToken cancellationToken)
        {
            var captain = await _captainRepository.GetById(request.Model.CaptainId);
            var startDock = await _dockRepository.GetById(request.Model.StartDockId);
            var endDock = await _dockRepository.GetById(request.Model.EndDockId);
            var ship = await _shipRepository.GetById(request.Model.ShipId);

            bool flag = false;
            if (captain != null && captain.IsOnTheWay == false && startDock != null && endDock != null && ship != null && ship.IsOnTheWay == false)
            {
                var journey = new Journey(startDock.Id, endDock.Id, ship.Id, captain.Id, request.Model.GuessedJourneyTime);

                foreach (var worker in request.Model.Workers)
                {
                    var wr = await _workerRepository.GetById(worker.Id);

                    if (wr.IsOnTheWay == true)
                    {
                        flag = true;
                        break;
                    }
                }

                if (flag == false)
                {
                    foreach (var worker in request.Model.Workers)
                    {
                        var wr = await _workerRepository.GetById(worker.Id);

                        if (wr.IsOnTheWay == false)
                        {
                            journey.AddWorkerToJourney(wr);
                            wr.GoToWay();
                            await _workerRepository.ModifyAndSave(wr);
                        }
                    }
                    ship.GoToWay();
                    await _shipRepository.ModifyAndSave(ship);

                    captain.GoToWay();
                    await _captainRepository.ModifyAndSave(captain);

                    await _journeyRepository.AddandSave(journey);
                }
            }
            else
            {
                flag = true;
            }

            if (flag == false)
            {
                var response = new CreateJourneyResponse
                {
                    Model = new CreateJourneyResponseModel
                    {
                        Message = "Journey has been successfully added",
                        Success = true,
                    }
                };
                return response;
            }
            else
            {
                var response = new CreateJourneyResponse
                {
                    Model = new CreateJourneyResponseModel
                    {
                        Message = "Journey has not been added succesfully check the data",
                        Success = false,
                    }
                };
                return response;
            }
        }
    }
}