using ERP.Models;
using ERP.Contexts;

namespace ERP.Data.Repositories
{
    public class WarehousesRepository: GenericRepository<Warehouse, ErpContext, int>
    {
        public WarehousesRepository(ErpContext context): base(context)
        {

        }
    }
}