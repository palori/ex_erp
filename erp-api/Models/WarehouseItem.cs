using System;
using System.Collections.Generic;

namespace erp_api.Models
{
    public class WarehouseItem: IEntity<int>
    {
        public int Id {get; set;}
        public virtual ItemInfo ItemInfo {get; set;}
        public int Units {get; set;}
        public int State {get; set;}
    }
}