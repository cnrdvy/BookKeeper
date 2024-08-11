using BookKeeper.Application.Abstractions.Data;
using BookKeeper.Domain.Aggregates.AuthorAggregate;
using BookKeeper.Domain.Aggregates.BookAggregate;
using BookKeeper.Domain.Aggregates.UserAggregate;
using BookKeeper.Infrastructure.Database.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace BookKeeper.Infrastructure.Database;

public sealed class BookKeeperDbContext(DbContextOptions<BookKeeperDbContext> options)
    : DbContext(options), IUnitOfWork
{
    internal DbSet<Book> Books { get; set; }

    internal DbSet<User> Users { get; set; }

    internal DbSet<Author> Authors { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema(Schemas.BookKeeper);

        modelBuilder.ApplyConfiguration(new BookConfiguration());
        modelBuilder.ApplyConfiguration(new AuthorConfiguration());
    }
}
