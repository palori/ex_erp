using System;

namespace erp_api.Models
{
    public class Process: IEntity<string>
    {
        public string Id {get; set;}
        public virtual ProcessInfo ProcessInfo {get; set;}
        public DateTime Started {get; set;}
        public string AssignedTo {get; set;}    // Id: TeamMemberId, SupplierId
        // public virtual string AssignedTo {get; set;}    // Id: TeamMemberId, SupplierId
    }
}