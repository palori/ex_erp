using System;
using System.Collections.Generic;

namespace erp_api.Models
{
    public class Component: IEntity<int>
    {
        /* public List<string> Id {get; set;}    // ItemInfo Id of the component
        public virtual List<ItemInfo> ItemInfo {get; set;}    // ItemInfo Id of the product composed by this component and others */
        public int Id {get; set;}    // ItemInfo Id of the component
        public virtual ItemInfo ItemInfo {get; set;}    // ItemInfo Id of the product composed by this component and others
        public virtual ItemInfo Product {get; set;}    // ItemInfo Id of the product composed by this component and others
        public int Units {get; set;}
        // public List<int> Units {get; set;}

    }
}