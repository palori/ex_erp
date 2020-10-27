using System;
using System.Collections.Generic;

using erp_api.Models;
namespace erp_api.Data.DummyData
{
    class SupplierData
    {
        DateTime ara = DateTime.Now;
        public List<Supplier> Get(List<Address> addresses)
        {
            var list = new List<Supplier>();
            list.Add(new Supplier
            {
                // Unit
                Id = "S1",
                Name = "Electronics DK",
                PhoneNumber = "123 456 789",
                Email = "dk@electronics.com",
                Registered = ara,
                LastUpdated = ara,
                // Person
                Cif = "B-12321232",
                Addresses = addresses.GetRange(2,2)
            });

            list.Add(new Supplier
            {
                // Unit
                Id = "S2",
                Name = "Molds BE",
                PhoneNumber = "80 21 12 08",
                Email = "be@molds.com",
                Registered = ara,
                LastUpdated = ara,
                // Person
                Cif = "B-12345678",
                Addresses = addresses.GetRange(4,1)
            });

            return list;
        }
    }
}