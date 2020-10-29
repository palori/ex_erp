using System;
using System.Collections.Generic;

using erp_api.Models;
namespace erp_api.Data.DummyData
{
    class AddressData
    {
        public List<Address> Get()
        {
            var list = new List<Address>();
            list.Add(new Address
            {
                Id = "A-C1",
                Street = "Timeline",
                Number = 999,
                City = "Nowhere",
                PostalCode = 1,
                Country = "Everywhere"
            });

            list.Add(new Address{
                Id = "A-C2",
                Street = "5th Ave",
                Number = 5,
                City = "NY",
                PostalCode = 555,
                Country = "USA"
            });

            list.Add(new Address{
                Id = "A-S1-1",
                Street = "Square",
                Number = 4,
                City = "Stad1",
                PostalCode = 88,
                Country = "DE"
            });

            list.Add(new Address{
                Id = "A-S1-2",
                Street = "Circle",
                Number = 1,
                City = "Stad2",
                PostalCode = 89,
                Country = "DE"
            });

            list.Add(new Address{
                Id = "A-S2-1",
                Street = "Gamle",
                Number = 99,
                City = "Leuven",
                PostalCode = 4000,
                Country = "BE"
            });

            list.Add(new Address{
                Id = "A-TM-1",
                Street = "Nordhavn",
                Number = 10,
                City = "CPH",
                PostalCode = 2800,
                Country = "DK"
            });

            list.Add(new Address{
                Id = "A-TM-2",
                Street = "Nybrogaade",
                Number = 35,
                City = "Virum",
                PostalCode = 2801,
                Country = "DK"
            });

            return list;
        }
    }
}