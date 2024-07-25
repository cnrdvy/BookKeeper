namespace BookKeeper.Application.Books.GetBooks;

public sealed record BookResponse
{
    public BookResponse(
        Guid Id,
        string Title,
        string Description,
        IEnumerable<Guid> Authors,
        decimal Price)
    {
        this.Id = Id;
        this.Title = Title;
        this.Description = Description;
        this.Authors = Authors;
        this.Price = Price;
    }

    public BookResponse() { }

    public Guid Id { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public IEnumerable<Guid> Authors { get; set; }

    public decimal Price { get; set; }
}
