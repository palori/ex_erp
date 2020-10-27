using Microsoft.AspNetCore.Mvc;

using erp_api.Models;
using erp_api.Repositories;

namespace erp_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : GenericController<Order, OrdersRepository, string>
    {
        public OrdersController(OrdersRepository repository): base(repository)
        {   
        }
    }
}
