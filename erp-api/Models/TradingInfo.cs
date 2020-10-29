using System;

namespace erp_api.Models
{
    public class TradingInfo: IEntity<string>
    {
        public string Id {get; set;}
        public float Price {get; set;}
        public float Iva {get; set;}
        public int MinUnits {get; set;}
        public int PackUnits {get; set;}
        public TimeSpan DeliveryTime {get; set;}

        public bool Trade {get; set;} // where: 0 = buy, 1 = sell

        // Foreign Keys
        public virtual Contact Reference {get; set;}     // Id: pot ser de molts, supplier...
        // public string Reference {get; set;}     // Id: pot ser de molts, supplier...
        // public virtual string Reference {get; set;}     // Id: pot ser de molts, supplier...
    }
}