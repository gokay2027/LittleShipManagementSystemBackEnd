namespace LittleShipManagermentSystemApi.Application.Query.WorkerQuery.Model.RequestModel
{
    public class GetWorkerBySearchRequestModel
    {
        public string? SearchNameProperty { get; set; }
        public string? SearchSurnameProperty { get; set; }
        public string? SearchNationalityProperty { get; set; }
    }
}