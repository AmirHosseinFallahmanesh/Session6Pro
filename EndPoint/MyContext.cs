using Microsoft.EntityFrameworkCore;

namespace EndPoint
{
    public class MyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=demo06;User Id=sa;Password=713;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Employee>().HasOne(a => a.Comapny)
                .WithMany(c => c.Employees).HasForeignKey(a=>a.ComapnyId)
            .OnDelete(DeleteBehavior.ClientSetNull);


            modelBuilder.Entity<Order>().OwnsOne(typeof(Address), "Address");

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}