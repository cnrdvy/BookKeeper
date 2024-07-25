namespace BookKeeper.Domain.ValueObjects;

public readonly record struct NonEmptyString
{
    public NonEmptyString(string value) => Value = !string.IsNullOrEmpty(value)
        ? value.Trim()
        : throw new ArgumentException("Value cannot be null or white space.", nameof(value));

    public NonEmptyString() : this(string.Empty) { }
    
    public string Value { get; init; }
    
    public static implicit operator string(NonEmptyString value) => value.Value;

    public override string ToString() => Value;
}
