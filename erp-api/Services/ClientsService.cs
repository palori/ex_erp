using erp_api.Models;
using erp_api.Contexts;

namespace erp_api.Services
{
    public class ClientsService: GenericService<Client, ErpContext, string>
    {
        public ClientsService(ErpContext context): base(context)
        {

        }
    }
}