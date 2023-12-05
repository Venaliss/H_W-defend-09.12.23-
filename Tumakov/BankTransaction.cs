using System;

namespace Tumakov
{
    class BankTransaction
    {
        public DateTime Date { get; }
        public decimal Amount { get; }
        public string Description { get; }

        public BankTransaction(DateTime date, decimal amount, string description)
        {
            Date = date;
            Amount = amount;
            Description = description;
        }
    }
}
