namespace BookKeeper.Domain.Primitives;

public readonly record struct NonEmptyGuid
{
    private Guid Value { get; }

    private NonEmptyGuid(Guid value)
    {
        if (value == Guid.Empty)
        {
            throw new ArgumentException(
                "BookId must be a valid GUID.",
                nameof(value));
        }

        Value = value;
    }

    public static implicit operator NonEmptyGuid(Guid value) => new(value);

    public static implicit operator Guid(NonEmptyGuid newGuid) => newGuid.Value;

    public override string ToString() => Value.ToString();
}
