using Microsoft.AspNetCore.Mvc;

using erp_api.Models;
using erp_api.Repositories;

namespace erp_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WarehousesController : GenericController<Warehouse, WarehousesRepository, int>
    {
        public WarehousesController(WarehousesRepository repository): base(repository)
        {   
        }
    }
}
