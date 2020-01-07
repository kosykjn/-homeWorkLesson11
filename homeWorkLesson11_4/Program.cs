using System;

namespace homeWorkLesson11_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();

            Console.WriteLine("Выберите цвет:");
            for (EnumColor number = EnumColor.Green; number <= EnumColor.Red; number++)
            {
                Console.WriteLine($"{(byte)number} - {number}");
            }

            EnumColor color = (EnumColor)Convert.ToInt32(Console.ReadLine());

            TextColor.Print(text, color);

            Console.ReadKey();
        }
    }
}
