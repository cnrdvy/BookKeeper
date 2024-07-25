using BookKeeper.Domain.Entities;

namespace BookKeeper.Application.Abstractions.Data;

public interface IBookRepository
{
    void Insert(Book book);
}
