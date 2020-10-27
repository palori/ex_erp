using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Threading.Tasks;

using erp_api.Contexts;

namespace erp_api.Data.DummyData
{
    class DummyData
    {
        static DateTime ara = DateTime.Now;
        public static void Initialize(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ErpContext>();
                context.Database.EnsureCreated();
                //context.Database.Migrate();

                AddData(context);

                context.SaveChanges();
            }
        }
        public static void Test()
        {
            // Check if DB is created? (Library example method)
            using(var context = new ErpContext())
            {
                // Creates the database if not exists
                context.Database.EnsureCreated(); // dbNotExisting = true -> create DB, false -> does nothing

                // Add some data if the DB or no data exists
                AddData(context);

                // Saves changes
                context.SaveChanges();
            }
        }

        public static void AddData(ErpContext context)
        {
            // Independent Entities (do not depend on other entities)
                if (!context.Address.Any())
                {
                    context.Address.AddRange(new AddressData().Get());
                    context.SaveChanges();
                }

                if (!context.ProcessInfo.Any())
                {
                    context.ProcessInfo.AddRange(new ProcessInfoData().Get());
                    context.SaveChanges();
                }

                if (!context.TradingInfo.Any())
                {
                    context.TradingInfo.AddRange(new TradingInfoData().Get());
                    context.SaveChanges();
                }

                // Dependent Entities (depend on other entities)
                if (!context.Client.Any())
                {
                    var addresses = context.Address.ToList();
                    context.Client.AddRange(new ClientData().Get(addresses));
                    context.SaveChanges();
                }

                if (!context.Supplier.Any())
                {
                    var addresses = context.Address.ToList();
                    context.Supplier.AddRange(new SupplierData().Get(addresses));
                    context.SaveChanges();
                }

                if (!context.TeamMember.Any())
                {
                    var addresses = context.Address.ToList();
                    context.TeamMember.AddRange(new TeamMemberData().Get(addresses));
                    context.SaveChanges();
                }

                if (!context.ItemInfo.Any())
                {
                    var tradingInfos = context.TradingInfo.ToList();
                    var processInfos = context.ProcessInfo.ToList();
                    context.ItemInfo.AddRange(new ItemInfoData().Get(tradingInfos, processInfos));
                    context.SaveChanges();
                }

                if (!context.Component.Any())
                {
                    var items = context.ItemInfo.ToList();
                    context.Component.AddRange(new ComponentData().Get(items));
                    context.SaveChanges();
                }

                // Still to create data
                if (!context.Order.Any())
                {
                    context.Order.AddRange(new OrderData().Get());
                    context.SaveChanges();
                }

                if (!context.Warehouse.Any())
                {
                    context.Warehouse.AddRange(new WarehouseData().Get());
                    context.SaveChanges();
                }
        }

    }
}