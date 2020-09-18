using System;

namespace ERP.Models
{
    public class Unit
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public string PhoneNumber {get; set;}
        public string Email {get; set;}
        public DateTime Registered {get; set;}
        public DateTime LastUpdated {get; set;}
    }
}