using erp_api.Models;
using erp_api.Contexts;

namespace erp_api.Repositories
{
    public class OrdersRepository: GenericRepository<Order, ErpContext, string>
    {
        public OrdersRepository(ErpContext context): base(context)
        {

        }
    }
}