namespace BookEvaluationManager.Core.Entities
{
    public class User : BaseEntity
    {
        public string Email { get; set; }
        public string Nome { get; set; }
        public virtual List<Evaluation> Evaluations { get; set; }
    }
}
