using Microsoft.AspNetCore.Mvc;

using erp_api.Models;
using erp_api.Repositories;

namespace erp_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderItemsController : GenericController<OrderItem, OrderItemsRepository, string>
    {
        public OrderItemsController(OrderItemsRepository repository): base(repository)
        {   
        }
    }
}
