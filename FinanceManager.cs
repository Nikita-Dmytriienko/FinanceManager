using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;


namespace CS02_12_24.Models
{
    public class FinanceManager
    {
        private string _dataPath;
        private List<Transaction> _transactions = new List<Transaction>();

        public FinanceManager(string dataPath)
        {
            _dataPath = dataPath;

            if (File.Exists(_dataPath))
            {
                string json = File.ReadAllText(_dataPath);
                _transactions = JsonConvert.DeserializeObject<List<Transaction>>(json) ?? new List<Transaction>();
            }
        }

        public void AddTransaction(List<Transaction> transactions)
        {
            Console.Write("Enter amount: ");
            decimal amount = decimal.Parse(Console.ReadLine());

            Console.Write("Type of operation (income/expenses): ");
            string type = Console.ReadLine();

            Console.Write("Descryption of operation: ");
            string description = Console.ReadLine();
            transactions.Add(new Transaction
            {
                Date = DateTime.Now,
                Amount = amount,
                Type = type,
                Description = description
            });
            Console.WriteLine("Operation Successful.");
        }
        private static void ShowBalance(List<Transaction> transactions)
        {
            decimal balance = transactions.Sum(t => t.Type.ToLower() == "income" ? t.Amount : -t.Amount);
            Console.WriteLine($"Current balance: {balance}");
        }
        private static void ShowHistory(List<Transaction> transactions)
        {
            Console.WriteLine("History of operations:");
            foreach (var t in transactions)
            {
                Console.WriteLine($"{t.Date}: {t.Type} - {t.Amount} ({t.Description})");
            }
        }

    }
}


