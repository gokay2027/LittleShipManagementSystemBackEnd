using ListtleShipManagementSystemDomain.Entities;

namespace LittleShipManagermentSystemApi.Application.Query.WorkerQuery.Model.ResponseModel
{
    public class GetWorkerByIdResponseModel
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
