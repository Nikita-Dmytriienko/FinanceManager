﻿using System;
using System.Collections.Generic;
using System.IO;
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

            //launch 
            if (File.Exists(_dataPath))
            {
                string json = File.ReadAllText(_dataPath);
                _transactions = JsonConvert.DeserializeObject<List<Transaction>>(json) ?? new List<Transaction>();
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
                balance += t.Type.ToLower() == "income" ? t.Amount : -t.Amount;
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
            File.WriteAllText(_dataPath, JsonConvert.SerializeObject(_transactions));
            Console.WriteLine("Data saved.");
        }

    }
}


