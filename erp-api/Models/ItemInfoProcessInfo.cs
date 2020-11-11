using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace erp_api.Models
{
    public class ItemInfoProcessInfo: IEntity<int>
    {
        /*
         
        ATTENTION!!!

        `ProcessInfo`, `Process`, `ItemInfoProcessInfo`, `OrderItemProcessInfo` and all the parameters of the other models that are related to theese models are temporarily inactive!
         */
        public int Id {get; set;}

        // Foreign Keys
        [ForeignKey("Item")]
        public string ItemId {get; set;}
        [JsonIgnore]
        public virtual ItemInfo Item {get; set;}

        [ForeignKey("Process")]
        public string ProcessId {get; set;}
        [JsonIgnore]
        public virtual ProcessInfo Process {get; set;}
    }
}