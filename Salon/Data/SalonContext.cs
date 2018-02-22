using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Salon.Models
{
    public class SalonContext : DbContext
    {
        public SalonContext (DbContextOptions<SalonContext> options)
            : base(options)
        {
        }

        public DbSet<Salon.Models.Customer> Customer { get; set; }
    }
}
