using System;

namespace Tumakov
{
    class BankAccount
    {
        public int AccountNumber { get; }
        public string AccountType { get; }
        public string AccountHolder { get; set; }

        public BankAccount(int account_number, string account_type, string account_holder)
        {
            AccountNumber = account_number;
            AccountType = account_type;
            AccountHolder = account_holder;
        }
    }
}
