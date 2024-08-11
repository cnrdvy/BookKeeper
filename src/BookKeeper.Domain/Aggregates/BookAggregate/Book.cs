using BookKeeper.Domain.Aggregates.AuthorAggregate;

namespace BookKeeper.Domain.Aggregates.BookAggregate;

public sealed class Book
{
    public BookId Id { get; private set; }

    public BookTitle Title { get; private set; }

    public BookDescription Description { get; private set; }

    public BookPrice Price { get; private set; }

    public IEnumerable<Author> Authors { get; private set; }

    public static Book Create(
        BookTitle title,
        BookDescription description,
        IEnumerable<Author> authors,
        BookPrice price) =>
        new()
        {
            Id = Guid.NewGuid(),
            Title = title,
            Description = description,
            Authors = authors,
            Price = price
        };
}
