using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;


namespace CS02_12_24.Models
{
    public class FinanceManager
    {
        private List<Transaction> transactions = new List<Transaction>();

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


