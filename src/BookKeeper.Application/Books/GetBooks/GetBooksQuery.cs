using BookKeeper.Application.Abstractions.Messaging;

namespace BookKeeper.Application.Books.GetBooks;

public sealed record GetBooksQuery : IQuery<IReadOnlyCollection<BookResponse>>;
