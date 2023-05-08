using EntityLayer.Tables;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Context
{
    public class ETicaretContext  :  DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\OBG;database=EticaretMvc;integrated security=true");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        //public DbSet<Company> Companies { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>().HasNoKey();
        }
        public DbSet<Admin> Admin { get; set; }
    }
}