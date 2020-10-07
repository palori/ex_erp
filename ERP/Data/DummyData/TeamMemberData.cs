using System;
using System.Collections.Generic;

using ERP.Models;
namespace ERP.Data.DummyData
{
    class TeamMemberData
    {
        DateTime ara = DateTime.Now;
        public List<TeamMember> Get(List<Address> addresses)
        {
            var list = new List<TeamMember>();
            list.Add(new TeamMember
            {
                // Unit
                Id = "TM1",
                Name = "Frederik",
                PhoneNumber = "80 21 12 08",
                Email = "fred@erik.com",
                Registered = ara,
                LastUpdated = ara,
                // Person
                Surnames = "Skov",
                Gender = true,
                Year = 1990,
                // TeamMember
                Role = "Engineer",
                IsAdmin = false,
                Address = addresses[5],
                Nif = "33334444A",
                Salary = 1000.0F
            });

            list.Add(new TeamMember
            {
                // Unit
                Id = "TM2",
                Name = "Christina",
                PhoneNumber = "40 21 12 04",
                Email = "cj@johannsen.com",
                Registered = ara,
                LastUpdated = ara,
                // Person
                Surnames = "Johannsen",
                Gender = false,
                Year = 1995,
                // TeamMember
                Role = "Marketing",
                IsAdmin = true,
                Address = addresses[5],
                Nif = "44445555A",
                Salary = 2000.0F
            });

            return list;
        }
    }
}