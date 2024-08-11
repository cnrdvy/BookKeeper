using BookKeeper.Domain.Primitives;

namespace BookKeeper.Domain.Aggregates.BookAggregate;

public readonly record struct BookDescription
{
    private NonEmptyString Description { get; }

    private BookDescription(string description) =>
        Description = (NonEmptyString)description;

    public static implicit operator BookDescription(string description) => new(description);

    public override string ToString() => Description.ToString();
}
