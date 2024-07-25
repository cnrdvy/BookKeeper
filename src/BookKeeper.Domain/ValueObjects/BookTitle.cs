namespace BookKeeper.Domain.ValueObjects;

public readonly record struct BookTitle
{
    public BookTitle(string Value) => this.Value = new NonEmptyString(Value);

    public BookTitle() : this(string.Empty) { }

    public NonEmptyString Value { get; init; }

    public override string ToString() => Value.ToString();
};
