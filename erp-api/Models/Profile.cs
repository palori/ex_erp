using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

using erp_api.Data.DTO;

namespace erp_api.Models
{
    public class Profile: IEntity<string>
    {
        #nullable enable
        public string? Id {get; set;}
        public string? Surnames {get; set;}
        public bool? Gender {get; set;}
        public int? Year {get; set;}
        #nullable disable

        //ForeignKeys
        [ForeignKey("Contact")]
        public string ContactId {get; set;}
        [JsonIgnore]
        public virtual Contact Contact {get; set;}

        public void Update<T>(T entity, string id, Contact contact) where T: class, IProfile
        {
            if (id != null) this.Id = id;
            if (contact != null) this.Contact = contact;
            if (entity.Surnames != null) this.Surnames = entity.Surnames;
            if (entity.Gender != null) this.Gender = entity.Gender;
            if (entity.Year != null) this.Year = entity.Year;
        }
    }
}