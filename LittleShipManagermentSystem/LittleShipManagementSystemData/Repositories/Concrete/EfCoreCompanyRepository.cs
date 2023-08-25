using ListtleShipManagementSystemDomain.Entities;
using LittleShipManagementSystemData.Repositories.Abstract;

namespace LittleShipManagementSystemData.Repositories.Concrete
{
    public class EfCoreCompanyRepository : EfCoreRepository<Company, LittleShipManagementContext>
    {
        public EfCoreCompanyRepository(LittleShipManagementContext context) : base(context)
        {
        }
    }
}