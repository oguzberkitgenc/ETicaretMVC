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
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Adress> Adress { get; set; }
        public DbSet<HomePage> HomePagess { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }

    }
}