using ListtleShipManagementSystemDomain.Entities;
using LittleShipManagementSystemData.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleShipManagementSystemData.Repositories.Concrete
{
    public class EfCoreCaptainRepository : EfCoreRepository<Captain, LittleShipManagementContext>
    {
        public EfCoreCaptainRepository(LittleShipManagementContext context) : base(context)
        {

        }
    }
}
