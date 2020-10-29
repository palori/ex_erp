using System;
using System.Collections.Generic;

using erp_api.Models;
namespace erp_api.Data.DummyData
{
    class OrderItemProcessInfoData
    {
        DateTime ara = DateTime.Now;
        public List<OrderItemProcessInfo> Get(List<OrderItem> items, List<ProcessInfo> processes)
        {
            var list = new List<OrderItemProcessInfo>();
            list.Add(new OrderItemProcessInfo
            {
                Item = items[0],
                Process = processes[0]
            });

            return list;
        }
    }
}