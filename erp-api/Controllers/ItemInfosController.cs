using Microsoft.AspNetCore.Mvc;

using erp_api.Models;
using erp_api.Repositories;

namespace erp_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemInfosController : GenericController<ItemInfo, ItemInfosRepository, string>
    {
        public ItemInfosController(ItemInfosRepository repository): base(repository)
        {   
        }
    }
}
