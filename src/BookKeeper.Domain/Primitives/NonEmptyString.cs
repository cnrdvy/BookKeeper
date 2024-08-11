namespace BookKeeper.Domain.Primitives;

public readonly record struct NonEmptyString
{
    public NonEmptyString(string value) => Value = !string.IsNullOrEmpty(value)
        ? value.Trim()
        : throw new ArgumentException(
            "Value cannot be null or white space.",
            nameof(value));

    public string Value { get; init; }

    public static implicit operator NonEmptyString(string value) => new(value);

    public override string ToString() => Value;
}
