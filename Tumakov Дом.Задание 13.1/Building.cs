using System;

namespace Tumakov_Дом.Задание_13._1
{
    class Building
    {
        private static int lastBuildingNumber = 0;

        public int BuildingNumber { get; private set; }
        public double Height { get; set; }
        public int Floors { get; set; }
        public int Apartments { get; set; }
        public int Entrances { get; set; }

        public Building(double height, int floors, int apartments, int entrances)
        {
            BuildingNumber = GenerateBuildingNumber();
            Height = height;
            Floors = floors;
            Apartments = apartments;
            Entrances = entrances;
        }

        private static int GenerateBuildingNumber()
        {
            return ++lastBuildingNumber;
        }

        public double GetFloorHeight()
        {
            return Height / Floors;
        }

        public int GetApartmentsPerEntrance()
        {
            return Apartments / Entrances;
        }

        public int GetApartmentsPerFloor()
        {
            return Apartments / Floors;
        }

        public void PrintBuildingDetails()
        {
            Console.WriteLine($"Номер здания: {BuildingNumber}");
            Console.WriteLine($"Высота: {Height}");
            Console.WriteLine($"Этажи {Floors}");
            Console.WriteLine($"Квартиры: {Apartments}");
            Console.WriteLine($"Подьезды: {Entrances}");
        }

    }
}
