using System;
using System.Collections.Generic;

using erp_api.Models;

namespace erp_api.Data.DTO
{
    public class StatisticsDto<TUnitsX, TUnitsY>
    {
        public string Title {get; set;}
        public List<TUnitsX> X {get; set;}
        public List<TUnitsY> Y {get; set;}
    }
}