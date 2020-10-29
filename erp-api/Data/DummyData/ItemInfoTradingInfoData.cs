using System;
using System.Collections.Generic;

using erp_api.Models;
namespace erp_api.Data.DummyData
{
    class ItemInfoTradingInfoData
    {
        DateTime ara = DateTime.Now;
        public List<ItemInfoTradingInfo> Get(List<ItemInfo> items, List<TradingInfo> tradings)
        {
            var list = new List<ItemInfoTradingInfo>();
            list.Add(new ItemInfoTradingInfo
            {
                Item = items[0],
                Trading = tradings[0]
            });

            return list;
        }
    }
}