using BookKeeper.Domain.Entities;

namespace BookKeeper.Application.Abstractions.Data;

public interface IUserRepository
{
    void Insert(User user);
}
