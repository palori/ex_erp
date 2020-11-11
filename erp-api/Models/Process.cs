using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace erp_api.Models
{
    public class Process: IEntity<string>
    {
        /*
         
        ATTENTION!!!

        `ProcessInfo`, `Process`, `ItemInfoProcessInfo`, `OrderItemProcessInfo` and all the parameters of the other models that are related to theese models are temporarily inactive!
         */
        public string Id {get; set;}
        public DateTime Started {get; set;}
        public DateTime Finished {get; set;}

        // Foreign Keys
        [ForeignKey("AssignedTo")]
        public string AssignedToId {get; set;}
        [JsonIgnore]
        public virtual Contact AssignedTo {get; set;}    // Id: TeamMemberId, SupplierId
        // public string AssignedTo {get; set;}    // Id: TeamMemberId, SupplierId
        // public virtual string AssignedTo {get; set;}    // Id: TeamMemberId, SupplierId

        [ForeignKey("ProcessInfo")]
        public string ProcessInfoId {get; set;}
        [JsonIgnore]
        public virtual ProcessInfo ProcessInfo {get; set;}
    }
}