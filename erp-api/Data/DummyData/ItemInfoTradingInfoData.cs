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
                ItemInfo = items[0],
                Trading = tradings[0]
            });

            list.Add(new ItemInfoTradingInfo
            {
                ItemInfo = items[1],
                Trading = tradings[1]
            });

            list.Add(new ItemInfoTradingInfo
            {
                ItemInfo = items[1],
                Trading = tradings[2]
            });

            list.Add(new ItemInfoTradingInfo
            {
                ItemInfo = items[2],
                Trading = tradings[3]
            });

            list.Add(new ItemInfoTradingInfo
            {
                ItemInfo = items[2],
                Trading = tradings[4]
            });

            list.Add(new ItemInfoTradingInfo
            {
                ItemInfo = items[3],
                Trading = tradings[5]
            });

            list.Add(new ItemInfoTradingInfo
            {
                ItemInfo = items[3],
                Trading = tradings[6]
            });

            return list;
        }
    }
}