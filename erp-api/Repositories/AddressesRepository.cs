using erp_api.Models;
using erp_api.Contexts;

namespace erp_api.Repositories
{
    public class AddressesRepository: GenericRepository<Address, ErpContext, string>
    {
        public AddressesRepository(ErpContext context): base(context)
        {

        }
    }
}