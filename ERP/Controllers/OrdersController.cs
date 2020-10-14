using Microsoft.AspNetCore.Mvc;

using ERP.Models;
using ERP.Data.Repositories;

namespace ERP.Controllers
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
