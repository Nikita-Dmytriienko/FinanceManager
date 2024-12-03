using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;


namespace CS02_12_24.Models
{
    public class FinanceManager
    {
        private readonly string _dataPath;
        private readonly List<Transaction> _transactions = [];

        public FinanceManager(string dataPath)
        {
            _dataPath = dataPath;

            //launch 
            try
            {
                if (File.Exists(_dataPath))
                {
                    string json = File.ReadAllText(_dataPath);
                    _transactions = JsonConvert.DeserializeObject<List<Transaction>>(json) ?? new List<Transaction>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading data: {ex.Message}");
                _transactions = new List<Transaction>();
            }
        }

        public void AddTransaction()
        {
            Console.Write("Enter amount: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Type of operation (income/expenses): ");
            string type = Console.ReadLine();

            Console.Write("Descryption of operation: ");
            string description = Console.ReadLine();

            _transactions.Add(new Transaction
            {
                Date = DateTime.Now,
                Amount = amount,
                Type = type,
                Description = description
            });
            Console.WriteLine("Operation Added.");
        }

        public void ShowBalance()
        {
            decimal balance = 0;
            foreach (var t in _transactions)
            {
                balance += t.Type.Equals("income", StringComparison.CurrentCultureIgnoreCase) ? t.Amount : -t.Amount;
            }
            Console.WriteLine($"Balance: {balance}");
        }

        public void ShowHistory()
        {
            Console.WriteLine("History:");
            foreach (var t in _transactions)
            {
                Console.WriteLine($"{t.Date}: {t.Type} - {t.Amount} ({t.Description})");
            }
        }

        public void SaveTransactions()
        {
            Directory.CreateDirectory(Path.GetDirectoryName(_dataPath));
            File.WriteAllText(_dataPath, JsonConvert.SerializeObject(_transactions));
            Console.WriteLine("Data saved.");
        }
        public void ClearHistory()
        {
            _transactions.Clear();
            Console.WriteLine("Transaction history cleared.");
            SaveTransactions();
        }
    }
}


