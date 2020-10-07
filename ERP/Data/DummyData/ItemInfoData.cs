using System;
using System.Collections.Generic;

using ERP.Models;
namespace ERP.Data.DummyData
{
    class ItemInfoData
    {
        public List<ItemInfo> Get(List<TradingInfo> tradingInfos, List<ProcessInfo> processInfos)
        {
            var list = new List<ItemInfo>();
            
            // Components
            var ii1 = new ItemInfo
            {
                 // Info
                Id = "II1",
                Name = "PCB basic",
                Description = "The electronic board (PCB) for the basic unit.",
                // ItemInfo
                LinkImages = "images/ii1",
                Category = "EL-component",
                Processes = processInfos.GetRange(6,4),
                BuyInfo = tradingInfos.GetRange(0,1)
            };

            var ii2 = new ItemInfo
            {
                 // Info
                Id = "II2",
                Name = "Screw M3 10mm",
                Description = "Screw M3 10mm.",
                // ItemInfo
                LinkImages = "images/ii2",
                Category = "ME-component",
                Processes = processInfos.GetRange(6,4),
                BuyInfo = tradingInfos.GetRange(1,2)
            };

            // Protucts
            var ii3 = new ItemInfo
            {
                 // Info
                Id = "II3",
                Name = "Prod. basic",
                Description = "This is the basic product we sell.",
                // ItemInfo
                LinkImages = "images/ii3",
                Category = "product",
                Processes = processInfos.GetRange(0,6),
                SellInfo = tradingInfos.GetRange(3,2)
            };

            var ii4 = new ItemInfo
            {
                 // Info
                Id = "II4",
                Name = "Prod. mod.",
                Description = "This is the mod. product we sell.",
                // ItemInfo
                LinkImages = "images/ii4",
                Category = "product",
                Processes = processInfos.GetRange(0,6),
                SellInfo = tradingInfos.GetRange(5,2)
            };

            // Add Items
            list.Add(ii1);
            list.Add(ii2);
            list.Add(ii3);
            list.Add(ii4);

            return list;
        }
    }
}