using System;
using System.Diagnostics;


namespace Tumakov_Упражнение_14._1
{
    class BankAccount
    {
        public decimal AccountNumber { get; set; }
        public string AccountType { get; set; }
        public string AccountHolder { get; set; }

        [Conditional("DEBUG_ACCOUNT")]
        public void DumpToScreen()
        {
            Console.WriteLine("Номер счета: " + AccountNumber);
            Console.WriteLine("Тип счета: " + AccountType);
            Console.WriteLine("Владелец банковского счета: " + AccountHolder);

        }
    }
}
