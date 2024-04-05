using IFix.Models;
using Microsoft.EntityFrameworkCore;

namespace IFix.Data
{
    public class ApplicationDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlServer("Data Source=.\\SQLEXPRESS;Database=IFIxDatabase;Integrated Security=True;Encrypt=False");

        public DbSet<Admin> Admins { get; set; }

        public DbSet<Car> Cars { get; set; }   
        
        public DbSet<Complaint> Complaints { get; set; }
        
        public DbSet<Person> Persons { get; set; }
        
        public DbSet<Request> Requests { get; set; }
        
        public DbSet<Review> Reviews { get; set; } 
        
        public DbSet<ServiceAlert> ServiceAlerts { get; set; }
        
        public DbSet<ServiceProviders> ServicesProviders { get; set; }
        
        public DbSet<Transaction> Transactions { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Complaint>()
                .HasOne(c => c.Request)
                .WithOne(r => r.Complaint)
                .HasForeignKey<Request>(r => r.ComplaintId);
        }


    }
}
