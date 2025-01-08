using BookEvaluationManager.Core.Enum;

namespace BookEvaluationManager.Core.Entities
{
    public class Book : BaseEntity
    {
        public string Tittle { get; set; }
        public string Description { get; set; }
        public string ISNB { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public BookGenre BookGenre { get; set; }
        public DateTime YearOfPublication { get; set; }
        public int NumberOfPages { get; set; }
        public decimal AverageGrade { get; set; }
        public byte[] BookCover { get; set; }

        public virtual List<Evaluation> Evaluations { get; set; }

    }
}