using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace erp_api.Models
{
    public class Order: IEntity<string>
    {
        public string Id {get; set;}
        public int Priority {get; set;}
        public DateTime Ordered {get; set;} // formaria part d'un process

        // Foreign Keys
        [ForeignKey("Reference")]
        public string ReferenceId {get; set;}
        [JsonIgnore]
        public virtual Contact Reference {get; set;}
        // public virtual string Reference {get; set;}     // Id: ClientId or SupplierId

        [ForeignKey("Address")]
        public string AddressId {get; set;}
        [JsonIgnore]
        public virtual Address Address {get; set;}

        // [ForeignKey("OrderItems")]
        // public string OrderItemsId {get; set;}
        // [JsonIgnore]
        // public virtual List<OrderItem> OrderItems {get; set;}

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