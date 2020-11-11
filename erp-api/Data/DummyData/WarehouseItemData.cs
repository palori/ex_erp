using System;
using System.Collections.Generic;

using erp_api.Models;
namespace erp_api.Data.DummyData
{
    class WarehouseItemData
    {
        public List<WarehouseItem> Get(List<ItemInfo> items)
        {
            var list = new List<WarehouseItem>();

            list.Add(new WarehouseItem
            {
                Units = 100,
                State = 1,
                ItemInfo = items[0]
            });

            list.Add(new WarehouseItem
            {
                Units = 200,
                State = 2,
                ItemInfo = items[1]
            });

            list.Add(new WarehouseItem
            {
                Units = 50,
                State = 3,
                ItemInfo = items[2]
            });

            list.Add(new WarehouseItem
            {
                Units = 10,
                State = 4,
                ItemInfo = items[3]
            });

            return list;
        }
    }
}