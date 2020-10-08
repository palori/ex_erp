using System;

namespace ERP.Models
{
    public class Info: IEntity<string>
    {
        public string Id {get; set;}
        public string Name {get; set;}
        public string Description {get; set;}
    }
}