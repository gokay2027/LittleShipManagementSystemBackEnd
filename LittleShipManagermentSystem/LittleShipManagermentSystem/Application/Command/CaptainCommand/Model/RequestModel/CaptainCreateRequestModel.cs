namespace LittleShipManagermentSystemApi.Application.Command.CaptainCommand.Model.RequestModel
{
    public class CaptainCreateRequestModel
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Nationality { get; set; }

        public int ExperienceYears { get; set; }

        public DateTime BirthDate { get; set; }

        public int CompanyId { get; set; }
    }
}
