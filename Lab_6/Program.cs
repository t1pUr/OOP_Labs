using System;
using System.Collections.Generic;

namespace Lab_6
{
    class Program
    {
        // C13 = 9107 % 13
        // C13 = 7
        static void Main(string[] args)
        {
            PartOfTheTrain railway_carriage1 = new Railway_carriage1(100, 40, 30);

            PartOfTheTrain railway_carriage2 = new Railway_carriage2(130, 50, 86);

            PartOfTheTrain railway_carriage3 = new Railway_carriage3(50, 20, 67);

            PartOfTheTrain[] railway_carriages = { railway_carriage1, railway_carriage2, railway_carriage3 };

            Train train = new Train(new PartOfTheTrain[] { railway_carriage1, railway_carriage2, railway_carriage3 });

            for (int i = 0; i < railway_carriages.Length; i++)
            {
                Console.WriteLine($"Вагон №{i + 1}:");
                Console.WriteLine($"Всего пассажиров в вагоне: {railway_carriages[i].PassangerQuantity}");
                Console.WriteLine($"Количество багажа в вагоне: {railway_carriages[i].BaggageQuantity}");
                Console.WriteLine($"Уровень комфорта: {railway_carriages[i].ComfortLevel}%\n");
            }

            int totalPassangers = train.GetTotalPassagners();
            Console.WriteLine($"Всего пассажиров в поезде: {totalPassangers}");

            int totalBaggages = train.GetTotalBaggages();
            Console.WriteLine($"Всего багажа в поезде: {totalBaggages}\n");

            Dictionary<string, int> pairs = new Dictionary<string, int>();

            pairs = train.SortByComfort(pairs);

            Console.WriteLine("Сортировка вагонов поезда за комфортом по возрастанию: ");

            foreach (KeyValuePair<string, int> keyValue in pairs)
            {
                Console.WriteLine(keyValue.Key + " - Уровень комфотра: " + keyValue.Value + "%");
            }
            Console.WriteLine();

            Console.Write("Введите нижнюю границу пассажров, чтобы найти нужные вагон(ы): ");
            string low = Console.ReadLine();
            Console.Write("Введите верхнюю границу пассажров, чтобы найти нужные вагон(ы): ");
            string high = Console.ReadLine();

            train.SearchRailwayCarriage(low, high);

            Console.ReadKey();
        }
    }
}
