using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;


namespace erp_api.Models
{
    public class Profile: IEntity<string>
    {
        public string Id {get; set;}
        public string Surnames {get; set;}
        public bool Gender {get; set;}
        public int Year {get; set;}

        //ForeignKeys
        [ForeignKey("Contact")]
        public string ContactId {get; set;}
        [JsonIgnore]
        public virtual Contact Contact {get; set;}
    }
}