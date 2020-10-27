using System;
using System.Collections.Generic;

using erp_api.Models;
namespace erp_api.Data.DummyData
{
    class ComponentData
    {
        public List<Component> Get(List<ItemInfo> items)
        {
            var list = new List<Component>()
            {
                new Component
                {
                    ItemInfo = items[0],
                    Product = items[2],
                    Units = 1
                },
                new Component
                {
                    ItemInfo = items[1],
                    Product = items[2],
                    Units = 10
                },
                new Component
                {
                    ItemInfo = items[0],
                    Product = items[3],
                    Units = 2
                },
                new Component
                {
                    ItemInfo = items[1],
                    Product = items[3],
                    Units = 20
                }
            };

            return list;
        }
    }
}