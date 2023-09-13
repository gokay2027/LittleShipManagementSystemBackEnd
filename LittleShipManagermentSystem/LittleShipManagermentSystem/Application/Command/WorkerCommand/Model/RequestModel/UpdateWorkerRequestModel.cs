namespace LittleShipManagermentSystemApi.Application.Command.WorkerCommand.Model.RequestModel
{
    public class UpdateWorkerRequestModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Nationality { get; set; }
        public string Experience { get; set; }
        public DateTime BirthDate { get; set; }
        public int CompanyId { get; set; }
        public bool IsOnTheWay { get; set; }
    }
}
