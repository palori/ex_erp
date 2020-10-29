using System;

using erp_api.Models;

namespace erp_api.Data.DTO
{
    public class ClientDto
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

        // Client
        public string Id {get; set;}
        public bool SendNotifications {get; set;}

        public ClientDto(){}
        public ClientDto(Contact contact, Profile profile, Client client)
        {
            this.Id = profile.Id;
            this.Surnames = profile.Surnames;
            this.Gender = profile.Gender;
            this.Year = profile.Year;

            this.Name = contact.Name;
            this.PhoneNumber = contact.PhoneNumber;
            this.Email = contact.Email;
            this.Registered = contact.Registered;
            this.LastUpdated = contact.LastUpdated;

            this.Id = client.Id;
            this.SendNotifications = client.SendNotifications;
        }
    }
}