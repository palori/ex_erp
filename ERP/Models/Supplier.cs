using System;
using System.Collections.Generic;

namespace ERP.Models
{
    public class Supplier: Unit
    {
        public string Cif {get; set;}
        public virtual List<Address> Addresses {get; set;}
    }
}