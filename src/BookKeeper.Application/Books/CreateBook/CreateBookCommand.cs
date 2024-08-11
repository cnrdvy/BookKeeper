using BookKeeper.Application.Abstractions.Messaging;
using BookKeeper.Domain.Aggregates.AuthorAggregate;

namespace BookKeeper.Application.Books.CreateBook;

public sealed record CreateBookCommand(
    string Title, 
    string Description, 
    IEnumerable<Author> Authors, 
    decimal Price) : ICommand<Guid>;
