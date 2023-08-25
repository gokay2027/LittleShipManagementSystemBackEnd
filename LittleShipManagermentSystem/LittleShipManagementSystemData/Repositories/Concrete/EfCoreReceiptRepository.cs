using ListtleShipManagementSystemDomain.Entities;
using LittleShipManagementSystemData.Repositories.Abstract;

namespace LittleShipManagementSystemData.Repositories.Concrete
{
    public class EfCoreReceiptRepository : EfCoreRepository<Receipt, LittleShipManagementContext>
    {
        public EfCoreReceiptRepository(LittleShipManagementContext context) : base(context)
        {
        }
    }
}