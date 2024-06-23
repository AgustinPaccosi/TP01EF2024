using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using TP01EF2024.Entidades;
namespace TP01EF2024.Datos
{
    public class TPDbContext : DbContext
    {
        public TPDbContext()
        {

        }
        public TPDbContext(DbContextOptions<TPDbContext> options) : base(options)
        {

        }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Colour> Colours { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Sport> Sports { get; set; }
        public DbSet<Shoe> Shoes { get; set; }
        public DbSet<ShoeColour> ShoesColours { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.; 
                                      Initial Catalog=TP01EF2024; 
                                      Trusted_Connection=true; 
                                      TrustServerCertificate=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var brands = new List<Brand>()
            {
                new Brand
                {
                    BrandId=1,
                    BrandName="Puma"
                },
                new Brand
                {
                    BrandId=2,
                    BrandName="Boris"
                },
                new Brand
                {
                    BrandId =3,
                    BrandName="Nike"
                },
            };
            var colours = new List<Colour>()
            {
                new Colour
                {
                    ColourId=1,
                    ColourName="Negro"
                },
                new Colour
                {
                    ColourId=2,
                    ColourName="Marron"
                },
                new Colour
                {
                    ColourId=3,
                    ColourName="Blanco"
                },
            };
            var genres = new List<Genre>()
            {
                new Genre
                {
                    GenreId=1,
                    GenreName="Masculino"
                },
                new Genre
                {
                    GenreId=2,
                    GenreName="Femenino"
                },
                new Genre
                {
                    GenreId=3,
                    GenreName="Sin Genero"
                },
            };
            var sports = new List<Sport>()
            {
                new Sport
                {
                    SportId = 1,
                    SportName = "Futbol"
                },
                new Sport
                {
                    SportId = 2,
                    SportName = "Atletismo"
                },
                new Sport
                {
                    SportId = 3,
                    SportName = "Tenis"
                },
            };
            modelBuilder.Entity<Brand>(entity =>
            {
                entity.HasKey(b => b.BrandId);
                entity.HasIndex(b => b.BrandName).IsUnique();
                entity.Property(b => b.BrandName).IsRequired().HasMaxLength(50);
                entity.HasData(brands);
            });
            modelBuilder.Entity<Colour>(entity =>
            {
                entity.HasKey(c=>c.ColourId);
                entity.HasIndex(c => c.ColourName).IsUnique();
                entity.Property(c=>c.ColourName).IsRequired().HasMaxLength(50);
                entity.HasData(colours);
            });
            modelBuilder.Entity<Genre>(entity =>
            {
                entity.HasKey(g => g.GenreId);
                entity.HasIndex(g => g.GenreName).IsUnique();
                entity.Property(g => g.GenreName).IsRequired().HasMaxLength(50);
                entity.HasData(genres);
            });
            modelBuilder.Entity<Sport>(entity =>
            {
                entity.HasKey(s => s.SportId);
                entity.HasIndex(s => s.SportName).IsUnique();
                entity.Property(s => s.SportName).IsRequired().HasMaxLength(20);
                entity.HasData(sports);
            });
            modelBuilder.Entity<Shoe>(entity =>
            {
                entity.HasKey(e => e.ShoeId);
                entity.HasOne(s => s.Brand).WithMany(b => b.Shoes).HasForeignKey(s => s.BrandId);
                entity.HasOne(s => s.Genre).WithMany(g => g.Shoes).HasForeignKey(s => s.GenreId);
                entity.HasOne(s => s.Sport).WithMany(s => s.Shoes).HasForeignKey(s => s.SportId);
                entity.Property(e => e.Model).IsRequired().HasMaxLength(150);
                entity.Property(e => e.Price).HasPrecision(10, 2);
                entity.Property(e => e.Description).IsRequired();
                //entity.HasData(shoe);
            });

            modelBuilder.Entity<ShoeColour>(entity =>
            {
                entity.HasKey(sc => new { sc.ShoeId, sc.ColourId });
                entity.HasOne(sc => sc.Shoe).WithMany(s => s.ShoesColours).HasForeignKey(sc => sc.ShoeId);
                entity.HasOne(sc => sc.Colour).WithMany(c => c.ShoesColours).HasForeignKey(sc => sc.ColourId);
            });
        }


    }
}
