using System;
using System.Collections.Generic;

using erp_api.Models;
namespace erp_api.Data.DummyData
{
    class TradingInfoData
    {
        public List<TradingInfo> Get()
        {
            var list = new List<TradingInfo>();
            list.Add(new TradingInfo
            {
                Id = "II1-TI1",
                Reference = "S1",  // Supplier.Id
                Price = 5.5F,
                Iva = 4.0F,
                MinUnits = 1,
                PackUnits = 1,
                DeliveryTime = new TimeSpan(96,0,0)
            });

            list.Add(new TradingInfo
            {
                Id = "II2-TI1",
                Reference = "S1",  // Supplier.Id
                Price = 2.0F,
                Iva = 4.0F,
                MinUnits = 50,
                PackUnits = 1,
                DeliveryTime = new TimeSpan(24,0,0)
            });

            list.Add(new TradingInfo
            {
                Id = "II2-TI2",
                Reference = "S2",  // Supplier.Id
                Price = 1.8F,
                Iva = 4.0F,
                MinUnits = 50,
                PackUnits = 1,
                DeliveryTime = new TimeSpan(24,0,0)
            });

            list.Add(new TradingInfo
            {
                Id = "II3-TI1",
                Reference = "Online",  // Supplier.Id
                Price = 120.0F,
                Iva = 21.0F,
                MinUnits = 1,
                PackUnits = 1,
                DeliveryTime = new TimeSpan(96,0,0)
            });

            list.Add(new TradingInfo
            {
                Id = "II3-TI2",
                Reference = "Distrib",  // Supplier.Id
                Price = 90.0F,
                Iva = 21.0F,
                MinUnits = 1,
                PackUnits = 100,
                DeliveryTime = new TimeSpan(336,0,0) // 14 dies * 24h
            });

            list.Add(new TradingInfo
            {
                Id = "II4-TI1",
                Reference = "Online",  // Supplier.Id
                Price = 150.0F,
                Iva = 21.0F,
                MinUnits = 1,
                PackUnits = 1,
                DeliveryTime = new TimeSpan(96,0,0)
            });

            list.Add(new TradingInfo
            {
                Id = "II4-TI2",
                Reference = "Distrib",  // Supplier.Id
                Price = 110.0F,
                Iva = 21.0F,
                MinUnits = 1,
                PackUnits = 100,
                DeliveryTime = new TimeSpan(336,0,0) // 14 dies * 24h
            });

            return list;
        }
    }
}