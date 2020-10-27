using erp_api.Models;
using erp_api.Contexts;

namespace erp_api.Repositories
{
    public class OrderItemsRepository: GenericRepository<OrderItem, ErpContext, string>
    {
        public OrderItemsRepository(ErpContext context): base(context)
        {

        }
    }
}