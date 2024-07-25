using BookKeeper.Domain.ValueObjects;

namespace BookKeeper.Domain.Entities;

public sealed class Book
{
    public Guid Id { get; private set; }

    public BookTitle Title { get; private set; }

    public string Description { get; private set; }

    public IEnumerable<Author> Authors { get; private set; }

    public decimal Price { get; private set; }

    public static Book Create(
        BookTitle title, 
        string description, 
        IEnumerable<Author> authors, 
        decimal price) =>
        new()
        {
            Id = Guid.NewGuid(),
            Title = title,
            Description = description,
            Authors = authors,
            Price = price
        };
}
