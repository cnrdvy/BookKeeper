using BookKeeper.Domain.ValueObjects;

namespace BookKeeper.Domain.Entities;

public sealed class User
{
    public Guid Id { get; private set; }

    public string FirstName { get; private set; }

    public string LastName { get; private set; }

    public string Email { get; private set; }

    public static User Create(string firstName, string lastName, string email) => new()
    {
        Id = Guid.NewGuid(),
        FirstName = firstName,
        LastName = lastName,
        Email = email
    };
}
