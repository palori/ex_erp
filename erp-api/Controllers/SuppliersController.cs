using Microsoft.AspNetCore.Mvc;

using erp_api.Models;
using erp_api.Repositories;

namespace erp_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuppliersController : GenericController<Supplier, SuppliersRepository, string>
    {
        public SuppliersController(SuppliersRepository repository): base(repository)
        {   
        }
    }
}
