using System;
using System.Collections.Generic;

using erp_api.Models;
namespace erp_api.Data.DummyData
{
    class SupplierData
    {
        DateTime ara = DateTime.Now;
        public List<Supplier> Get(List<Contact> contacts, List<Address> addresses)
        {
            var list = new List<Supplier>();
            list.Add(new Supplier
            {
                Id = "S1",
                Contact = contacts[2],
                Cif = "B-12321232",
                Address = addresses[2]
                // Addresses = addresses.GetRange(2,2)
            });

            list.Add(new Supplier
            {
                Id = "S2",
                Contact = contacts[3],
                Cif = "B-12345678",
                Address = addresses[4]
                // Addresses = addresses.GetRange(4,1)
            });

            return list;
        }
    }
}