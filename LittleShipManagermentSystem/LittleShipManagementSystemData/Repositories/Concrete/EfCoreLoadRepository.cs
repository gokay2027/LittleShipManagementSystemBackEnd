using ListtleShipManagementSystemDomain.Entities;
using LittleShipManagementSystemData.Repositories.Abstract;

namespace LittleShipManagementSystemData.Repositories.Concrete
{
    public class EfCoreLoadRepository : EfCoreRepository<Load, LittleShipManagementContext>
    {
        public EfCoreLoadRepository(LittleShipManagementContext context) : base(context)
        {
        }
    }
}