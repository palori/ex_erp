using Microsoft.AspNetCore.Mvc;

using erp_api.Models;
using erp_api.Repositories;

namespace erp_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : GenericController<Client, ClientsRepository, string>
    {
        public ClientsController(ClientsRepository repository): base(repository)
        {   
        }
    }
}
