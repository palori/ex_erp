using Microsoft.AspNetCore.Mvc;

using ERP.Models;
using ERP.Data.Repositories;

namespace ERP.Controllers
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
