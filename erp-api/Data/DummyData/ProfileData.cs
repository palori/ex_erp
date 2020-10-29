using System;
using System.Collections.Generic;

using erp_api.Models;
namespace erp_api.Data.DummyData
{
    class ProfileData
    {
        DateTime ara = DateTime.Now;
        public List<Profile> Get(List<Contact> contacts)
        {
            var list = new List<Profile>();
            list.Add(new Profile
            {   
                // Unit
                Id = "C1",
                Contact = contacts[0],
                Surnames = "Time Yesterday",
                Gender = true,
                Year = 1800
            });

            list.Add(new Profile
            {   
                // Unit
                Id = "C2",
                Contact = contacts[1],
                Surnames = "Tin Tin",
                Gender = true,
                Year = 1700
            });

            list.Add(new Profile
            {
                Id = "TM1",
                Contact = contacts[4],
                Surnames = "Skov",
                Gender = true,
                Year = 1990
            });

            list.Add(new Profile
            {
                Id = "TM2",
                Contact = contacts[5],
                Surnames = "Johannsen",
                Gender = false,
                Year = 1995
            });

            return list;
        }
    }
}