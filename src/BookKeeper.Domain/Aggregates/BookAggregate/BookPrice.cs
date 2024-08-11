namespace BookKeeper.Domain.Aggregates.BookAggregate;

public readonly record struct BookPrice
{
    private decimal Value { get; }

    private BookPrice(decimal value)
    {
        if (decimal.Zero == value)
        {
            throw new ArgumentException("Value must be a positive number.", nameof(value));
        }

        Value = value;
    }

    public static implicit operator BookPrice(decimal value) => new(value);

    public static implicit operator decimal(BookPrice price) => price.Value;
}
