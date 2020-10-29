using System;

namespace erp_api.Models
{
    public class ItemInfoTradingInfo: IEntity<int>
    {
        public int Id {get; set;}

        // Foreign Keys
        public virtual ItemInfo Item {get; set;}
        public virtual TradingInfo Trading {get; set;}
    }
}