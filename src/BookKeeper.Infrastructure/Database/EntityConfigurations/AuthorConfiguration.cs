using BookKeeper.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookKeeper.Infrastructure.Database.EntityConfigurations;

internal sealed class AuthorConfiguration : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder.HasKey(a => a.Id);

        builder.Property(b => b.FirstName).HasMaxLength(50).IsRequired();

        builder.Property(b => b.LastName).HasMaxLength(50).IsRequired();

        builder.HasMany(b => b.Books).WithMany(a => a.Authors);
    }
}
