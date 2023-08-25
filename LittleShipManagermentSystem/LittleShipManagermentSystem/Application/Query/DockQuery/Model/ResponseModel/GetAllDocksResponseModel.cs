using ListtleShipManagementSystemDomain.ValueObjects;

namespace LittleShipManagermentSystemApi.Application.Query.DockQuery.Model.ResponseModel
{
    public class GetAllDocksResponseModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Location Location { get; set; }
    }
}