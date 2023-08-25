using ListtleShipManagementSystemDomain.Entities;
using LittleShipManagementSystemData.Repositories.Abstract;

namespace LittleShipManagementSystemData.Repositories.Concrete
{
    public class EfCoreWorkerRepository : EfCoreRepository<Worker, LittleShipManagementContext>
    {
        public EfCoreWorkerRepository(LittleShipManagementContext context) : base(context)
        {
        }
    }
}