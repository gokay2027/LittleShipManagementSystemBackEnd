using ListtleShipManagementSystemDomain.Abstract;

namespace ListtleShipManagementSystemDomain.Entities
{
    public class Container : Entity
    {
        public string WeightType { get; private set; }

        public string LoadType { get; private set; }

        public string ContainerType { get; private set; }

        public int WeightAmount { get; private set; }

        public int? LoadId { get; private set; }
        public Load Load { get; private set; }

        public Container()
        {
        }

        public Container(string weightType, string loadType, string containerType, int weightAmount, int? loadId)
        {
            WeightType = weightType;
            LoadType = loadType;
            ContainerType = containerType;
            WeightAmount = weightAmount;
            LoadId = loadId;
        }

        public void Update(string weightType, string loadType, string containerType, int weightAmount, int? loadId)
        {
            WeightType = weightType;
            LoadType = loadType;
            ContainerType = containerType;
            WeightAmount = weightAmount;
            LoadId = loadId;
        }

        public void Delete()
        {
            IsDeleted = true;
        }
    }
}