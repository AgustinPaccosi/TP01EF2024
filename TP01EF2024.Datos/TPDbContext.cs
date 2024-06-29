using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System.Windows.Markup;
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
        public DbSet<ShoeSize> ShoesSizes { get; set; }
        public DbSet<Size> Sizes { get; set; }

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
                    BrandName="Puma",
                    Active = true
                },
                new Brand
                {
                    BrandId=2,
                    BrandName="Boris",
                    Active = true
                },
                new Brand
                {
                    BrandId =3,
                    BrandName="Nike",
                    Active = true
                },
            };
            var colours = new List<Colour>()
            {
                new Colour
                {
                    ColourId=1,
                    ColourName="Negro",
                    Active = true
                },
                new Colour
                {
                    ColourId=2,
                    ColourName="Marron",
                    Active = true
                },
                new Colour
                {
                    ColourId=3,
                    ColourName="Blanco",
                    Active = true
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
                    SportName = "Futbol",
                    Active = true
                },
                new Sport
                {
                    SportId = 2,
                    SportName = "Atletismo",
                    Active = true
                },
                new Sport
                {
                    SportId = 3,
                    SportName = "Tenis",
                    Active = true
                },
            };
            var shoes = new List<Shoe>()
            {
                new Shoe
                {
                    ShoeId = 1,
                    BrandId = 1,
                    SportId = 3,
                    GenreId = 2,
                    ColourId=1,
                    Model = "Deportivas",
                    Description = "Vans Deportivas",
                    Price = 15,
                    Active = true
                },
                new Shoe
                {
                    ShoeId = 2,
                    BrandId = 2,
                    SportId = 1,
                    GenreId = 1,
                    ColourId=1,
                    Model = "Botines",
                    Description = "Botines Femeninos",
                    Price = 20,
                    Active = true
                },
                new Shoe
                {
                    ShoeId = 3,
                    BrandId = 3,
                    SportId = 2,
                    GenreId = 3,
                    ColourId=1,
                    Model = "1982",
                    Description = "Importados",
                    Price = 35,
                    Active = true

                },

            };
            var sizes = new List<Size>();
            
            int sizeId = 1;

            for (decimal i = 28; i <= 50; i += 0.5m)
            {
                sizes.Add(new Size
                {
                    SizeId = sizeId++,
                    SizeNumber = i
                });
            }
        
            modelBuilder.Entity<Brand>(entity =>
            {
                entity.HasKey(b => b.BrandId);
                entity.HasIndex(b => b.BrandName).IsUnique();
                entity.Property(b => b.BrandName).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Active).IsRequired().HasDefaultValue(true);
                entity.HasData(brands);
            });
            modelBuilder.Entity<Colour>(entity =>
            {
                entity.HasKey(c=>c.ColourId);
                entity.HasIndex(c => c.ColourName).IsUnique();
                entity.Property(c=>c.ColourName).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Active).IsRequired().HasDefaultValue(true);
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
                entity.Property(e => e.Active).IsRequired().HasDefaultValue(true);
                entity.HasData(sports);
            });
            modelBuilder.Entity<Shoe>(entity =>
            {
                entity.HasKey(e => e.ShoeId);
                entity.HasOne(s => s.Brand).WithMany(b => b.Shoes).HasForeignKey(s => s.BrandId);
                entity.HasOne(s => s.Genre).WithMany(g => g.Shoes).HasForeignKey(s => s.GenreId);
                entity.HasOne(s => s.Sport).WithMany(s => s.Shoes).HasForeignKey(s => s.SportId);
                entity.HasOne(s => s.Colour).WithMany(c => c.Shoes).HasForeignKey(s => s.ColourId);
                entity.Property(e => e.Active).IsRequired().HasDefaultValue(true);
                entity.Property(e => e.Model).IsRequired().HasMaxLength(150);
                entity.Property(e => e.Price).HasPrecision(10, 2);
                entity.Property(e => e.Description).IsRequired();
                entity.HasData(shoes);
            });
            modelBuilder.Entity<Size>(entity =>
            {
                entity.HasKey(s => s.SizeId);
                entity.HasIndex(s => s.SizeNumber).IsUnique();
                entity.Property(s => s.SizeNumber).HasColumnType("decimal (3, 1)").HasPrecision(3, 1).IsRequired();
                entity.HasData(sizes);
                entity.ToTable("Sizes");
            });
            modelBuilder.Entity<ShoeSize>(entity =>
            {
                entity.HasKey(ss => ss.ShoeSizeId);
                entity.HasIndex(ss => new { ss.ShoeId, ss.SizeId }).IsUnique();
                entity.HasOne(ss => ss.Shoe).WithMany(s => s.ShoesSizes).HasForeignKey(sc => sc.ShoeId);
                entity.HasOne(ss => ss.Size).WithMany(s => s.ShoesSizes).HasForeignKey(sc => sc.SizeId);
                entity.Property(ss => ss.QuantityInStock).IsRequired();
                entity.ToTable("ShoesSizes");

            });
        }
    }
}
