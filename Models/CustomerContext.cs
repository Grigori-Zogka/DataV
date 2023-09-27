using Microsoft.EntityFrameworkCore;

namespace DataV.Models
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions options) : base(options)
        {


        }

        public virtual DbSet<Customer> Customers { get; set; }

    }
}
