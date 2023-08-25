using ListtleShipManagementSystemDomain.Abstract;
using ListtleShipManagementSystemDomain.ValueObjects;

namespace ListtleShipManagementSystemDomain.Entities
{
    public class Dock : Entity
    {
        public string Name { get; private set; }

        public Location Location { get; private set; }

        public List<Ship> Ships { get; private set; }

        public List<Journey> StartJourneyList { get; set; }

        public List<Journey> EndJourneyList { get; set; }

        public Dock()
        {
        }

        public Dock(string name, string city, string country, string hoodName, string street, string no, string description)
        {
            Name = name;
            Location = new Location(city,country,hoodName,street,no,description);
        }

        public void Delete()
        {
            IsDeleted = true;
        }

        public void Update(string name, Location location)
        {
            Name = name;
            Location = location;
        }
    }
}