using ERP.Models;
using ERP.Contexts;

namespace ERP.Data.Repositories
{
    public class SuppliersRepository: GenericRepository<Supplier, ErpContext, string>
    {
        public SuppliersRepository(ErpContext context): base(context)
        {

        }
    }
}