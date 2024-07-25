using BookKeeper.Application.Abstractions.Data;
using BookKeeper.Application.Abstractions.Messaging;
using BookKeeper.Domain;
using BookKeeper.Domain.Entities;

namespace BookKeeper.Application.Users.RegisterUser;

internal sealed class RegisterUserCommandHandler(
    IUserRepository userRepository, 
    IUnitOfWork unitOfWork) : ICommandHandler<RegisterUserCommand, Guid>
{
    public async Task<Result<Guid>> Handle(
        RegisterUserCommand request, 
        CancellationToken cancellationToken)
    {
        var user = User.Create(request.FirstName, request.LastName, request.Email);

        userRepository.Insert(user);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return user.Id;
    }
}
