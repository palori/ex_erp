using System;
using System.Collections.Generic;

using erp_api.Models;
namespace erp_api.Data.DummyData
{
    class ClientData
    {
        DateTime ara = DateTime.Now;
        public List<Client> Get(List<Profile> profiles, List<Address> addresses)
        {
            var list = new List<Client>();
            list.Add(new Client
            {   
                // Unit
                Id = "C1",
                Profile = profiles[0],
                SendNotifications = true,
                Address = addresses[0]
            });

            list.Add(new Client
            {   
                // Unit
                Id = "C2",
                Profile = profiles[1],
                SendNotifications = false,
                Address = addresses[1]
            });

            return list;
        }
    }
}