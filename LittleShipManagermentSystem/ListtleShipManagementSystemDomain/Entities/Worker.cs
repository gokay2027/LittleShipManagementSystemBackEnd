using ListtleShipManagementSystemDomain.Abstract;

namespace ListtleShipManagementSystemDomain.Entities
{
    public class Worker : Entity
    {
        public string Name { get; private set; }

        public string Surname { get; private set; }

        public string Nationality { get; private set; }

        public string Experience { get; private set; }

        public DateTime BirthDate { get; private set; }

        public int CompanyId { get; private set; }
        public Company Company { get; private set; }

        public bool IsOnTheWay { get; private set; } = false;

        public List<Journey> Journeys { get; private set; }

        public Worker()
        {
        }

        public Worker(string name, string surname, string nationality, string experience, DateTime birthDate, int companyId)
        {
            Name = name;
            Surname = surname;
            Nationality = nationality;
            Experience = experience;
            BirthDate = birthDate;
            CompanyId = companyId;
        }

        public void Delete()
        {
            IsDeleted = true;
        }

        public void Update(string name, string surname, string nationality, string experience, DateTime birthDate, int companyId, bool isOnTheWay)
        {
            Name = name;
            Surname = surname;
            Nationality = nationality;
            Experience = experience;
            BirthDate = birthDate;
            CompanyId = companyId;
            IsOnTheWay = isOnTheWay;
        }

        public void GoToWay()
        {
            IsOnTheWay = true;
        }

        public void NotGoToWay()
        {
            IsOnTheWay = false;
        }

        public void SetWorkerName(string name)
        {
            Name = name;
        }

        public void SetWorkerSurname(string surname)
        {
            Surname = surname;
        }

        public void SetWorkerNationality(string nation)
        {
            Nationality = nation;
        }

        public void SetWorkerExperience(string experience)
        {
            Experience = experience;
        }
    }
}