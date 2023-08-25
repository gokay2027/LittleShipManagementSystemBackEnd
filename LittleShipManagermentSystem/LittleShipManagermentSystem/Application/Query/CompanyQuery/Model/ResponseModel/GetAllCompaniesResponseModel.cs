using ListtleShipManagementSystemDomain.ValueObjects;

namespace LittleShipManagermentSystemApi.Application.Query.CompanyQuery.Model.ResponseModel
{
    public class GetAllCompaniesResponseModel
    {

        public int Id { get; set; }

        public string Name { get;  set; }

        public Location Location { get;  set; }

        public string Nation { get;  set; }
    }
}