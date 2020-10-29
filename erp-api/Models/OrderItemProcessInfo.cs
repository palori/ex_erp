using System;

namespace erp_api.Models
{
    public class OrderItemProcessInfo: IEntity<int>
    {
        public int Id {get; set;}

        // Foreign Keys
        public virtual OrderItem Item {get; set;}
        public virtual ProcessInfo Process {get; set;}
    }
}