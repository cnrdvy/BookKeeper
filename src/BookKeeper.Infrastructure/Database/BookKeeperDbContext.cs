using BookKeeper.Domain;
using Microsoft.EntityFrameworkCore;

namespace BookKeeper.Infrastructure.Database;

public sealed class BookKeeperDbContext(DbContextOptions<BookKeeperDbContext> options)
    : DbContext(options)
{
    internal DbSet<Book> Books { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema(Schemas.BookKeeper);
    }
}
