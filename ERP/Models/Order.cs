using System;
using System.Collections.Generic;
// using System.Text.Json.Serialization;

namespace ERP.Models
{
    public class Order: IEntity<string>
    {
        public string Id {get; set;}
        // [JsonIgnore]
        public string Reference {get; set;}     // Id: ClientId or SupplierId
        // public virtual string Reference {get; set;}     // Id: ClientId or SupplierId
        // public virtual Profile Profile {get; set;}
        public virtual Address Address {get; set;}
        public virtual List<OrderItem> OrderItems {get; set;}
        public virtual List<Process> Processes {get; set;}
        public int Priority {get; set;}
        //public Payment Payment {get; set;}
    }
}