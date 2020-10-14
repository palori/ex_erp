using ERP.Models;
using ERP.Contexts;

namespace ERP.Data.Repositories
{
    public class ProcessInfosRepository: GenericRepository<ProcessInfo, ErpContext, string>
    {
        public ProcessInfosRepository(ErpContext context): base(context)
        {

        }
    }
}