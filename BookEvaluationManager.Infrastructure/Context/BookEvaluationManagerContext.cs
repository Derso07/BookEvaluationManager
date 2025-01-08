using BookEvaluationManager.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookEvaluationManager.Infrastructure.Context
{
    public class BookEvaluationManagerContext : DbContext
    {
        public BookEvaluationManagerContext(DbContextOptions<BookEvaluationManagerContext> options)
            :base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Evaluation> Evaluations { get; set; }
    }
}
