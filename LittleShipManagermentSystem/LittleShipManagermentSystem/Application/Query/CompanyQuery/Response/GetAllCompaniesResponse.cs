using LittleShipManagermentSystemApi.Application.Query.CompanyQuery.Model.ResponseModel;

namespace LittleShipManagermentSystemApi.Application.Query.CompanyQuery.Response
{
    public class GetAllCompaniesResponse
    {
        public string Message { get; set; }

        public List<GetAllCompaniesResponseModel> modelList { get; set; } = new List<GetAllCompaniesResponseModel>();
    }
}
