using ListtleShipManagementSystemDomain.Abstract;
using ListtleShipManagementSystemDomain.ValueObjects;

namespace ListtleShipManagementSystemDomain.Entities
{
    public class Company : AggregateRoot
    {
 
        public string Name { get; private set; }

        public Location Location { get; private set; }

        public string Nation { get; private set; }

        public List<Ship> Ships { get; private set; }

        public List<Captain> Captains { get; private set; }

        public List<Worker> Workers { get; private set; }

        public List<Contract> ShipCompanyContracts { get; private set; }

        public List<Contract> CustomerCompanyContracts { get; private set; }

        public List<Receipt> ReceiptShipCompanyList { get; private set; }

        public List<Receipt> ReceiptCustomerCompanyList { get; private set; }

        public Company()
        {
        }

        public Company(string name, string nation, string city, string country, string hoodName, string street, string no, string description)
        {
            Name = name;
            Nation = nation;
            Location = new Location(city, country, hoodName, street, no, description);
        }

        public void Update(string name, string nation, string city, string country, string hoodName, string street, string no, string description)
        {
            Name = name;
            Nation = nation;
            Location = new Location(city, country, hoodName, street, no, description);
        }

        public void Delete()
        {
            IsDeleted = true;
        }

        public void AddWorker(Worker worker)
        {
            Workers.Add(worker);
        }

        public void AddCaptain(Captain captain)
        {
            Captains.Add(captain);
        }

        public void AddShip(Ship ship)
        {
            Ships.Add(ship);
        }

        public void RemoveShip(int id)
        {
            Ships.RemoveAll(s=>s.Id==id);
        }

        public void RemoveCaptain(int id)
        {
            Captains.RemoveAll(s => s.Id == id);
        }

        public void RemoveWorker(int id)
        {
            Workers.RemoveAll(s=>s.Id==id);
        }

    }
}