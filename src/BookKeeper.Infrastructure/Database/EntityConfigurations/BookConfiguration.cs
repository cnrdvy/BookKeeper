using BookKeeper.Domain.Aggregates.BookAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookKeeper.Infrastructure.Database.EntityConfigurations;

internal sealed class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.HasKey(b => b.Id);

        builder
            .Property(b => b.Id)
            .HasConversion(new ValueConverter<BookId, Guid>(
                v => v,
                v => (BookId)v
            ));

        builder
            .Property(b => b.Title)
            .HasConversion(new ValueConverter<BookTitle, string>(
                v => v.ToString(),
                v => (BookTitle)v
            ));

        builder
            .Property(b => b.Description)
            .HasConversion(new ValueConverter<BookDescription, string>(
                v => v.ToString(),
                v => (BookDescription)v
            ));

        builder
            .Property(b => b.Price)
            .HasConversion(new ValueConverter<BookPrice, decimal>(
                v => v,
                v => (BookPrice)v
            ));
    }
}
