using System.Data.Common;
using BookKeeper.Application.Abstractions.Data;
using BookKeeper.Application.Abstractions.Messaging;
using BookKeeper.Domain;
using Dapper;

namespace BookKeeper.Application.Books.GetBooks;

internal sealed class GetBooksQueryHandler(IDbConnectionFactory dbConnectionFactory)
    : IQueryHandler<GetBooksQuery, IReadOnlyCollection<BookResponse>>
{
    public async Task<Result<IReadOnlyCollection<BookResponse>>> Handle(
        GetBooksQuery request, 
        CancellationToken cancellationToken)
    {
        await using DbConnection connection = await dbConnectionFactory.OpenConnectionAsync();

        const string SQL =
            """
                
            """;

        return (await connection.QueryAsync<BookResponse>(SQL, request)).AsList();
    }
}
