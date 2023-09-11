namespace LittleShipManagermentSystemApi.Application.Query.WorkerQuery.Model.ResponseModel
{
    public class GetAllWorkersResponseModel
    {

        public int id { get; set; }

        public string name { get; set; }

        public string surname { get; set; }

        public string experience { get; set; }

        public DateTime birthDate { get; set; }

        public string companyName { get; set; }

        public bool isOnTheWay { get; set; }

        public string nationality { get; set; }

    }
}
