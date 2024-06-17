using BookKeeper.Application.Abstractions.Data;
using BookKeeper.Domain;
using BookKeeper.Infrastructure.Database;

namespace BookKeeper.Infrastructure.Data;

internal sealed class BookRepository(BookKeeperDbContext dbContext) : IBookRepository
{
    public void Insert(Book book) => dbContext.Books.Add(book);
}
