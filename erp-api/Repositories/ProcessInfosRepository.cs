using erp_api.Models;
using erp_api.Contexts;

namespace erp_api.Repositories
{
    public class ProcessInfosRepository: GenericRepository<ProcessInfo, ErpContext, string>
    {
        public ProcessInfosRepository(ErpContext context): base(context)
        {

        }
        /*
         
        ATTENTION!!!

        `ProcessInfo`, `Process`, `ItemInfoProcessInfo`, `OrderItemProcessInfo` and all the parameters of the other models that are related to theese models are temporarily inactive!
         */
    }
}