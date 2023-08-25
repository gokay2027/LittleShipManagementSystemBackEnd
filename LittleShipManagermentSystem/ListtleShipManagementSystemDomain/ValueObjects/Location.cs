namespace ListtleShipManagementSystemDomain.ValueObjects
{
    public class Location : ValueObject
    {
        public string City { get; private set; }

        public string Country { get; private set; }

        public string HoodName { get; private set; }

        public string Street { get; private set; }

        public string No { get; private set; }

        public string Description { get; private set; } = string.Empty;

        public Location()
        {
        }

        public Location(string city, string country, string hoodName, string street, string no, string description)
        {
            City = city;
            Country = country;
            HoodName = hoodName;
            Street = street;
            No = no;
            Description = description;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return City;
            yield return Country;
            yield return HoodName;
            yield return Street;
            yield return No;
            yield return Description;
        }
    }
}