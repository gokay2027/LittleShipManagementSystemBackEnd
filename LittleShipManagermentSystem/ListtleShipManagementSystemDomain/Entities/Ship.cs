using ListtleShipManagementSystemDomain.Abstract;

namespace ListtleShipManagementSystemDomain.Entities
{
    public class Ship : Entity
    {
        public string Name { get; private set; }

        public string RecordNumber { get; private set; }

        public string ShipNationality { get; private set; }

        public int ShipAge { get; private set; }

        public bool IsOnTheWay { get; private set; } = false;

        public int? ShipCompanyId { get; private set; }
        public Company ShipCompany { get; private set; }

        public int? CurrentDockId { get; private set; }
        public Dock Dock { get; private set; }

        public List<Journey> Journeys { get; private set; }

        public Ship()
        {
        }

        public Ship(string name, string recordNumber, string shipNationality, int shipAge, bool isOnTheWay, int? shipCompanyId, int? currentDockId)
        {
            Name = name;
            RecordNumber = recordNumber;
            ShipNationality = shipNationality;
            ShipAge = shipAge;
            IsOnTheWay = isOnTheWay;
            ShipCompanyId = shipCompanyId;
            CurrentDockId = currentDockId;
        }

        public void Delete()
        {
            IsDeleted = true;
        }

        public void Update(string name, string recordNumber, string shipNationality, int shipAge, bool isOnTheWay, int? shipCompanyId, int? currentDockId)
        {
            Name = name;
            RecordNumber = recordNumber;
            ShipNationality = shipNationality;
            ShipAge = shipAge;
            IsOnTheWay = isOnTheWay;
            ShipCompanyId = shipCompanyId;
            CurrentDockId = currentDockId;
        }

        public void GoToWay()
        {
            IsOnTheWay = true;
        }

        public void NotGoToWay()
        {
            IsOnTheWay = false;
        }

        public void SetShipCurrentDock(int dockId)
        {
            CurrentDockId = dockId;
        }

        public void SetShipCompany(int companyId)
        {
            ShipCompanyId = companyId;
        }
    }
}