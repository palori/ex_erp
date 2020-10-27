using Microsoft.AspNetCore.Mvc;

using erp_api.Models;
using erp_api.Repositories;

namespace erp_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComponentsController : GenericController<Component, ComponentsRepository, int>
    {
        public ComponentsController(ComponentsRepository repository): base(repository)
        {   
        }
    }
}
