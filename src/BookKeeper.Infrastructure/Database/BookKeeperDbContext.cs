using BookKeeper.Application.Abstractions.Data;
using BookKeeper.Domain;
using Microsoft.EntityFrameworkCore;

namespace BookKeeper.Infrastructure.Database;

public sealed class BookKeeperDbContext(DbContextOptions<BookKeeperDbContext> options)
    : DbContext(options), IUnitOfWork
{
    internal DbSet<Book> Books { get; set; }

    internal DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema(Schemas.BookKeeper);
    }
}
