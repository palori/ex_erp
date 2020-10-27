using erp_api.Models;
using erp_api.Contexts;

namespace erp_api.Repositories
{
    public class ClientsRepository: GenericRepository<Client, ErpContext, string>
    {
        public ClientsRepository(ErpContext context): base(context)
        {

        }
    }
}