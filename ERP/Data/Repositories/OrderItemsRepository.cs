using ERP.Models;
using ERP.Contexts;

namespace ERP.Data.Repositories
{
    public class OrderItemsRepository: GenericRepository<OrderItem, ErpContext, string>
    {
        public OrderItemsRepository(ErpContext context): base(context)
        {

        }
    }
}