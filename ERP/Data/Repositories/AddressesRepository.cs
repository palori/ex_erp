using ERP.Models;
using ERP.Contexts;

namespace ERP.Data.Repositories
{
    public class AddressesRepository: GenericRepository<Address, ErpContext, string>
    {
        public AddressesRepository(ErpContext context): base(context)
        {

        }
    }
}