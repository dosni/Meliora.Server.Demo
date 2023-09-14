using FUIServerSample.Layer.DataLayer;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Context
{
    public partial class DemoContext : DbContext
    {
        public DemoContext(DbContextOptions<DemoContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Customer>().HasData(
                    new Customer { Id = 1, FirstName = "Maria",LastName = "Anders",City = "Berlin", Country="Germany", Phone= "030-0074321" },
                    new Customer { Id = 2, FirstName = "Ana", LastName = "Trujillo", City = "México D.F.", Country = "México", Phone = "(5) 555-4729" },
                    new Customer { Id = 3, FirstName = "Antonio", LastName = "Moreno", City = "México D.F.", Country = "México", Phone = "(5) 555-3932" }


                );
        }
        public virtual DbSet<Customer> Customers{ get; set; } = null!;
    }
}

