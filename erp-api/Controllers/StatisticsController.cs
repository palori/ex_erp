using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using erp_api.Data.DTO;
using erp_api.Services;

namespace erp_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        public StatisticsController(StatisticsService statisticsService)
        {   
            _statisticsService = statisticsService;
        }

        private readonly StatisticsService _statisticsService; // Service

        [HttpGet("clientsmonth")]
        public async Task<ActionResult<StatisticsDto<DateTime,int>>> NewClientsMonth()
        {
            return await _statisticsService.NewClientsMonth();
        }

        [HttpGet("ordersday_avgcart")]
        public async Task<ActionResult<List<StatisticsDto<string,float>>>> OrdersDay_AvgCart()
        {
            return await _statisticsService.OrdersDay_AvgCart();
        }
    }
}
