using System;
using System.Collections.Generic;

namespace Tumakov_Упражнение_13._2
{
    class BankAccount
    {
        public int AccountNumber { get; }
        public string AccountType { get; }
        public string AccountHolder { get; }

        private List<BankTransaction> transactions;

        public BankAccount(int account_number, string account_type, string account_holder)
        {
            AccountNumber = account_number;
            AccountType = account_type;
            AccountHolder = account_holder;
            transactions = new List<BankTransaction>();
        }

        public void AddTransaction(BankTransaction transaction)
        {
            transactions.Add(transaction);
        }

        public BankTransaction this[int index]
        {
            get { return transactions[index]; }
        }
    }
}
