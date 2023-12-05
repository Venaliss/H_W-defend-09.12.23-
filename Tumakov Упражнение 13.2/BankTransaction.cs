using System;

namespace Tumakov_Упражнение_13._2
{
    class BankTransaction
    {
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Description { get; }

        public BankTransaction(decimal amount, DateTime date, string description)
        {
            Amount = amount;
            Date = date;
            Description = description;
        }
    }
}
