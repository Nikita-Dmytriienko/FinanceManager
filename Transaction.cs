using System;


namespace CS02_12_24.Models
{
    public class Transaction
    {
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string Type { get; set; } // "Доход" или "Расход"
        public string Description { get; set; }
    }

}

