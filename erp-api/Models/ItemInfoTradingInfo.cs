using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace erp_api.Models
{
    public class ItemInfoTradingInfo: IEntity<int>
    {
        public int Id {get; set;}

        // Foreign Keys
        [ForeignKey("Item")]
        public string ItemInfoId {get; set;}
        [JsonIgnore]
        public virtual ItemInfo ItemInfo {get; set;}

        [ForeignKey("Trading")]
        public string TradingId {get; set;}
        [JsonIgnore]
        public virtual TradingInfo Trading {get; set;}
    }
}