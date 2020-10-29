using System;
using System.Collections.Generic;
// using System.Text.Json.Serialization;

namespace erp_api.Models
{
    public class Order: IEntity<string>
    {
        public string Id {get; set;}
        public virtual Address Address {get; set;}
        public virtual List<OrderItem> OrderItems {get; set;}
        public virtual List<Process> Processes {get; set;}
        public int Priority {get; set;}
        //public Payment Payment {get; set;}

        // Foreign Keys
        public virtual Contact Reference {get; set;}
        // public virtual string Reference {get; set;}     // Id: ClientId or SupplierId
    }
}