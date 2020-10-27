using erp_api.Models;
using erp_api.Contexts;

namespace erp_api.Repositories
{
    public class ItemInfosRepository: GenericRepository<ItemInfo, ErpContext, string>
    {
        public ItemInfosRepository(ErpContext context): base(context)
        {

        }
    }
}