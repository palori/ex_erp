using ERP.Models;
using ERP.Contexts;

namespace ERP.Data.Repositories
{
    public class ComponentsRepository: GenericRepository<Component, ErpContext, int>
    {
        public ComponentsRepository(ErpContext context): base(context)
        {

        }
    }
}