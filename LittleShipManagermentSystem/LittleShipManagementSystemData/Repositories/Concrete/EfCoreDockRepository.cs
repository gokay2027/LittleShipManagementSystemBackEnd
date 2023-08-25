using ListtleShipManagementSystemDomain.Entities;
using LittleShipManagementSystemData.Repositories.Abstract;

namespace LittleShipManagementSystemData.Repositories.Concrete
{
    public class EfCoreDockRepository : EfCoreRepository<Dock, LittleShipManagementContext>
    {
        public EfCoreDockRepository(LittleShipManagementContext context) : base(context)
        {
        }
    }
}