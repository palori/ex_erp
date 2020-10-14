using Microsoft.AspNetCore.Mvc;

using ERP.Models;
using ERP.Data.Repositories;

namespace ERP.Controllers
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
