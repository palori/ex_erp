using System;

namespace erp_api.Models
{
    public class Client: Person
    {
        public bool SendNotifications {get; set;}

        //ForeignKeys
        public string AddressId {get; set;}
        public virtual Address Address {get; set;}
    }
}