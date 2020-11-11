using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace erp_api.Models
{
    public class WarehouseItem: IEntity<int>
    {
        public int Id {get; set;}
        public int Units {get; set;}
        public int State {get; set;}

        // Foreign Keys
        [ForeignKey("ItemInfo")]
        public string ItemInfoId {get; set;}
        [JsonIgnore]
        public virtual ItemInfo ItemInfo {get; set;}
    }
}