using System;
using System.Collections.Generic;

namespace erp_api.Models
{
    public class ItemInfo: Info
    {
        public string LinkImages {get; set;}
        // public List<string> Tags {get; set;}
        public string Category {get; set;}
        // public List<ItemInfo> Components {get; set;}
        public List<ProcessInfo> Processes {get; set;}
        public List<TradingInfo> BuyInfo {get; set;}
        public List<TradingInfo> SellInfo {get; set;}
    }
}