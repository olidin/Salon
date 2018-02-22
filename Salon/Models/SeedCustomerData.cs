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
                        FirstName = "Siblla",
                        LastName = "Leia",
                        Address_1 = "123 Street",
                        Address_2 = "Suite A",
                        City = "Houston",
                        State = "TX",
                        ZipCode = 77832,
                        Neighborhood = "Height"
                    },

                    new Customer
                    {
                        FirstName = "Mariamna",
                        LastName = "Yoko",
                        Address_1 = "1563 Street",
                        Address_2 = "App 12",
                        City = "Austin",
                        State = "TX",
                        ZipCode = 76872,
                        Neighborhood = "Windsor"
                    },

                    new Customer
                    {
                        FirstName = "Joel",
                        LastName = "Engel",
                        Address_1 = "1339 Burwell Heights Road",
                        Address_2 = "",
                        City = "Nederland",
                        State = "TX",
                        ZipCode = 77627,
                        Neighborhood = "River Creek"
                    },

                    new Customer
                    {
                        FirstName = "Gregers",
                        LastName = "Giordano",
                        Address_1 = "3849 Austin Secret Lane",
                        Address_2 = "App 12",
                        City = "Beaver",
                        State = "UT",
                        ZipCode = 84713,
                        Neighborhood = "China Town"
                    },

                    new Customer
                    {
                        FirstName = "Mo",
                        LastName = "Donivan",
                        Address_1 = "712 Sampson Street",
                        Address_2 = "Building 2",
                        City = "Denver",
                        State = "CO",
                        ZipCode = 80202,
                        Neighborhood = "Cedar"
                    },

                    new Customer
                    {
                        FirstName = "Imela",
                        LastName = "Jenifer",
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
