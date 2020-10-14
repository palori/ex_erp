using ERP.Models;
using ERP.Contexts;

namespace ERP.Data.Repositories
{
    public class ItemInfosRepository: GenericRepository<ItemInfo, ErpContext, string>
    {
        public ItemInfosRepository(ErpContext context): base(context)
        {

        }
    }
}