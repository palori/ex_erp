using System;
using System.Collections.Generic;

using erp_api.Models;
namespace erp_api.Data.DummyData
{
    class ContactData
    {
        DateTime ara = DateTime.Now;
        public List<Contact> Get()
        {
            var list = new List<Contact>();
            list.Add(new Contact
            {
                Id = "C1",
                Name = "Justin",
                PhoneNumber = "123456789",
                Email = "asdf",
                Registered = ara,
                LastUpdated = ara,
                Password = "1234"
            });

            list.Add(new Contact
            {
                Id = "C2",
                Name = "Martin",
                PhoneNumber = "123456780",
                Email = "martin@martin.com",
                Registered = ara,
                LastUpdated = ara,
                Password = "qwer1234"
            });

            list.Add(new Contact
            {
                Id = "S1",
                Name = "Electronics DK",
                PhoneNumber = "123 456 789",
                Email = "dk@electronics.com",
                Registered = ara,
                LastUpdated = ara
            });

            list.Add(new Contact
            {
                Id = "S2",
                Name = "Molds BE",
                PhoneNumber = "80 21 12 08",
                Email = "be@molds.com",
                Registered = ara,
                LastUpdated = ara
            });

            list.Add(new Contact
            {
                Id = "TM1",
                Name = "Frederik",
                PhoneNumber = "80 21 12 08",
                Email = "fred@erik.com",
                Registered = ara,
                LastUpdated = ara
            });

            list.Add(new Contact
            {
                Id = "TM2",
                Name = "Christina",
                PhoneNumber = "40 21 12 04",
                Email = "cj@johannsen.com",
                Registered = ara,
                LastUpdated = ara
            });

            list.Add(new Contact    // to improve this fix
            {
                Id = "Online"
            });

            list.Add(new Contact
            {
                Id = "Distrib"
            });

            return list;
        }
    }
}