using System;
using System.Collections.Generic;

using ERP.Models;
namespace ERP.Data.DummyData
{
    class ClientData
    {
        DateTime ara = DateTime.Now;
        public List<Client> Get(List<Address> addresses)
        {
            var list = new List<Client>();
            list.Add(new Client
            {   
                // Unit
                Id = "C1",
                Name = "Justin",
                PhoneNumber = "123456789",
                Email = "justin@justin.com",
                Registered = ara,
                LastUpdated = ara,
                // Person
                Surnames = "Time Yesterday",
                Gender = true,
                Year = 1800,
                // Client
                SendNotifications = true,
                Address = addresses[0]
            });

            list.Add(new Client
            {   
                // Unit
                Id = "C2",
                Name = "Martin",
                PhoneNumber = "123456780",
                Email = "martin@martin.com",
                Registered = ara,
                LastUpdated = ara,
                // Person
                Surnames = "Tin Tin",
                Gender = true,
                Year = 1700,
                // Client
                SendNotifications = false,
                Address = addresses[1]
            });

            return list;
        }
    }
}