using System;
using System.Collections.Generic;

using erp_api.Models;
namespace erp_api.Data.DummyData
{
    class TradingInfoData
    {
        public List<TradingInfo> Get(List<Contact> contacts)
        {
            var list = new List<TradingInfo>();
            list.Add(new TradingInfo
            {
                Id = "II1-TI1",
                Reference = contacts[4],  // Supplier.Id
                Price = 5.5F,
                Iva = 4.0F,
                MinUnits = 1,
                PackUnits = 1,
                DeliveryTime = new TimeSpan(96,0,0),
                Trade = false
            });

            list.Add(new TradingInfo
            {
                Id = "II2-TI1",
                Reference = contacts[4],  // Supplier.Id
                Price = 2.0F,
                Iva = 4.0F,
                MinUnits = 50,
                PackUnits = 1,
                DeliveryTime = new TimeSpan(24,0,0),
                Trade = false
            });

            list.Add(new TradingInfo
            {
                Id = "II2-TI2",
                Reference = contacts[5],  // Supplier.Id
                Price = 1.8F,
                Iva = 4.0F,
                MinUnits = 50,
                PackUnits = 1,
                DeliveryTime = new TimeSpan(24,0,0),
                Trade = false
            });

            list.Add(new TradingInfo
            {
                Id = "II3-TI1",
                Reference = contacts[3],  // Supplier.Id
                Price = 120.0F,
                Iva = 21.0F,
                MinUnits = 1,
                PackUnits = 1,
                DeliveryTime = new TimeSpan(96,0,0),
                Trade = true
            });

            list.Add(new TradingInfo
            {
                Id = "II3-TI2",
                Reference = contacts[2],  // Supplier.Id
                Price = 90.0F,
                Iva = 21.0F,
                MinUnits = 1,
                PackUnits = 100,
                DeliveryTime = new TimeSpan(336,0,0), // 14 dies * 24h
                Trade = true
            });

            list.Add(new TradingInfo
            {
                Id = "II4-TI1",
                Reference = contacts[3],  // Supplier.Id
                Price = 150.0F,
                Iva = 21.0F,
                MinUnits = 1,
                PackUnits = 1,
                DeliveryTime = new TimeSpan(96,0,0),
                Trade = true
            });

            list.Add(new TradingInfo
            {
                Id = "II4-TI2",
                Reference = contacts[2],  // Supplier.Id
                Price = 110.0F,
                Iva = 21.0F,
                MinUnits = 1,
                PackUnits = 100,
                DeliveryTime = new TimeSpan(336,0,0), // 14 dies * 24h
                Trade = true
            });

            return list;
        }
    }
}