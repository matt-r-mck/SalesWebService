using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebService.Models;

namespace SalesWebService.Data
{
    public class SalesDbContext : DbContext
    {
        public SalesDbContext (DbContextOptions<SalesDbContext> options)
            : base(options)
        {
        }

        public DbSet<SalesWebService.Models.Customer> Customer { get; set; }

        public DbSet<SalesWebService.Models.Product> Product { get; set; }

        public DbSet<SalesWebService.Models.Order> Order { get; set; }

        public DbSet<SalesWebService.Models.OrderLine> OrderLine { get; set; }
    }
}
