using erp_api.Models;
using erp_api.Contexts;

namespace erp_api.Repositories
{
    public class ProcessesRepository: GenericRepository<Process, ErpContext, string>
    {
        public ProcessesRepository(ErpContext context): base(context)
        {

        }
    }
}