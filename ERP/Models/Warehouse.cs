using System;
using System.Collections.Generic;

namespace ERP.Models
{
    public class Warehouse
    {
        public virtual ItemInfo ItemInfo {get; set;}
        public int Units {get; set;}
        public int State {get; set;}
    }
}