using BookKeeper.Application.Abstractions.Data;
using BookKeeper.Application.Abstractions.Messaging;
using BookKeeper.Domain;
using BookKeeper.Domain.Entities;

namespace BookKeeper.Application.Books.CreateBook;

internal sealed class CreateBookCommandHandler(
    IBookRepository bookRepository,
    IUnitOfWork unitOfWork) : ICommandHandler<CreateBookCommand, Guid>
{
    public async Task<Result<Guid>> Handle(
        CreateBookCommand request, 
        CancellationToken cancellationToken)
    {
        var book = Book.Create(
            new(request.Title), 
            request.Description, 
            request.Authors, 
            request.Price);

        bookRepository.Insert(book);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return book.Id;
    }
}
