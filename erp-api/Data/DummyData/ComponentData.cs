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
                    Units = 1,
                    _Component = items[0],
                    Product = items[2],
                },
                new Component
                {
                    Units = 10,
                    _Component = items[1],
                    Product = items[2],
                },
                new Component
                {
                    Units = 2,
                    _Component = items[0],
                    Product = items[3],
                },
                new Component
                {
                    Units = 20,
                    _Component = items[1],
                    Product = items[3],
                }
            };

            return list;
        }
    }
}