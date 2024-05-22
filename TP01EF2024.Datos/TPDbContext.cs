using Microsoft.EntityFrameworkCore;
using TP01EF2024.Entidades;
namespace TP01EF2024.Datos
{
    public class TPDbContext : DbContext
    {
        public TPDbContext()
        {

        }
        public DbSet<Brand> Brands { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.; 
                                      Initial Catalog=ViveroEF2024; 
                                      Trusted_Connection=true; 
                                      TrustServerCertificate=true;");
        }



    }
}
