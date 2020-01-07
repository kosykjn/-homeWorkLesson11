using System;

namespace homeWorkLesson11_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var accauntant = new Accountant();

            var postNames = Enum.GetNames(typeof(Post));
            var postValues = (Post[])Enum.GetValues(typeof(Post));

            for (var index = 0; index < postNames.Length; index++)
            {
                Console.WriteLine($"[{index}] - {postNames[index]}");
            }

            Console.WriteLine("Введите свою должность:");
            var postIndex = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите кол-во отработанных часов за месяц:");
            var hours = Convert.ToInt32(Console.ReadLine());

            if (accauntant.AskForBonus(postValues[postIndex], hours))
            {
                Console.WriteLine("Забирай свою премию и вали отсюда!");
            }
            else
            {
                Console.WriteLine("Какая премия, скажи спасибо что тебя не уволили!");
            }


            Console.ReadKey();
        }
    }

}
