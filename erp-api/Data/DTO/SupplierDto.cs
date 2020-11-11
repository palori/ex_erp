using System;

using erp_api.Models;

namespace erp_api.Data.DTO
{
    public class SupplierDto
    {
        // Contact
        public string Name {get; set;}
        public string PhoneNumber {get; set;}
        public string Email {get; set;}
        public DateTime Registered {get; set;}
        public DateTime LastUpdated {get; set;}

        // TeamMember
        public string Id {get; set;}
        public string Cif {get; set;}
        public string AddressId {get; set;}

        public SupplierDto(){}
        public SupplierDto(Contact contact, Supplier supplier)
        {
            this.Name = contact.Name;
            this.PhoneNumber = contact.PhoneNumber;
            this.Email = contact.Email;
            this.Registered = contact.Registered;
            this.LastUpdated = contact.LastUpdated;

            this.Id = supplier.Id;
            this.Cif = supplier.Cif;
            this.AddressId = supplier.AddressId;
        }
    }
}