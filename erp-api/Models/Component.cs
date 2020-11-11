using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace erp_api.Models
{
    public class Component: IEntity<int>
    {
        public int Id {get; set;}
        public int Units {get; set;}

        // Foreign Keys
        [ForeignKey("_Component")]
        public string ComponentId {get; set;}
        [JsonIgnore]
        public virtual ItemInfo _Component {get; set;}    // ItemInfo Id of the component that composes the product

        [ForeignKey("Product")]
        public string ProductId {get; set;}
        [JsonIgnore]
        public virtual ItemInfo Product {get; set;}    // ItemInfo Id of the product composed by the component (together with other components)
        
        // public TradingInfo Trading {get; set;}
    }
}