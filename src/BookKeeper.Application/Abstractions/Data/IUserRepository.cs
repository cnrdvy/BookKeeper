using BookKeeper.Domain;

namespace BookKeeper.Application.Abstractions.Data;

public interface IUserRepository
{
    void Insert(User user);
}
