using ERP.Models;
using ERP.Contexts;

namespace ERP.Data.Repositories
{
    public class ClientsRepository: GenericRepository<Client, ErpContext, string>
    {
        public ClientsRepository(ErpContext context): base(context)
        {

        }
    }
}