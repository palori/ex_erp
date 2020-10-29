using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace erp_api.Models
{
    public class Client: IEntity<string>
    {
        public string Id {get; set;}
        public bool SendNotifications {get; set;}

        //ForeignKeys
        [ForeignKey("Profile")]
        public string ProfileId {get; set;}
        [JsonIgnore]
        public Profile Profile {get; set;}

        [ForeignKey("Address")]
        public string AddressId {get; set;}
        [JsonIgnore]
        public virtual Address Address {get; set;}
    }
}