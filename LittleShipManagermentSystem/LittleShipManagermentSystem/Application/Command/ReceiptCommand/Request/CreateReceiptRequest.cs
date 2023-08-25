using LittleShipManagermentSystemApi.Application.Command.ReceiptCommand.Model.RequestModel;
using LittleShipManagermentSystemApi.Application.Command.ReceiptCommand.Response;
using MediatR;

namespace LittleShipManagermentSystemApi.Application.Command.ReceiptCommand.Request
{
    public class CreateReceiptRequest : IRequest<CreateReceiptResponse>
    {
        public CreateReceiptRequestModel Model { get; set; }
    }
}