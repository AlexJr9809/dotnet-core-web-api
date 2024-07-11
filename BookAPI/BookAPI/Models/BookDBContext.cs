using Microsoft.EntityFrameworkCore;

namespace BookAPI.Models
{
    public class BookDBContext : DbContext
    {
        public BookDBContext(DbContextOptions<BookDBContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>()
                .HasMany(c => c.Books)
                .WithOne(a => a.gnr)
                .HasForeignKey(a => a.GenreId);
            
            modelBuilder.Entity<Author>()
                .HasMany(c => c.Books)
                .WithOne(a => a.auth)
                .HasForeignKey(a => a.AuthorId);

            modelBuilder.Feeder();
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
