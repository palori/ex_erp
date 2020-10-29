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
                if (!context.Contact.Any())
                {
                    context.Contact.AddRange(new ContactData().Get());
                    context.SaveChanges();
                }
                
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


                // Dependent Entities (depend on other entities)
                if (!context.TradingInfo.Any())
                {
                    var contacts = context.Contact.ToList();
                    context.TradingInfo.AddRange(new TradingInfoData().Get(contacts));
                    context.SaveChanges();
                }

                if (!context.Profile.Any())
                {
                    var contacts = context.Contact.ToList();
                    context.Profile.AddRange(new ProfileData().Get(contacts));
                    context.SaveChanges();
                }
                
                if (!context.Client.Any())
                {
                    var profiles = context.Profile.ToList();
                    var addresses = context.Address.ToList();
                    context.Client.AddRange(new ClientData().Get(profiles, addresses));
                    context.SaveChanges();
                }

                if (!context.Supplier.Any())
                {
                    var contacts = context.Contact.ToList();
                    var addresses = context.Address.ToList();
                    context.Supplier.AddRange(new SupplierData().Get(contacts, addresses));
                    context.SaveChanges();
                }

                if (!context.TeamMember.Any())
                {
                    var profiles = context.Profile.ToList();
                    var addresses = context.Address.ToList();
                    context.TeamMember.AddRange(new TeamMemberData().Get(profiles, addresses));
                    context.SaveChanges();
                }

                /* if (!context.ItemInfo.Any())
                {
                    var tradingInfos = context.TradingInfo.ToList();
                    var processInfos = context.ProcessInfo.ToList();
                    context.ItemInfo.AddRange(new ItemInfoData().Get(tradingInfos, processInfos));
                    context.SaveChanges();
                }

                if (!context.OrderItemProcessInfo.Any())
                {
                    var items = context.OrderItem.ToList();
                    var processes = context.ProcessInfo.ToList();
                    context.OrderItemProcessInfo.AddRange(new OrderItemProcessInfoData().Get(items, processes));
                    context.SaveChanges();
                }

                if (!context.ItemInfoProcessInfo.Any())
                {
                    var items = context.ItemInfo.ToList();
                    var processes = context.ProcessInfo.ToList();
                    context.ItemInfoProcessInfo.AddRange(new ItemInfoProcessInfoData().Get(items, processes));
                    context.SaveChanges();
                }
                
                if (!context.ItemInfoTradingInfo.Any())
                {
                    var items = context.ItemInfo.ToList();
                    var tradings = context.TradingInfo.ToList();
                    context.ItemInfoTradingInfo.AddRange(new ItemInfoTradingInfoData().Get(items, tradings));
                    context.SaveChanges();
                } */

                // Still to create data
                if (!context.Order.Any())
                {
                    context.Order.AddRange(new OrderData().Get());
                    context.SaveChanges();
                }

                if (!context.WarehouseItem.Any())
                {
                    context.WarehouseItem.AddRange(new WarehouseItemData().Get());
                    context.SaveChanges();
                }
        }

    }
}