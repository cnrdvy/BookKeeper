using BookKeeper.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookKeeper.Infrastructure.Database.EntityConfigurations;

internal sealed class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.HasKey(b => b.Id);

        builder.Property(b => b.Description).HasMaxLength(500).IsRequired();

        builder.Property(b => b.Price).IsRequired();

        builder.HasMany(b => b.Authors).WithMany(a => a.Books);

        builder
            .ComplexProperty(b => b.Title)
            .ComplexProperty(
                b => b.Value,
                x => x
                    .Property(y => y.Value)
                    .HasColumnName(nameof(Book.Title))
                    .HasMaxLength(200)
                    .IsRequired());
    }
}
