namespace BookEvaluationManager.Core.Entities
{
    public class Evaluation : BaseEntity
    {
        public int Score { get; set; }
        public string Description { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }
        public Book Book { get; set; }
        public User User { get; set; }

    }
}
