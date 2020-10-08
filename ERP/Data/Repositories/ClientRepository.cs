using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

using ERP.Models;
using ERP.Contexts;

namespace ERP.Data.Repositories
{
    public class ClientRepository: GenericRepository<Client, ErpContext, string>
    {
        public ClientRepository(ErpContext context): base(context)
        {

        }
    }
}