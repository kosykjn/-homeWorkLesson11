using System;

namespace homeWorkLesson11_4
{
    static class TextColor
    {
        public static void Print(string str, EnumColor color)
        {
            switch (color)
            {
                case EnumColor.Green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(str);
                    break;
                case EnumColor.Black:
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(str);
                    break;
                case EnumColor.Yellow:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(str);
                    break;
                case EnumColor.Red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(str);
                    break;
                default:
                    Console.WriteLine("Такого цвета нету в базе!");
                    break;
            }
        }
    }
    enum EnumColor
    {
        Green = 1,
        Black = 2,
        Yellow = 3,
        Red = 4
    }
}
