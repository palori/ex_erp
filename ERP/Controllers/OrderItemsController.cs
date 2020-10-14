using Microsoft.AspNetCore.Mvc;

using ERP.Models;
using ERP.Data.Repositories;

namespace ERP.Controllers
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
