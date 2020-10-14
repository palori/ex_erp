using ERP.Models;
using ERP.Contexts;

namespace ERP.Data.Repositories
{
    public class OrdersRepository: GenericRepository<Order, ErpContext, string>
    {
        public OrdersRepository(ErpContext context): base(context)
        {

        }
    }
}