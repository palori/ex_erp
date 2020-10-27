using erp_api.Models;
using erp_api.Contexts;

namespace erp_api.Repositories
{
    public class WarehousesRepository: GenericRepository<Warehouse, ErpContext, int>
    {
        public WarehousesRepository(ErpContext context): base(context)
        {

        }
    }
}