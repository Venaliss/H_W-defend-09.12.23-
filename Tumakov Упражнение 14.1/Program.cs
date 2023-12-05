#define DEBUG_ACCOUNT
using System;

namespace Tumakov_Упражнение_14._1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Тумаков Упражнение 14.1 - В классе банковский счет добавить метод DumpToScreen, который отображает детали банковского счета.
             Для выполнения этого метода использовать условный атрибут, зависящий от символа условной компиляции DEBUG_ACCOUNT.*/
            Console.WriteLine("Тумаков Упражнение 14.1 - В классе банка добавить метод DumpToScreen для выполнения которого использовать условный атрибут DEBUG_ACCOUNT\n");
            BankAccount account = new BankAccount();
            account.AccountNumber = 16547877997;
            account.AccountHolder = "Эрен Йегер";
            account.AccountType = "Накопительный";
            account.DumpToScreen();

            Console.Write("\nНажмите на любую клавишу, чтобы выйти.");
            Console.ReadKey();
        }
    }
}
