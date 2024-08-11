using BookKeeper.Domain.Primitives;

namespace BookKeeper.Domain.Aggregates.BookAggregate;

public readonly record struct BookTitle
{
    private NonEmptyString Title { get; }

    private BookTitle(string title) => Title = (NonEmptyString)title;

    public static implicit operator BookTitle(string title) => new(title);

    public override string ToString() => Title.ToString();
}
