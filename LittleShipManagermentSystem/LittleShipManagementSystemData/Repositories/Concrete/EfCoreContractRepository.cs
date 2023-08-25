using ListtleShipManagementSystemDomain.Entities;
using LittleShipManagementSystemData.Repositories.Abstract;

namespace LittleShipManagementSystemData.Repositories.Concrete
{
    public class EfCoreContractRepository : EfCoreRepository<Contract, LittleShipManagementContext>
    {
        public EfCoreContractRepository(LittleShipManagementContext context) : base(context)
        {
        }
    }
}