using System;
using System.Collections.Generic;

namespace ERP.Models
{
    public class OrderItem: IEntity<string>
    {
        public string Id {get; set;}
        public virtual ItemInfo ItemInfo {get; set;}
        public virtual Order Order {get; set;}
        public virtual TradingInfo TradingInfo {get; set;}
        public int Units {get; set;}
        public virtual List<Process> Processes {get; set;}

    }
}