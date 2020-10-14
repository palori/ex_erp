using System;

namespace ERP.Models
{
    public class Client: Person
    {
        public bool SendNotifications {get; set;}

        //ForeignKeys
        public string AddressId {get; set;}
        public virtual Address Address {get; set;}
    }
}