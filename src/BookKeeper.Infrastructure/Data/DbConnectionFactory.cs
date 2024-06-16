using System.Data.Common;
using BookKeeper.Application.Abstractions.Data;
using Npgsql;

namespace BookKeeper.Infrastructure.Data;

internal sealed class DbConnectionFactory(NpgsqlDataSource dataSource) : IDbConnectionFactory
{
    public async ValueTask<DbConnection> OpenConnectionAsync() =>
        await dataSource.OpenConnectionAsync();
}
