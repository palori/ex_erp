using Microsoft.AspNetCore.Mvc;

using ERP.Models;
using ERP.Data.Repositories;

namespace ERP.Controllers
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
