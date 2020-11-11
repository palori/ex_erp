using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System;

using erp_api.Models;
using erp_api.Contexts;
using erp_api.Data.DTO;

namespace erp_api.Repositories
{
    public class ClientsRepository: GenericRepository<Client, ErpContext, string>
    {
        public ClientsRepository(ErpContext context): base(context)
        {
        }
    }
}