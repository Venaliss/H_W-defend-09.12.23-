using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Тумаков 13 Упражнение 1 - удалить методы из классов банковского счета и BankTransaction, заменить свойствами.*/
            Console.WriteLine("Тумаков 13 Упражнение 1 - удалить методы из классов банковского счета и BankTransaction, заменить свойствами");
            BankAccount acc = new BankAccount(564156465, "Накопительный", "Эрен Йегер");
            Console.WriteLine("Номер счета: " + acc.AccountNumber);
            Console.WriteLine("Тип счета: " + acc.AccountType);
            Console.WriteLine("Держатель банковского счета: " + acc.AccountHolder);

            BankTransaction trans = new BankTransaction(DateTime.Now, 14156514, "Внесено");
            Console.WriteLine("\nВремя транзакции: " + trans.Date);
            Console.WriteLine("Сумма транзакии: " + trans.Amount);
            Console.WriteLine("Описание транзакции: " + trans.Description);
            
            Console.Write("\nНажмите на любую клавишу, чтобы выйти.");
            Console.ReadKey();
        }
    }
}
