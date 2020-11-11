using System;
using System.Collections.Generic;

using erp_api.Models;
namespace erp_api.Data.DummyData
{
    class ProcessInfoData
    {
        /*
         
        ATTENTION!!!

        `ProcessInfo`, `Process`, `ItemInfoProcessInfo`, `OrderItemProcessInfo` and all the parameters of the other models that are related to theese models are temporarily inactive!
         */
        public List<ProcessInfo> Get()
        {
            var list = new List<ProcessInfo>();
            
            // Orders
            list.Add(new ProcessInfo
            {
                // Info
                Id = "PI-O-1",
                Name = "Created",
                Description = "Order created.",
                // ProcessInfo
                EstimatedDuration = new TimeSpan(0,0,0)
            });

            list.Add(new ProcessInfo
            {
                // Info
                Id = "PI-O-2",
                Name = "Assigned",
                Description = "Order assigned.",
                // ProcessInfo
                EstimatedDuration = new TimeSpan(0,30,0)
            });

            list.Add(new ProcessInfo
            {
                // Info
                Id = "PI-O-3",
                Name = "WIP",
                Description = "Order wip.",
                // ProcessInfo
                EstimatedDuration = new TimeSpan(48,0,0)
            });

            list.Add(new ProcessInfo
            {
                // Info
                Id = "PI-O-4",
                Name = "Cancelled",
                Description = "Order cancelled.",
                // ProcessInfo
                EstimatedDuration = new TimeSpan(0,0,0)
            });

            list.Add(new ProcessInfo
            {
                // Info
                Id = "PI-O-5",
                Name = "Shipped",
                Description = "Order shipped.",
                // ProcessInfo
                EstimatedDuration = new TimeSpan(48,0,0)
            });

            list.Add(new ProcessInfo
            {
                // Info
                Id = "PI-O-6",
                Name = "Delivered",
                Description = "Order delivered.",
                // ProcessInfo
                EstimatedDuration = new TimeSpan(12,0,0)
            });


            // Items
            list.Add(new ProcessInfo
            {
                // Info
                Id = "PI-I-1",
                Name = "Buy",
                Description = "Buy component.",
                // ProcessInfo
                EstimatedDuration = new TimeSpan(0,30,0)
            });

            list.Add(new ProcessInfo
            {
                // Info
                Id = "PI-I-2",
                Name = "Assembly",
                Description = "Assembly components.",
                // ProcessInfo
                EstimatedDuration = new TimeSpan(0,45,0)
            });

            list.Add(new ProcessInfo
            {
                // Info
                Id = "PI-I-3",
                Name = "Program",
                Description = "Program product.",
                // ProcessInfo
                EstimatedDuration = new TimeSpan(0,5,0)
            });

            list.Add(new ProcessInfo
            {
                // Info
                Id = "PI-I-4",
                Name = "Test",
                Description = "Test product.",
                // ProcessInfo
                EstimatedDuration = new TimeSpan(0,15,0)
            });

            return list;
        }
    }
}