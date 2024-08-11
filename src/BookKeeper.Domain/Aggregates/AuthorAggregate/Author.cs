using BookKeeper.Domain.Aggregates.BookAggregate;

namespace BookKeeper.Domain.Aggregates.AuthorAggregate;

public sealed class Author
{
    public Guid Id { get; private set; }

    public string FirstName { get; private set; }

    public string LastName { get; private set; }

    public IEnumerable<Book> Books { get; private set; }

    public static Author Create(string firstName, string lastName) => new()
    {
        Id = Guid.NewGuid(),
        FirstName = firstName,
        LastName = lastName
    };
}
