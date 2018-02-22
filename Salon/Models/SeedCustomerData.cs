using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace Salon.Models
{
    public static class SeedCustomerData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SalonContext(
                serviceProvider.GetRequiredService<DbContextOptions<SalonContext>>()))
            {
                // Look for any Customers
                if (context.Customer.Any())
                {
                    return; // DB has data
                }

                context.Customer.AddRange(
                    new Customer
                    {
                        FirstName = "John",
                        LastName = "Doe",
                        Address_1 = "123 Street",
                        Address_2 = "Suite A",
                        City = "Houston",
                        State = "TX",
                        ZipCode = 77832,
                        Neighborhood = "Height"
                    },

                    new Customer
                    {
                        FirstName = "Jane",
                        LastName = "Doe",
                        Address_1 = "1563 Street",
                        Address_2 = "App 12",
                        City = "Austin",
                        State = "TX",
                        ZipCode = 76872,
                        Neighborhood = "Cedar"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
