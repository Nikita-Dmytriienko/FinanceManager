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

    }
}

