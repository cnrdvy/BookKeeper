using BookKeeper.Application.Abstractions.Data;
using BookKeeper.Domain.Entities;
using BookKeeper.Infrastructure.Database;

namespace BookKeeper.Infrastructure.Data;

internal sealed class UserRepository(BookKeeperDbContext context) : IUserRepository
{
    public void Insert(User user) => context.Users.Add(user);
}
