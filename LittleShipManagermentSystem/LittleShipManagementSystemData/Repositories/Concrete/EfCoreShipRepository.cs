using ListtleShipManagementSystemDomain.Entities;
using LittleShipManagementSystemData.Repositories.Abstract;

namespace LittleShipManagementSystemData.Repositories.Concrete
{
    public class EfCoreShipRepository : EfCoreRepository<Ship, LittleShipManagementContext>
    {
        public EfCoreShipRepository(LittleShipManagementContext context) : base(context)
        {
        }
    }
}