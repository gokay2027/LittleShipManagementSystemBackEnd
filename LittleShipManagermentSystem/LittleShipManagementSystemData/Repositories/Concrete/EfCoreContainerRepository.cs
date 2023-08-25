using ListtleShipManagementSystemDomain.Entities;
using LittleShipManagementSystemData.Repositories.Abstract;

namespace LittleShipManagementSystemData.Repositories.Concrete
{
    public class EfCoreContainerRepository : EfCoreRepository<Container, LittleShipManagementContext>
    {
        public EfCoreContainerRepository(LittleShipManagementContext context) : base(context)
        {
        }
    }
}