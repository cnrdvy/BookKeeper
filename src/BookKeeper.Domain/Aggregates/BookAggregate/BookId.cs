using BookKeeper.Domain.Primitives;

namespace BookKeeper.Domain.Aggregates.BookAggregate;

public readonly record struct BookId
{
    public NonEmptyGuid Value { get; }

    private BookId(Guid value)
    {
        if (value == Guid.Empty)
        {
            throw new ArgumentException(
                "BookId must be a valid GUID.",
                nameof(value));
        }

        Value = value;
    }

    public static implicit operator BookId(Guid value) => new(value);

    public static implicit operator Guid(BookId bookId) => bookId.Value;

    public override string ToString() => Value.ToString();
}
