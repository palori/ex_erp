using System;

namespace ERP.Models
{
    public class TeamMember: Person
    {
        public string Role {get; set;}
        public bool IsAdmin {get; set;}
        public virtual Address Address {get; set;}
        public string Nif {get; set;}
        public float Salary {get; set;}
    }
}