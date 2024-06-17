using BookKeeper.Application.Abstractions.Messaging;

namespace BookKeeper.Application.Books.CreateBook;

public sealed record CreateBookCommand(
    string Title, 
    string Description, 
    string Authors, 
    decimal Price) : ICommand<Guid>;
