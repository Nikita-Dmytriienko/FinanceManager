using System;
namespace CS02_12_24.Models
{
    public class FinanceManager
    {
        private List<Transaction> transactions = new List<Transaction>();

        public void AddTransaction(decimal amount, string type, string description)
        {
            transactions.Add(new Transaction
            {
                Date = DateTime.Now,
                Amount = amount,
                Type = type,
                Description = description
            });
        }
        decimal GetBalance()
        {
            return transactions.Sum(t => t.Type == "Доход" ? t.Amount : -t.Amount);
        }
        void ShowHistory(DateTime? from = null, DateTime? to = null)
        {
            var filtered = transactions.Where(t => (!from.HasValue || t.Date >= from) && (!to.HasValue || t.Date <= to));
            foreach (var transaction in filtered)
            {
                Console.WriteLine($"{transaction.Date}: {transaction.Type} - {transaction.Amount} ({transaction.Description})");
            }
        }

    }
}


