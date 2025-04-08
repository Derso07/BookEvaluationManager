using BookEvaluationManager.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookEvaluationManager.Infrastructure.Configuration
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Book");

            builder.HasKey(b => b.Id);

            builder.Property(b => b.Tittle)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(b => b.Description)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(b => b.ISNB)
                .IsRequired()
                .HasMaxLength(13);

            builder.Property(b => b.Author)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(b => b.Publisher)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(b => b.BookGenre)
                .IsRequired()
                .HasConversion<int>();

            builder.Property(b => b.YearOfPublication)
                .IsRequired();

            builder.Property(b => b.NumberOfPages)
                .IsRequired();

            builder.Property(b => b.AverageGrade)
                .IsRequired()
                .HasColumnType("decimal(3, 2)");

            builder.Property(b => b.BookCover)
                .IsRequired();

            builder.HasMany(b => b.Evaluations)
                .WithOne(e => e.Book)
                .HasForeignKey(e => e.BookId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
