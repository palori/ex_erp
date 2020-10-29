using System;
using System.Collections.Generic;

using erp_api.Models;
namespace erp_api.Data.DummyData
{
    class TeamMemberData
    {
        DateTime ara = DateTime.Now;
        public List<TeamMember> Get(List<Profile> profiles, List<Address> addresses)
        {
            var list = new List<TeamMember>();
            list.Add(new TeamMember
            {
                Id = "TM1",
                Profile = profiles[2],
                Role = "Engineer",
                IsAdmin = false,
                Address = addresses[5],
                Nif = "33334444A",
                Salary = 1000.0F
            });

            list.Add(new TeamMember
            {
                Id = "TM2",
                Profile = profiles[3],
                Role = "Marketing",
                IsAdmin = true,
                Address = addresses[6],
                Nif = "44445555A",
                Salary = 2000.0F
            });

            return list;
        }
    }
}