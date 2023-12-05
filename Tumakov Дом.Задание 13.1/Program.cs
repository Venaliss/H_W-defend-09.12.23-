using System;

namespace Tumakov_Дом.Задание_13._1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*В классе здания из домашнего задания 7.1 все методы для заполнения и получения значений полей заменить на свойства.Написать тестовый*/
            Console.WriteLine("Тумаков 13 Домашнее Задание 1 - В классе здания из домашнего задания 7.1 все методы для заполнения и получения значений полей заменить на свойства.Написать тестовый пример.");
            Building building = new Building(27.5, 11, 308, 2);
            building.PrintBuildingDetails();

            double floor_height = building.GetFloorHeight();
            Console.WriteLine($"Высота одного этажа: {floor_height}");

            int apartments_per_entrance = building.GetApartmentsPerEntrance();
            Console.WriteLine($"Общее количество квартир на подъезд: {apartments_per_entrance}");

            int apartments_per_floor = building.GetApartmentsPerFloor();
            Console.WriteLine($"Общее количество квартир на этаж: {apartments_per_floor}");

            Console.Write("\nНажмите на любую клавишу, чтобы выйти.");
            Console.ReadKey();
        }
    }
}
