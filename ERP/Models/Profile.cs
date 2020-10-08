using System;

namespace ERP.Models
{
    public class Profile: IEntity<string>
    {
        public string Id {get; set;}
        public string Name {get; set;}
        public string PhoneNumber {get; set;}
        public string Email {get; set;}
        public DateTime Registered {get; set;}
        public DateTime LastUpdated {get; set;}
    }
}