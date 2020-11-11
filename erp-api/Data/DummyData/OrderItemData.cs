using System;
using System.Collections.Generic;

using erp_api.Models;
namespace erp_api.Data.DummyData
{
    class OrderItemData
    {
        DateTime ara = DateTime.Now;
        public List<OrderItem> Get(List<ItemInfo> items, List<Order> orders, List<TradingInfo> tradingInfos
        // , List<Process> processes
        )
        {
            var list = new List<OrderItem>();
            
            list.Add(new OrderItem
            {
                Id = "OI-1-1",
                Units = 10,
                ItemInfo = items[0],
                Order = orders[0],
                TradingInfo = tradingInfos[0],
                // Processes = processes.GetRange(0,1)
            });

            list.Add(new OrderItem
            {
                Id = "OI-2-1",
                Units = 1,
                ItemInfo = items[2],
                Order = orders[1],
                TradingInfo = tradingInfos[3],
                // Processes = processes.GetRange(0,1)
            });

            list.Add(new OrderItem
            {
                Id = "OI-2-2",
                Units = 2,
                ItemInfo = items[3],
                Order = orders[1],
                TradingInfo = tradingInfos[5],
                // Processes = processes.GetRange(0,1)
            });

            list.Add(new OrderItem
            {
                Id = "OI-3-1",
                Units = 1,
                ItemInfo = items[2],
                Order = orders[2],
                TradingInfo = tradingInfos[3],
                // Processes = processes.GetRange(0,1)
            });

            list.Add(new OrderItem
            {
                Id = "OI-4-1",
                Units = 1,
                ItemInfo = items[2],
                Order = orders[3],
                TradingInfo = tradingInfos[3],
                // Processes = processes.GetRange(0,1)
            });

            list.Add(new OrderItem
            {
                Id = "OI-5-1",
                Units = 2,
                ItemInfo = items[2],
                Order = orders[4],
                TradingInfo = tradingInfos[3],
                // Processes = processes.GetRange(0,1)
            });

            list.Add(new OrderItem
            {
                Id = "OI-5-2",
                Units = 1,
                ItemInfo = items[3],
                Order = orders[4],
                TradingInfo = tradingInfos[5],
                // Processes = processes.GetRange(0,1)
            });
            
            list.Add(new OrderItem
            {
                Id = "OI-6-1",
                Units = 1,
                ItemInfo = items[3],
                Order = orders[5],
                TradingInfo = tradingInfos[5],
                // Processes = processes.GetRange(0,1)
            });

            return list;
        }
    }
}