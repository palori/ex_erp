using ERP.Models;
using ERP.Contexts;

namespace ERP.Data.Repositories
{
    public class ProcessesRepository: GenericRepository<Process, ErpContext, string>
    {
        public ProcessesRepository(ErpContext context): base(context)
        {

        }
    }
}