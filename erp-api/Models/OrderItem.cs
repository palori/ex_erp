using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace erp_api.Models
{
    public class OrderItem: IEntity<string>
    {
        public string Id {get; set;}
        public int Units {get; set;}

        // Foreign Keys
        [ForeignKey("ItemInfo")]
        public string ItemInfoId {get; set;}
        [JsonIgnore]
        public virtual ItemInfo ItemInfo {get; set;}

        [ForeignKey("Order")]
        public string OrderId {get; set;}
        [JsonIgnore]
        public virtual Order Order {get; set;}

        [ForeignKey("TradingInfo")]
        public string TradingInfoId {get; set;}
        [JsonIgnore]
        public virtual TradingInfo TradingInfo {get; set;}


        /*
         
        ATTENTION!!!

        `ProcessInfo`, `Process`, `ItemInfoProcessInfo`, `OrderItemProcessInfo` and all the parameters of the other models that are related to theese models are temporarily inactive!
         */
        // [ForeignKey("Processes")]
        // public string ProcessesId {get; set;}
        // [JsonIgnore]
        // public virtual List<Process> Processes {get; set;}

    }
}