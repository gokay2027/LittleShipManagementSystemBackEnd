using LittleShipManagermentSystemApi.Application.Command;
using LittleShipManagermentSystemApi.Application.Command.CaptainCommand.Model;
using LittleShipManagermentSystemApi.Application.Command.ContractCommand.Request;
using LittleShipManagermentSystemApi.Application.Command.DockCommand.Request;
using LittleShipManagermentSystemApi.Application.Command.JourneyCommand.Request;
using LittleShipManagermentSystemApi.Application.Command.LoadCommand.Model;
using LittleShipManagermentSystemApi.Application.Command.LoadCommand.Model.Request;
using LittleShipManagermentSystemApi.Application.Command.ReceiptCommand.Request;
using LittleShipManagermentSystemApi.Application.Command.ShipCommand.Request;
using LittleShipManagermentSystemApi.Application.Command.WorkerCommand.Model;
using LittleShipManagermentSystemApi.Application.Query.CompanyQuery.Request;
using LittleShipManagermentSystemApi.Application.Query.DockQuery.Request;
using LittleShipManagermentSystemApi.Application.Query.ShipQuery.Request;
using LittleShipManagermentSystemApi.Application.Query.WorkerQuery.Request;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LittleShipManagermentSystemApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LittleShipManagementController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LittleShipManagementController(
            IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> AddCompany(CreateCompanyRequest inputModel)
        {
            var company = await _mediator.Send(inputModel);
            return Ok(company);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCompany(UpdateCompanyRequest inputModel)
        {
            var company = await _mediator.Send(inputModel);
            return Ok(company);
        }

        [HttpPost]
        public async Task<IActionResult> AddWorker(CreateWorkerRequest inputModel)
        {
            var worker = await _mediator.Send(inputModel);
            return Ok(worker);
        }

        [HttpPost]
        public async Task<IActionResult> AddCaptain(CaptainCreateRequest model)
        {
            var captain = await _mediator.Send(model);
            return Ok(captain);
        }

        [HttpPut]
        public async Task<IActionResult> AddContainerToLoad(AddContainerToLoadRequest model)
        {
            var result = await _mediator.Send(model);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddLoad(LoadCreateRequest model)
        {
            var load = await _mediator.Send(model);
            return Ok(load);
        }

        [HttpPost]
        public async Task<IActionResult> AddShip(CreateShipRequest request)
        {
            var ship = await _mediator.Send(request);
            return Ok(ship);
        }

        [HttpPost]
        public async Task<IActionResult> AddDock(CreateDockRequest request)
        {
            var dock = await _mediator.Send(request);
            return Ok(dock);
        }

        [HttpPost]
        public async Task<IActionResult> AddJourney(CreateJourneyRequest request)
        {
            var journey = await _mediator.Send(request);
            return Ok(journey);
        }

        [HttpPost]
        public async Task<IActionResult> AddContract(CreateContractRequest request)
        {
            var contract = await _mediator.Send(request);
            return Ok(contract);
        }

        [HttpPost]
        public async Task<IActionResult> AddReceipt(CreateReceiptRequest request)
        {
            var receipt = await _mediator.Send(request);
            return Ok(receipt);
        }

        [HttpGet]
        public async Task<IActionResult> GetShipsByCompanyId([FromQuery] GetShipsByCompanyIdRequest request)
        {
            var ships = await _mediator.Send(request);
            return Ok(ships);
        }

        [HttpGet]
        public async Task<IActionResult> GetWorkersByCompanyId([FromQuery] GetWorkersByCompanyIdRequest request)
        {
            var workers = await _mediator.Send(request);
            return Ok(workers);
        }

        [HttpGet]
        public async Task<IActionResult> GetWorkersByNameSearch([FromQuery] GetWorkerBySearchRequest request)
        {
            var workers = await _mediator.Send(request);
            return Ok(workers);
        }

        [HttpGet]
        public async Task<IActionResult> GetShipsInTheDock([FromQuery] GetShipsInTheDockRequest request)
        {
            var ships = await _mediator.Send(request);
            return Ok(ships);
        }

        [HttpGet]
        public async Task<IActionResult> GetShipsByFilter([FromQuery] GetShipsByFilterRequest request)
        {
            var ships = await _mediator.Send(request);
            return Ok(ships);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllShips([FromQuery] GetAllShipsRequest request)
        {
            var ships = await _mediator.Send(request);
            return Ok(ships);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCompanies([FromQuery] GetAllCompaniesRequest request)
        {
            var companies = await _mediator.Send(request);
            return Ok(companies);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDocks([FromQuery] GetAllDocksRequest request)
        {
            var docks = await _mediator.Send(request);
            return Ok(docks);
        }


        [HttpPut]
        public async Task<IActionResult> UpdateShip(UpdateShipRequest inputModel)
        {
            var ship = await _mediator.Send(inputModel);
            return Ok(ship);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteShip(DeleteShipRequest inputModel)
        {
            var responseDelete = await _mediator.Send(inputModel);
            return Ok(responseDelete);
        }

    }
}