using BookKeeper.Application.Abstractions.Data;
using BookKeeper.Domain;
using BookKeeper.Infrastructure.Database;

namespace BookKeeper.Infrastructure.Data;

internal sealed class UserRepository(BookKeeperDbContext context) : IUserRepository
{
    public void Insert(User user) => context.Users.Add(user);
}
