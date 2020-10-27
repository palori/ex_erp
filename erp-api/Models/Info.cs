using System;

namespace erp_api.Models
{
    public class Info: IEntity<string>
    {
        public string Id {get; set;}
        public string Name {get; set;}
        public string Description {get; set;}
    }
}