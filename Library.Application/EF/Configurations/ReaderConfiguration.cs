using Library.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Application.EF.Configurations
{
    internal class ReaderConfiguration : IEntityTypeConfiguration<Reader>
    {
        public void Configure(EntityTypeBuilder<Reader> builder)
        {
            builder.HasKey(r => r.Id);

            builder.Property(r => r.FirstName)
                .IsRequired();

            builder.HasMany(r => r.BorrowedBooks)
                .WithOne(bb => bb.Reader)
                .HasForeignKey(bb => bb.ReaderId);
        }
    }
}
