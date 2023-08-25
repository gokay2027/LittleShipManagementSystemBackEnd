namespace LittleShipManagermentSystemApi.Application.Command.ContractCommand.Model.RequestModel
{
    public class CreateContractRequestModel
    {
        public int JourneyId { get; set; }

        public int CustomerCompanyId { get; set; }

        public int ShipLogisticCompanyId { get; set; }

        public int LoadId { get; set; }

        public bool IsContractCompleted { get; set; } = false;

        public int MoneyAmount { get; set; }

        public string MoneyNationality { get; set; }
    }
}