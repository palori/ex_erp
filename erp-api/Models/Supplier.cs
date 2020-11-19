using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

using erp_api.Data.DTO;

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

        public void Update<T>(T entity) where T: SupplierDto
        {
            if (entity.Cif != null) this.Cif = entity.Cif;
        }
        
        public void Add<T>(T entity, Contact contact, Address address) where T: SupplierDto
        {
            if (entity.Id != null) this.Id = entity.Id;
            if (contact != null) this.Contact = contact;
            if (address != null) this.Address = address;
            Update<T>(entity);
        }
    }
}