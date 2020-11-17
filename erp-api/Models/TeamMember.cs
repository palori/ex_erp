using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

using erp_api.Data.DTO;

namespace erp_api.Models
{
    public class TeamMember: IEntity<string>
    {
        public string Id {get; set;}
        public string Role {get; set;}
        public bool? IsAdmin {get; set;}
        public string Nif {get; set;}
        public float? Salary {get; set;}

        //ForeignKeys
        [ForeignKey("Profile")]
        public string ProfileId {get; set;}
        [JsonIgnore]
        public Profile Profile {get; set;}
        
        [ForeignKey("Address")]   //seems optional
        public string AddressId {get; set;}
        [JsonIgnore]
        public virtual Address Address {get; set;}

        public void Update<T>(T entity, Profile profile, Address address) where T: TeamMemberDto
        {
            if (entity.Id != null) this.Id = entity.Id;
            if (entity.Role != null) this.Role = entity.Role;
            if (entity.IsAdmin != null) this.IsAdmin = entity.IsAdmin;
            if (entity.Nif != null) this.Nif = entity.Nif;
            if (entity.Salary != null) this.Salary = entity.Salary;
            if (profile != null) this.Profile = profile;
            if (address != null) this.Address = address;
        }
    }
}