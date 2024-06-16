using BookKeeper.Domain;
using MediatR;

namespace BookKeeper.Application.Abstractions.Messaging;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>;
