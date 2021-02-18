using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Train
    {
        private PartOfTheTrain[] railwayCarriages;

        public Train(PartOfTheTrain[] railwayCarriages)
        {
            this.railwayCarriages = railwayCarriages;
        }

        public int GetTotalPassagners()
        {
            int total = 0;
            for (int i = 0; i < railwayCarriages.Length; i++)
            {
                total += railwayCarriages[i].PassangerQuantity;
            }

            return total;
        }

        public int GetTotalBaggages()
        {
            int total = 0;
            for (int i = 0; i < railwayCarriages.Length; i++)
            {
                total += railwayCarriages[i].BaggageQuantity;
            }

            return total;
        }

        public Dictionary<string, int> SortByComfort(Dictionary<string, int> pairs)
        {
            for (int i = 0; i < railwayCarriages.Length; i++)
            {
                pairs.Add($"Вагон №{i + 1}", railwayCarriages[i].ComfortLevel);
            }
            pairs = pairs.OrderBy(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);

            return pairs;
        }

        public void SearchRailwayCarriage(string lowStr, string highStr)
        {
            string result = "";
            bool flag = false;
            int low = 0, high = 0;
            try
            {
                low = Int32.Parse(lowStr);
                high = Int32.Parse(highStr);
                flag = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Введеное должно быть целым и положительным числом");
            }


            if (flag)
            {
                if (high >= low && low > 0 && high % 1 == 0 && low % 1 == 0)
                {
                    for (int i = 0; i < railwayCarriages.Length; i++)
                    {
                        if (railwayCarriages[i].PassangerQuantity >= low && high >= railwayCarriages[i].PassangerQuantity)
                        {
                            result += $"Вагон №{i + 1}, ";
                        }
                    }
                    result = result.Remove(result.Length - 2, 2);
                    Console.WriteLine($"Найдены такие вагоны: {result}");
                }
                else
                {
                    Console.WriteLine("Числа должны быть целыми и положительными, а также верхняя граница должна быть больше, чем нижняя");
                }
            }
            
        }
    }
}
