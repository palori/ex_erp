using erp_api.Models;
using erp_api.Contexts;

namespace erp_api.Repositories
{
    public class SuppliersRepository: GenericRepository<Supplier, ErpContext, string>
    {
        public SuppliersRepository(ErpContext context): base(context)
        {

        }
    }
}