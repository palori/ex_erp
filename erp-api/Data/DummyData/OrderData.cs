using System;
using System.Collections.Generic;

using erp_api.Models;
namespace erp_api.Data.DummyData
{
    class OrderData
    {
        DateTime ara = DateTime.Now;
        public List<Order> Get(List<Contact> contacts, List<Address> addresses)
        {
            var list = new List<Order>();

            list.Add(new Order
            {
                Id = "O-1",
                Priority = 1,
                Ordered = ara - new TimeSpan(100,0,0),
                Reference = contacts[4],
                Address = addresses[2]
            });

            list.Add(new Order
            {
                Id = "O-2",
                Priority = 5,
                Ordered = ara - new TimeSpan(524,0,0),
                Reference = contacts[0],
                Address = addresses[0]
            });

            list.Add(new Order
            {
                Id = "O-3",
                Priority = 5,
                Ordered = ara - new TimeSpan(500,0,0),
                Reference = contacts[0],
                Address = addresses[0]
            });
            
            list.Add(new Order
            {
                Id = "O-4",
                Priority = 5,
                Ordered = ara - new TimeSpan(50,0,0),
                Reference = contacts[0],
                Address = addresses[0]
            });
            
            list.Add(new Order
            {
                Id = "O-5",
                Priority = 5,
                Ordered = ara - new TimeSpan(48,0,0),
                Reference = contacts[0],
                Address = addresses[0]
            });
            
            list.Add(new Order
            {
                Id = "O-6",
                Priority = 5,
                Ordered = ara - new TimeSpan(24,0,0),
                Reference = contacts[0],
                Address = addresses[0]
            });

            return list;
        }
    }
}