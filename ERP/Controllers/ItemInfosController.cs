using Microsoft.AspNetCore.Mvc;

using ERP.Models;
using ERP.Data.Repositories;

namespace ERP.Controllers
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
