using Library.Application.EF.Configurations;
using Library.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Library.Application.EF
{
    public class LibraryContext : DbContext
    {
        //public DbSet<Reader> Readers { get; set; } = default!;

        public DbSet<PublishingHouse> PublishingHouses { get; set; } = default!;

        public DbSet<Book> Books { get; set; } = default!;

        public DbSet<Author> Authors { get; set; } = default!;

        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new PublishingHouseConfiguration());
            modelBuilder.ApplyConfiguration(new AuthorConfiguration());
            modelBuilder.ApplyConfiguration(new BookConfiguration());
            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
