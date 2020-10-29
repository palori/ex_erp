using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace erp_api.Models
{
    public class Supplier: IEntity<string>
    {
        public string Id {get; set;}
        public string Cif {get; set;}

        //ForeignKeys
        [ForeignKey("Contact")]
        public string ContactId {get; set;}
        [JsonIgnore]
        public virtual Contact Contact {get; set;}

        [ForeignKey("Address")]
        public string AddressId {get; set;}
        [JsonIgnore]
        public virtual Address Address {get; set;} // Simplify to just one address :)
        // public virtual List<Address> Addresses {get; set;}
    }
}