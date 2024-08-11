using BookKeeper.Domain.Aggregates.UserAggregate;

namespace BookKeeper.Application.Abstractions.Data;

public interface IUserRepository
{
    void Insert(User user);
}
