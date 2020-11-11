using System;

namespace erp_api.Models
{
    public class ProcessInfo: Info
    {
        /*
         
        ATTENTION!!!

        `ProcessInfo`, `Process`, `ItemInfoProcessInfo`, `OrderItemProcessInfo` and all the parameters of the other models that are related to theese models are temporarily inactive!
         */
        public TimeSpan EstimatedDuration {get; set;}
    }
}