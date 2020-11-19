using System;
using System.Text.Json.Serialization;

using erp_api.Data.DTO;

namespace erp_api.Models
{
    public class Contact: IEntity<string>
    {
        #nullable enable
        public string? Id {get; set;}
        public string? Name {get; set;}
        public string? PhoneNumber {get; set;}
        public string? Email {get; set;}
        public DateTime? Registered {get; set;}
        public DateTime? LastUpdated {get; set;}
        #nullable disable

        [JsonIgnore]
        public string Password {get; set;}

        public void Update<T>(T entity) where T: class, IContact
        {
            if (entity.Name != null) this.Name = entity.Name;
            if (entity.PhoneNumber != null) this.PhoneNumber = entity.PhoneNumber;
            if (entity.Email != null) this.Email = entity.Email;
            if (entity.Registered != null) this.Registered = entity.Registered;
            if (entity.LastUpdated != null) this.LastUpdated = entity.LastUpdated;
        }
        
        public void Add<T>(T entity, string id) where T: class, IContact
        {
            if (entity.Id != null) this.Id = id;
            Update<T>(entity);
        }
    }
}