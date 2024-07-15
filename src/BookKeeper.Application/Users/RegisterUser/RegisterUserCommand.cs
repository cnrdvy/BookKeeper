using BookKeeper.Application.Abstractions.Messaging;

namespace BookKeeper.Application.Users.RegisterUser;

public sealed record RegisterUserCommand(
    string FirstName, 
    string LastName, 
    string Email) : ICommand<Guid>;
