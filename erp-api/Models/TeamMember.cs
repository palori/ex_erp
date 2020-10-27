using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace erp_api.Models
{
    public class TeamMember: Person
    {
        public string Role {get; set;}
        public bool IsAdmin {get; set;}
        public string Nif {get; set;}
        public float Salary {get; set;}

        //ForeignKeys
        [ForeignKey("Address")]   //seems optional
        public string AddressId {get; set;}
        [JsonIgnore]
        public virtual Address Address {get; set;}
    }
}