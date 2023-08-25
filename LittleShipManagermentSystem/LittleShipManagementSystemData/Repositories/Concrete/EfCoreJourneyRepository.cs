using ListtleShipManagementSystemDomain.Entities;
using LittleShipManagementSystemData.Repositories.Abstract;

namespace LittleShipManagementSystemData.Repositories.Concrete
{
    public class EfCoreJourneyRepository : EfCoreRepository<Journey, LittleShipManagementContext>
    {
        public EfCoreJourneyRepository(LittleShipManagementContext context) : base(context)
        {
        }
    }
}