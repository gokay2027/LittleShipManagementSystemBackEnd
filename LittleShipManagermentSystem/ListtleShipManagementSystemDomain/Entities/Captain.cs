using ListtleShipManagementSystemDomain.Abstract;

namespace ListtleShipManagementSystemDomain.Entities
{
    public class Captain : Entity
    {
        public string Name { get; private set; }

        public string Surname { get; private set; }

        public string Nationality { get; private set; }

        public int ExperienceYears { get; private set; }

        public DateTime BirthDate { get; private set; }

        public int CompanyId { get; private set; }
        public Company Company { get; private set; }

        public bool IsOnTheWay { get; private set; } = false;

        public List<Journey> Journeys { get; private set; }

        public Captain()
        {
        }

        public Captain(string name, string surname, string nationality, int experienceYears, DateTime birthDate, int companyId)
        {
            Name = name;
            Surname = surname;
            Nationality = nationality;
            ExperienceYears = experienceYears;
            BirthDate = birthDate;
            CompanyId = companyId;
        }

        public void Delete()
        {
            IsDeleted = true;
        }

        public void Update(string name, string surname, string nationality, int experienceYears, DateTime birthDate, int companyId)
        {
            Name = name;
            Surname = surname;
            Nationality = nationality;
            ExperienceYears = experienceYears;
            BirthDate = birthDate;
            CompanyId = companyId;
        }

        public void GoToWay()
        {
            IsOnTheWay = true;
        }

        public void NotGoToWay()
        {
            IsOnTheWay = false;
        }

        public void SetCaotainCompany(int companyId)
        {
            CompanyId = companyId;
        }
    }
}