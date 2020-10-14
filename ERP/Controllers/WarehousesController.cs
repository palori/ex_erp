using Microsoft.AspNetCore.Mvc;

using ERP.Models;
using ERP.Data.Repositories;

namespace ERP.Controllers
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
