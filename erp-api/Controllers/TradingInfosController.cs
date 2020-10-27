using Microsoft.AspNetCore.Mvc;

using erp_api.Models;
using erp_api.Repositories;

namespace erp_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TradingInfosController : GenericController<TradingInfo, TradingInfosRepository, string>
    {
        public TradingInfosController(TradingInfosRepository repository): base(repository)
        {   
        }
    }
}
