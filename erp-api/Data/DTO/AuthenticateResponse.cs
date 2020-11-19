using System;
using erp_api.Models;

namespace erp_api.Data.DTO
{
    public class AuthenticateResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber {get; set;}
        public string Email {get; set;}
        public DateTime? Registered {get; set;}
        public DateTime? LastUpdated {get; set;}
        public string Token { get; set; }


        public AuthenticateResponse(Contact contact, string token)
        {
            Id = contact.Id;
            Name = contact.Name;
            PhoneNumber = contact.PhoneNumber;
            Email = contact.Email;
            Registered = contact.Registered;
            LastUpdated = contact.LastUpdated;
            Token = token;
        }
    }
}