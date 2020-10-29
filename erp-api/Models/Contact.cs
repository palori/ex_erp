using System;
using System.Text.Json.Serialization;

namespace erp_api.Models
{
    public class Contact: IEntity<string>
    {
        public string Id {get; set;}
        public string Name {get; set;}
        public string PhoneNumber {get; set;}
        public string Email {get; set;}
        public DateTime Registered {get; set;}
        public DateTime LastUpdated {get; set;}

        [JsonIgnore]
        public string Password {get; set;}
    }
}