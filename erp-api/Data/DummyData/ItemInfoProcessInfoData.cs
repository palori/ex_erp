using System;
using System.Collections.Generic;

using erp_api.Models;
namespace erp_api.Data.DummyData
{
    class ItemInfoProcessInfoData
    {
        DateTime ara = DateTime.Now;
        public List<ItemInfoProcessInfo> Get(List<ItemInfo> items, List<ProcessInfo> processes)
        {
            var list = new List<ItemInfoProcessInfo>();
            list.Add(new ItemInfoProcessInfo
            {
                Item = items[0],
                Process = processes[0]
            });

            return list;
        }
    }
}