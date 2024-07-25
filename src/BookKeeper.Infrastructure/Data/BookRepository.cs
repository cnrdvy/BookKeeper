using BookKeeper.Application.Abstractions.Data;
using BookKeeper.Domain.Entities;
using BookKeeper.Infrastructure.Database;

namespace BookKeeper.Infrastructure.Data;

internal sealed class BookRepository(BookKeeperDbContext context) : IBookRepository
{
    public void Insert(Book book) => context.Books.Add(book);
}
