using ListtleShipManagementSystemDomain.Abstract;
using ListtleShipManagementSystemDomain.ValueObjects;

namespace ListtleShipManagementSystemDomain.Entities
{
    public class Contract : Entity
    {
        public int JourneyId { get; private set; }
        public Journey Journey { get; private set; }

        public Money Fee { get; private set; }

        public int CustomerCompanyId { get; private set; }
        public Company CustomerCompany { get; private set; }

        public int ShipLogisticCompanyId { get; private set; }
        public Company ShipLogisticCompany { get; private set; }

        public int LoadId { get; private set; }
        public Load Load { get; private set; }

        public bool IsContractCompleted { get; private set; } = false;

        public Receipt Receipt { get; private set; }

        public Contract()
        {
        }

        public Contract(int journeyId, int shipLogisticCompanyId, int customerCompanyId, int loadId, bool isContractCompleted,string moneyNationality,int moneyAmount)
        {
            JourneyId = journeyId;
            Fee = new Money(moneyNationality,moneyAmount);
            ShipLogisticCompanyId = shipLogisticCompanyId;
            CustomerCompanyId = customerCompanyId;
            LoadId = loadId;
            IsContractCompleted = isContractCompleted;
        }

        public void Update(int journeyId, int shipLogisticCompanyId, int customerCompanyId, int loadId, bool isContractCompleted, string moneyNationality, int moneyAmount)
        {
            JourneyId = journeyId;
            Fee = new Money(moneyNationality, moneyAmount);
            ShipLogisticCompanyId = shipLogisticCompanyId;
            CustomerCompanyId = customerCompanyId;
            LoadId = loadId;
            IsContractCompleted = isContractCompleted;
        }

        public void Delete()
        {
            IsDeleted = true;
        }

        public void SetIsContractCompleted(bool isCompleted)
        {
            IsContractCompleted = isCompleted;
        }
    }
}