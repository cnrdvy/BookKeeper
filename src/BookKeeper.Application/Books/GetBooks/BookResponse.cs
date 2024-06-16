namespace BookKeeper.Application.Books.GetBooks;

public sealed record BookResponse(
    Guid Id,
    string Title,
    string Description,
    string Authors,
    decimal Price);
