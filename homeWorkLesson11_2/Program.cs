using System;

namespace homeWorkLesson11_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var trains = new Train[5];

            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine("Введите номер поезда:");
                trains[i].Number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Введите назначение:");
                trains[i].Destination = Console.ReadLine();

                Console.WriteLine("Введите время прибытия:");
                trains[i].DepartureTime = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(new string('-', 25));
            }

            Console.WriteLine("Введите номер поезда для поиска:");
            int trainNumber = Convert.ToInt32(Console.ReadLine());

            if (FindTrainByNumber(trainNumber, trains, out Train findTrain))
            {
                Console.WriteLine($"Поезд найден!\r\nНазначение: {findTrain.Destination}\r\nВремя прибытия: {findTrain.DepartureTime}");
            }

            Console.ReadKey();
        }

        static bool FindTrainByNumber(int number, Train[] trains, out Train findTrain)
        {
            foreach (var train in trains)
            {
                if (number == train.Number)
                {
                    findTrain = train;
                    return true;
                }
            }

            findTrain = default;

            return false;
        }
    }
}
