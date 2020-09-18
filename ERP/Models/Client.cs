using System;

namespace ERP.Models
{
    public class Client: Person
    {
        public bool SendNotifications {get; set;}
        public virtual Address Address {get; set;}
    }
}