using BookKeeper.Domain.Aggregates.BookAggregate;

namespace BookKeeper.Application.Abstractions.Data;

public interface IBookRepository
{
    void Insert(Book book);
}
