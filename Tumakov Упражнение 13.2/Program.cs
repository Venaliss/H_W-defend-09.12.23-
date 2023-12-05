using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_Упражнение_13._2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Тумаков Упражнение 13.2 - Добавить индексатор в класс банковский счет для получения доступа к любому объекту BankTransaction.*/
            Console.WriteLine("Тумаков Упражнение 13.2 - Добавить индексатор в класс банковский счет для получения доступа к любому объекту BankTransaction.");
            BankAccount account = new BankAccount(1247967, "Накопительный", "Эрен Йегер");

            BankTransaction transaction = new BankTransaction(100000, DateTime.Now, "Зарплата");
            account.AddTransaction(transaction);

            BankTransaction firstTransaction = account[0];

            Console.WriteLine($"Сумма транзакции: {firstTransaction.Amount}");
            Console.WriteLine($"Время транзакции: {firstTransaction.Date}");
            Console.WriteLine($"Тип транзакции: {firstTransaction.Description}");

            Console.Write("\nНажмите на любую клавишу, чтобы выйти.");
            Console.ReadKey();
        }
    }
}
