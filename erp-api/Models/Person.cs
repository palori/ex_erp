using System;
using System.Text.Json.Serialization;

namespace erp_api.Models
{
    public class Person: Profile
    {
        public string Surnames {get; set;}
        public bool Gender {get; set;}
        public int Year {get; set;}

        [JsonIgnore]
        public string Password {get; set;}
    }
}