using ListtleShipManagementSystemDomain.Abstract;

namespace ListtleShipManagementSystemDomain.Entities
{
    public class Receipt : AggregateRoot
    {
        public int ContractId { get; private set; }
        public Contract Contract { get; private set; }

        public string Description { get; private set; } 

        public Receipt()
        {
        }

        public Receipt(int contractId, string description)
        {
            ContractId = contractId;
            Description = description;
        }

        public void Delete()
        {
            IsDeleted = true;
        }

        public void Update(int contractId, string description)
        {
            ContractId = contractId;
            Description = description;
        }

        public void IsContractCompleted(bool isCompleted)
        {
            Contract.SetIsContractCompleted(isCompleted);
        }

        public void ReleaseWorkersShipAndCaptain()
        {
            Contract.Journey.NotGoToWayShipAndWorkerAndCaptain();
        }
    }
}