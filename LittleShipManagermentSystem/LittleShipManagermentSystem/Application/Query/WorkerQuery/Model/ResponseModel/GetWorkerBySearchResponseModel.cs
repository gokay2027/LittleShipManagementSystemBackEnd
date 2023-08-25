namespace LittleShipManagermentSystemApi.Application.Query.WorkerQuery.Model.ResponseModel
{
    public class GetWorkerBySearchResponseModel
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Nationality { get; set; }

        public string Experience { get; set; }

        public DateTime BirthDate { get; set; }

        public string CompanyName { get; set; }

        public bool IsOnTheWay { get; set; }
    }
}