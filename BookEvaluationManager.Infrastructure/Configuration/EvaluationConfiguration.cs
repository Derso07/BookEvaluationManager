using BookEvaluationManager.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookEvaluationManager.Infrastructure.Configuration
{
    public class EvaluationConfiguration : IEntityTypeConfiguration<Evaluation>
    {
        public void Configure(EntityTypeBuilder<Evaluation> builder)
        {
            builder.ToTable("Evaluation");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Score)
                .IsRequired()
                .HasMaxLength(5);

            builder.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(500);

            builder.HasOne(e => e.Book)
                .WithMany(b => b.Evaluations)
                .HasForeignKey(e => e.BookId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.User)
                .WithMany(u => u.Evaluations)
                .HasForeignKey(e => e.UserId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
