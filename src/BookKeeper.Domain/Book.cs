namespace BookKeeper.Domain;

public sealed class Book
{
    public Guid Id { get; private set; }

    public string Title { get; private set; } = string.Empty;

    public string Description { get; private set; } = string.Empty;

    public string Authors { get; private set; } = string.Empty;

    public decimal Price { get; private set; }

    public static Book Create(string title, string description, string authors, decimal price) =>
        new()
        {
            Id = Guid.NewGuid(),
            Title = title,
            Description = description,
            Authors = authors,
            Price = price
        };
}
