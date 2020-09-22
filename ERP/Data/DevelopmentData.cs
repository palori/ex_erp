using System;
using System.Collections.Generic;

using ERP.Models;
using ERP.Contexts;

namespace ERP.Data
{
    class DevelopmentData
    {
        public static void Test()
        {
            // Check if DB is created? (Library example method)
            using(var context = new ErpContext())
            {
                // Creates the database if not exists
                var dbNotExisting = context.Database.EnsureCreated(); // dbNotExisting = true -> create DB, false -> does nothing

                // Add some data if the DB does not exist
                // (If you run the code below and the primary keys of these books are already declared in the DB it will throw an error)
                Console.WriteLine($"DB do not exist = {dbNotExisting}");
                //dbNotExisting=true;
                if (dbNotExisting)
                {
                    DateTime ara = DateTime.Now;
                    // Adds some data
                    context.Client.Add(new Client
                    {   
                        // Unit
                        Id = "C1",
                        Name = "Justin",
                        PhoneNumber = "123456789",
                        Email = "justin@justin.com",
                        Registered = ara,
                        LastUpdated = ara,
                        // Person
                        Surnames = "Time Yesterday",
                        Gender = true,
                        Year = 1800,
                        // Client
                        SendNotifications = true,
                        Address = new Address{
                            Id = "A1",
                            Street = "Timeline",
                            Number = 999,
                            City = "Nowhere",
                            PostalCode = 1,
                            Country = "Everywhere"
                        }
                    });
                    
                    

                    // Saves changes
                    context.SaveChanges();
                }
            }
        }
    }
}