using erp_api.Models;
using erp_api.Contexts;

namespace erp_api.Repositories
{
    public class ComponentsRepository: GenericRepository<Component, ErpContext, int>
    {
        public ComponentsRepository(ErpContext context): base(context)
        {

        }
    }
}