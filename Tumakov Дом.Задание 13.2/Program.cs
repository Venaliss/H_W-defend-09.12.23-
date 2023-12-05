using System;

namespace Tumakov_Дом.Задание_13._2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Создать класс для нескольких зданий. Поле класса – массив на 10 зданий. В классе создать индексатор, возвращающий здание по его номеру.*/
            Console.WriteLine("Тумаков 13 Домашнее Задание 2 - Создать класс для нескольких зданий. Поле класса – массив на 10 зданий. В классе создать индексатор, возвращающий здание по его номеру.");
            Building building = new Building(27.5, 11, 308, 2);
            building.PrintBuildingDetails();

            double floor_height = building.GetFloorHeight();
            Console.WriteLine($"Высота одного этажа: {floor_height}");

            int apartments_per_entrance = building.GetApartmentsPerEntrance();
            Console.WriteLine($"Общее количество квартир на подъезд: {apartments_per_entrance}");

            int apartments_per_floor = building.GetApartmentsPerFloor();
            Console.WriteLine($"Общее количество квартир на этаж: {apartments_per_floor}\n");

            Building[] buildings = new Building[10];
            for (int i = 0; i < 10; i++)
            {
                buildings[i] = new Building(60.0, 12, 120, 3);
            }

            Building building2 = buildings[2];
            building2.PrintBuildingDetails();

            Console.Write("\nНажмите на любую клавишу, чтобы выйти.");
            Console.ReadKey();
        }
    }
}
