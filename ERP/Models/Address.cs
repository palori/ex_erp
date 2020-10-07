using System;

namespace ERP.Models
{
    public class Address: IEntityStr
    {
        public string Id {get; set;}
        public string Street {get; set;}
        public int Number {get; set;}
        public string Floor_Door {get; set;}
        public string City {get; set;}
        public int PostalCode {get; set;}
        public string Country {get; set;}
    }
}