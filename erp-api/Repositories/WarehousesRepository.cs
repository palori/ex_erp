using erp_api.Models;
using erp_api.Contexts;

namespace erp_api.Repositories
{
    public class WarehouseItemsRepository: GenericRepository<WarehouseItem, ErpContext, int>
    {
        public WarehouseItemsRepository(ErpContext context): base(context)
        {

        }
    }
}