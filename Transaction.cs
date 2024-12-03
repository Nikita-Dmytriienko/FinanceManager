namespace CS02_12_24.Models
{
    public class Transaction
    {
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public required string Type { get; set; } // "income" or "expenses"
        public required string Description { get; set; }
    }
}
