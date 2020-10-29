using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using erp_api.Models;
using erp_api.Repositories;
using erp_api.Data.DTO;

namespace erp_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : GenericController<Client, ClientsRepository, string>
    {
        public ClientsController(ClientsRepository repository): base(repository)
        {   
        }

        [HttpGet("full")]
        public async Task<ActionResult<ClientDto>> GetFull(Client client)
        {
            return await GetRepository().GetFull(client);
        }
    }
}
