using Microsoft.EntityFrameworkCore;

namespace MVCCodeFirst.Models
{
    public class DemoContext : DbContext
        {


            public DemoContext(DbContextOptions<DemoContext>options)
            :base(options)
            { }
            public DbSet<Product> Products { get; set; }
            public DbSet<Detail> Details { get; set; }
            public DbSet<Invoice> Invoices { get; set; }
            public DbSet<Customer> Customers { get; set; }
        }
}
