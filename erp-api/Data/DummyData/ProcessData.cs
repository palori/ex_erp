using System;
using System.Collections.Generic;

using erp_api.Models;
namespace erp_api.Data.DummyData
{
    class ProcessData
    {
        /*
         
        ATTENTION!!!

        `ProcessInfo`, `Process`, `ItemInfoProcessInfo`, `OrderItemProcessInfo` and all the parameters of the other models that are related to theese models are temporarily inactive!
         */
        DateTime ara = DateTime.Now;

        public List<Process> Get(List<ProcessInfo> processInfos, List<Contact> contacts)
        {
            var list = new List<Process>();
            
            // Orders
            list.Add(new Process
            {
                Id = "P-1",
                Started = ara - new TimeSpan(24,0,0),
                Finished = ara - new TimeSpan(12,0,0),
                AssignedTo = contacts[6],
                ProcessInfo = processInfos[0]
            });

            return list;
        }
    }
}