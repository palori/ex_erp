using System;

namespace erp_api.Models
{
    public class ItemInfoProcessInfo: IEntity<int>
    {
        public int Id {get; set;}

        // Foreign Keys
        public virtual ItemInfo Item {get; set;}
        public virtual ProcessInfo Process {get; set;}
    }
}