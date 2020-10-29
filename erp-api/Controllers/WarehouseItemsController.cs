using Microsoft.AspNetCore.Mvc;

using erp_api.Models;
using erp_api.Repositories;

namespace erp_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WarehouseItemsController : GenericController<WarehouseItem, WarehouseItemsRepository, int>
    {
        public WarehouseItemsController(WarehouseItemsRepository repository): base(repository)
        {   
        }
    }
}
