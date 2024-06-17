using BookKeeper.Application.Abstractions.Data;
using BookKeeper.Infrastructure.Data;
using BookKeeper.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Npgsql;

namespace BookKeeper.Infrastructure;

public static class InfrastructureModule
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        string dbConnectionString = configuration.GetConnectionString("Database")!;
        
        NpgsqlDataSource npgsqlDataSource = new NpgsqlDataSourceBuilder(dbConnectionString).Build();
        services.TryAddSingleton(npgsqlDataSource);

        services.AddScoped<IUnitOfWork>(sp => sp.GetRequiredService<BookKeeperDbContext>());

        services.AddScoped<IDbConnectionFactory, DbConnectionFactory>();
        services.AddScoped<IBookRepository, BookRepository>();

        services.AddDbContext<BookKeeperDbContext>((sp, options) =>
            options
                .UseNpgsql(
                    dbConnectionString,
                    npgsqlOptions => npgsqlOptions
                        .MigrationsHistoryTable(
                            HistoryRepository.DefaultTableName,
                            Schemas.BookKeeper)));

        return services;
    }
}
