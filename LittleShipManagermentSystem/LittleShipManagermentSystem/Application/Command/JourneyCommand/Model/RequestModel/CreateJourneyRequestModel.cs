namespace LittleShipManagermentSystemApi.Application.Command.JourneyCommand.Model.Request_Model
{
    public class CreateJourneyRequestModel
    {
        public int StartDockId { get; set; }

        public int EndDockId { get; set; }

        public int ShipId { get; set; }

        public int CaptainId { get; set; }

        public string? GuessedJourneyTime { get; set; }

        public List<CreateJourneyWorkerModel> Workers { get; set; }
    }
}