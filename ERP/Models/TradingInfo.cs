using System;

namespace ERP.Models
{
    public class TradingInfo
    {
        public string Id {get; set;}
        public string Reference {get; set;}     // Id: pot ser de molts, supplier...
        // public virtual string Reference {get; set;}     // Id: pot ser de molts, supplier...
        public float Price {get; set;}
        public float Iva {get; set;}
        public int MinUnits {get; set;}
        public int PackUnits {get; set;}
        public TimeSpan DeliveryTime {get; set;}
    }
}