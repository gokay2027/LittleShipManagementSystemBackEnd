using ListtleShipManagementSystemDomain.Abstract;

namespace ListtleShipManagementSystemDomain.Entities
{
    public class Load : Entity
    {
        public Contract Contract { get; private set; }

        public List<Container> Containers { get; private set; }

        public List<Receipt> ReceiptList { get; private set; }

        public Load()
        {
        }

        public void Delete()
        {
            IsDeleted = true;
        }

        public void Update(List<Container> containers)
        {
            Containers = containers;
        }

        public void AddContainer(List<Container> containers)
        {
            Containers.AddRange(containers);
        }
    }
}