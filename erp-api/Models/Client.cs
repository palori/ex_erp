using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

using erp_api.Data.DTO;

namespace erp_api.Models
{
    public class Client: IEntity<string>
    {
        #nullable enable
        public string? Id {get; set;}
        public bool? SendNotifications {get; set;}
        #nullable disable

        //ForeignKeys
        [ForeignKey("Profile")]
        public string ProfileId {get; set;}
        [JsonIgnore]
        public Profile Profile {get; set;}

        [ForeignKey("Address")]
        public string AddressId {get; set;}
        [JsonIgnore]
        public virtual Address Address {get; set;}

        public void Update<T>(T entity, Profile profile, Address address) where T: ClientDto
        {
            if (entity.Id != null) this.Id = entity.Id;
            if (entity.SendNotifications != null) this.SendNotifications = entity.SendNotifications;
            if (profile != null) this.Profile = profile;
            if (address != null) this.Address = address;
        }
    }
}