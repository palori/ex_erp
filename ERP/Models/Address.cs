using System;

namespace ERP.Models
{
    public class Address: IEntity<string>
    {
        public string Id {get; set;}
        public string Street {get; set;}
        public int Number {get; set;}
        public string Floor_Door {get; set;}
        public string City {get; set;}
        public int PostalCode {get; set;}
        public string Country {get; set;}

        //ForeignKeys
        public string SupplierId {get; set;}
    }
}