using System;

using erp_api.Models;

namespace erp_api.Data.DTO
{
    public class TeamMemberDto
    {
        // Contact
        public string Name {get; set;}
        public string PhoneNumber {get; set;}
        public string Email {get; set;}
        public DateTime Registered {get; set;}
        public DateTime LastUpdated {get; set;}

        // Profile
        public string Surnames {get; set;}
        public bool Gender {get; set;}
        public int Year {get; set;}

        // TeamMember
        public string Id {get; set;}
        public string Role {get; set;}
        public bool IsAdmin {get; set;}
        public string Nif {get; set;}
        public float Salary {get; set;}
        public string AddressId {get; set;}

        public TeamMemberDto(){}
        public TeamMemberDto(Contact contact, Profile profile, TeamMember tm)
        {
            this.Surnames = profile.Surnames;
            this.Gender = profile.Gender;
            this.Year = profile.Year;

            this.Name = contact.Name;
            this.PhoneNumber = contact.PhoneNumber;
            this.Email = contact.Email;
            this.Registered = contact.Registered;
            this.LastUpdated = contact.LastUpdated;

            this.Id = tm.Id;
            this.Role = tm.Role;
            this.IsAdmin = tm.IsAdmin;
            this.Nif = tm.Nif;
            this.Salary = tm.Salary;
            this.AddressId = tm.AddressId;
        }
    }
}